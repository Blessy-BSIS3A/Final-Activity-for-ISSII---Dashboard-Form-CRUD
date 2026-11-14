
using System;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Windows.Forms;

namespace Cortez_FinalAct
{
    public partial class DashboardForm : Form
    {
        private int selectedProductID = 0;


        public DashboardForm()
        {
            InitializeComponent();

            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new object[]
            {
        "Electronics",
        "Accessories",
        "Furniture",
        "School Supplies",
        "Others"
            });

            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            ConfigureDataGridView();

            // Remove existing subscriptions before adding them.
            btnAdd.Click -= btnAdd_Click;
            btnUpdate.Click -= btnUpdate_Click;
            btnDelete.Click -= btnDelete_Click;
            btnClear.Click -= btnClear_Click;
            btnRefresh.Click -= btnRefresh_Click;
            btnLogout.Click -= btnLogout_Click;

            txtSearch.TextChanged -= txtSearch_TextChanged;
            dgvProducts.CellClick -= dgvProducts_CellClick;

            // Register each event only once.
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnLogout.Click += btnLogout_Click;

            txtSearch.TextChanged += txtSearch_TextChanged;
            dgvProducts.CellClick += dgvProducts_CellClick;

            LoadProducts();
            UpdateDashboardCounts();
        }


        // DATA GRID VIEW
        private void ConfigureDataGridView()
        {
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.MultiSelect = false;
            dgvProducts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.RowHeadersVisible = false;
            dgvProducts.AutoGenerateColumns = true;
        }

        // LOAD PRODUCTS
        private void LoadProducts(string search = "")
        {
            try
            {
                using (OleDbConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT ProductID, ProductName, Category,
                               Quantity, UnitPrice, Description
                        FROM Products";

                    if (!string.IsNullOrWhiteSpace(search))
                    {
                        query += @"
                            WHERE InStr(1, ProductName, ?, 1) > 0
                               OR InStr(1, Category, ?, 1) > 0";
                    }

                    query += " ORDER BY ProductID ASC";

                    using (OleDbCommand cmd =
                        new OleDbCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(search))
                        {
                            cmd.Parameters.AddWithValue("@name", search);
                            cmd.Parameters.AddWithValue("@category", search);
                        }

                        using (OleDbDataAdapter adapter =
                            new OleDbDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            // Add consecutive display numbering.
                            DataColumn numberColumn =
                                new DataColumn("No.", typeof(int));

                            table.Columns.Add(numberColumn);
                            numberColumn.SetOrdinal(0);

                            for (int i = 0; i < table.Rows.Count; i++)
                            {
                                table.Rows[i]["No."] = i + 1;
                            }

                            dgvProducts.DataSource = null;
                            dgvProducts.DataSource = table;

                            // Hide the actual database ID.
                            dgvProducts.Columns["ProductID"].Visible = false;

                            dgvProducts.Columns["No."].HeaderText = "No.";
                            dgvProducts.Columns["ProductName"].HeaderText =
                                "Product Name";
                            dgvProducts.Columns["Category"].HeaderText =
                                "Category";
                            dgvProducts.Columns["Quantity"].HeaderText =
                                "Quantity";
                            dgvProducts.Columns["UnitPrice"].HeaderText =
                                "Unit Price";
                            dgvProducts.Columns["Description"].HeaderText =
                                "Description";

                            dgvProducts.Columns["UnitPrice"]
                                .DefaultCellStyle.Format = "C2";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load products.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // DASHBOARD COUNTS
        private void UpdateDashboardCounts()
        {
            try
            {
                using (OleDbConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT COUNT(*) AS TotalProducts,
                               SUM(IIF(Quantity <= 5, 1, 0)) AS LowStock
                        FROM Products";

                    using (OleDbCommand cmd =
                        new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblTotalProducts.Text =
                                    reader["TotalProducts"].ToString();

                                lblLowStock.Text =
                                    reader["LowStock"] == DBNull.Value
                                    ? "0"
                                    : reader["LowStock"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update dashboard counts.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // VALIDATE INPUTS
        private bool ValidateProduct(
            out int quantity,
            out decimal unitPrice)
        {
            quantity = 0;
            unitPrice = 0;

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name.");
                txtProductName.Focus();
                return false;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
                cmbCategory.Focus();
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out quantity)
                || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                txtQuantity.Focus();
                return false;
            }

            if (!decimal.TryParse(
                txtUnitPrice.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Please enter a valid unit price.");
                txtUnitPrice.Focus();
                return false;
            }

            return true;
        }

        // ADD PRODUCT
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int quantity;
            decimal unitPrice;

            if (!ValidateProduct(out quantity, out unitPrice))
                return;

            try
            {
                using (OleDbConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO Products
                        (ProductName, Category, Quantity,
                         UnitPrice, Description)
                        VALUES (?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd =
                        new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@name", txtProductName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@category", cmbCategory.Text);

                        cmd.Parameters.AddWithValue(
                            "@quantity", quantity);

                        cmd.Parameters.AddWithValue(
                            "@price", unitPrice);

                        cmd.Parameters.AddWithValue(
                            "@description", txtDescription.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product added successfully!");

                ClearFields();
                LoadProducts();
                UpdateDashboardCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to add product.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // SELECT PRODUCT FROM GRID
        private void dgvProducts_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

            selectedProductID =
                Convert.ToInt32(row.Cells["ProductID"].Value);

            txtProductName.Text =
                Convert.ToString(row.Cells["ProductName"].Value);

            cmbCategory.Text =
                Convert.ToString(row.Cells["Category"].Value);

            txtQuantity.Text =
                Convert.ToString(row.Cells["Quantity"].Value);

            txtUnitPrice.Text =
                Convert.ToString(row.Cells["UnitPrice"].Value);

            txtDescription.Text =
                row.Cells["Description"].Value == DBNull.Value
                ? ""
                : Convert.ToString(row.Cells["Description"].Value);
        }

        // UPDATE PRODUCT
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductID == 0)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            int quantity;
            decimal unitPrice;

            if (!ValidateProduct(out quantity, out unitPrice))
                return;

            try
            {
                using (OleDbConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        UPDATE Products
                        SET ProductName = ?,
                            Category = ?,
                            Quantity = ?,
                            UnitPrice = ?,
                            Description = ?
                        WHERE ProductID = ?";

                    using (OleDbCommand cmd =
                        new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@name", txtProductName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@category", cmbCategory.Text);

                        cmd.Parameters.AddWithValue(
                            "@quantity", quantity);

                        cmd.Parameters.AddWithValue(
                            "@price", unitPrice);

                        cmd.Parameters.AddWithValue(
                            "@description", txtDescription.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@id", selectedProductID);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product updated successfully!");

                ClearFields();
                LoadProducts();
                UpdateDashboardCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update product.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // DELETE PRODUCT
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductID == 0)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (OleDbConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query =
                        "DELETE FROM Products WHERE ProductID = ?";

                    using (OleDbCommand cmd =
                        new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id", selectedProductID);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product deleted successfully!");

                ClearFields();
                LoadProducts();
                UpdateDashboardCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to delete product.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // CLEAR INPUT FIELDS
        private void ClearFields()
        {
            selectedProductID = 0;

            txtProductName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtQuantity.Clear();
            txtUnitPrice.Clear();
            txtDescription.Clear();

            dgvProducts.ClearSelection();
            txtProductName.Focus();
        }

        // CLEAR BUTTON
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // SEARCH PRODUCTS
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text.Trim());
        }

        // REFRESH PRODUCTS
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadProducts();
            UpdateDashboardCounts();
            ClearFields();
        }

        // LOGOUT
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

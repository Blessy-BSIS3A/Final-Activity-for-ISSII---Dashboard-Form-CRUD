namespace Cortez_FinalAct
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnLogout = new Button();
            lblTitle = new Label();
            pnlTotalProducts = new Panel();
            lblTotalProducts = new Label();
            lblTotalTitle = new Label();
            panel2 = new Panel();
            lblLowStock = new Label();
            lblLowStockTitle = new Label();
            pnlProductInfo = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtUnitPrice = new TextBox();
            lblUnitPrice = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            lblProductInfo = new Label();
            panel3 = new Panel();
            dgvProducts = new DataGridView();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            lblProductList = new Label();
            panel1.SuspendLayout();
            pnlTotalProducts.SuspendLayout();
            panel2.SuspendLayout();
            pnlProductInfo.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 55);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.PaleVioletRed;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(777, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(95, 32);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Cortez Inventory";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTotalProducts
            // 
            pnlTotalProducts.BackColor = Color.White;
            pnlTotalProducts.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalProducts.Controls.Add(lblTotalProducts);
            pnlTotalProducts.Controls.Add(lblTotalTitle);
            pnlTotalProducts.Location = new Point(12, 70);
            pnlTotalProducts.Name = "pnlTotalProducts";
            pnlTotalProducts.Size = new Size(409, 85);
            pnlTotalProducts.TabIndex = 1;
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.BackColor = Color.Transparent;
            lblTotalProducts.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalProducts.ForeColor = Color.Maroon;
            lblTotalProducts.Location = new Point(12, 42);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(22, 25);
            lblTotalProducts.TabIndex = 1;
            lblTotalProducts.Text = "0";
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.BackColor = Color.Transparent;
            lblTotalTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTitle.ForeColor = Color.DimGray;
            lblTotalTitle.Location = new Point(12, 12);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(131, 25);
            lblTotalTitle.TabIndex = 0;
            lblTotalTitle.Text = "Total Products";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblLowStock);
            panel2.Controls.Add(lblLowStockTitle);
            panel2.Location = new Point(427, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 85);
            panel2.TabIndex = 2;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLowStock.ForeColor = Color.IndianRed;
            lblLowStock.Location = new Point(12, 42);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(22, 25);
            lblLowStock.TabIndex = 1;
            lblLowStock.Text = "0";
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.AutoSize = true;
            lblLowStockTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLowStockTitle.ForeColor = Color.DimGray;
            lblLowStockTitle.Location = new Point(12, 12);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(95, 25);
            lblLowStockTitle.TabIndex = 0;
            lblLowStockTitle.Text = "Low Stock";
            // 
            // pnlProductInfo
            // 
            pnlProductInfo.BackColor = Color.White;
            pnlProductInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlProductInfo.Controls.Add(btnClear);
            pnlProductInfo.Controls.Add(btnDelete);
            pnlProductInfo.Controls.Add(btnUpdate);
            pnlProductInfo.Controls.Add(btnAdd);
            pnlProductInfo.Controls.Add(txtDescription);
            pnlProductInfo.Controls.Add(lblDescription);
            pnlProductInfo.Controls.Add(txtUnitPrice);
            pnlProductInfo.Controls.Add(lblUnitPrice);
            pnlProductInfo.Controls.Add(txtQuantity);
            pnlProductInfo.Controls.Add(lblQuantity);
            pnlProductInfo.Controls.Add(cmbCategory);
            pnlProductInfo.Controls.Add(lblCategory);
            pnlProductInfo.Controls.Add(txtProductName);
            pnlProductInfo.Controls.Add(lblProductName);
            pnlProductInfo.Controls.Add(lblProductInfo);
            pnlProductInfo.Location = new Point(12, 161);
            pnlProductInfo.Name = "pnlProductInfo";
            pnlProductInfo.Size = new Size(860, 165);
            pnlProductInfo.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DimGray;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(708, 120);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 30);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(607, 120);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 30);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.PaleVioletRed;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(508, 120);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 30);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(410, 120);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.LavenderBlush;
            txtDescription.ForeColor = Color.Maroon;
            txtDescription.Location = new Point(130, 108);
            txtDescription.MaxLength = 255;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(200, 42);
            txtDescription.TabIndex = 10;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.ForeColor = Color.Maroon;
            lblDescription.Location = new Point(15, 112);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = Color.LavenderBlush;
            txtUnitPrice.ForeColor = Color.Maroon;
            txtUnitPrice.Location = new Point(500, 74);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(200, 23);
            txtUnitPrice.TabIndex = 8;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.BackColor = Color.Transparent;
            lblUnitPrice.ForeColor = Color.Maroon;
            lblUnitPrice.Location = new Point(410, 78);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(58, 15);
            lblUnitPrice.TabIndex = 7;
            lblUnitPrice.Text = "Unit Price";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.LavenderBlush;
            txtQuantity.ForeColor = Color.Maroon;
            txtQuantity.Location = new Point(130, 73);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 23);
            txtQuantity.TabIndex = 6;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.ForeColor = Color.Maroon;
            lblQuantity.Location = new Point(15, 78);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.LavenderBlush;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FlatStyle = FlatStyle.Flat;
            cmbCategory.ForeColor = Color.Maroon;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(500, 42);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 23);
            cmbCategory.TabIndex = 4;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.ForeColor = Color.Maroon;
            lblCategory.Location = new Point(410, 42);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.LavenderBlush;
            txtProductName.ForeColor = Color.Maroon;
            txtProductName.Location = new Point(130, 38);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(200, 23);
            txtProductName.TabIndex = 2;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.ForeColor = Color.Maroon;
            lblProductName.Location = new Point(15, 42);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(84, 15);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product Name";
            // 
            // lblProductInfo
            // 
            lblProductInfo.AutoSize = true;
            lblProductInfo.BackColor = Color.Transparent;
            lblProductInfo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductInfo.ForeColor = Color.Maroon;
            lblProductInfo.Location = new Point(15, 8);
            lblProductInfo.Name = "lblProductInfo";
            lblProductInfo.Size = new Size(153, 20);
            lblProductInfo.TabIndex = 0;
            lblProductInfo.Text = "Product Information";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dgvProducts);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(lblProductList);
            panel3.Location = new Point(12, 332);
            panel3.Name = "panel3";
            panel3.Size = new Size(860, 167);
            panel3.TabIndex = 4;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = Color.LightPink;
            dgvProducts.Location = new Point(14, 40);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(829, 113);
            dgvProducts.TabIndex = 8;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.PaleVioletRed;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(427, 11);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(81, 23);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.LavenderBlush;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.ForeColor = Color.Maroon;
            txtSearch.Location = new Point(130, 11);
            txtSearch.MaxLength = 100;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(278, 23);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblProductList
            // 
            lblProductList.AutoSize = true;
            lblProductList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductList.ForeColor = Color.Maroon;
            lblProductList.Location = new Point(12, 12);
            lblProductList.Name = "lblProductList";
            lblProductList.Size = new Size(100, 21);
            lblProductList.TabIndex = 5;
            lblProductList.Text = "Product List";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(884, 511);
            Controls.Add(panel3);
            Controls.Add(pnlProductInfo);
            Controls.Add(panel2);
            Controls.Add(pnlTotalProducts);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cortez Inventory";
            panel1.ResumeLayout(false);
            pnlTotalProducts.ResumeLayout(false);
            pnlTotalProducts.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlProductInfo.ResumeLayout(false);
            pnlProductInfo.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button btnLogout;
        private Panel pnlTotalProducts;
        private Label lblTotalProducts;
        private Label lblTotalTitle;
        private Panel panel2;
        private Label lblLowStock;
        private Label lblLowStockTitle;
        private Panel pnlProductInfo;
        private Label lblProductInfo;
        private Label lblCategory;
        private TextBox txtProductName;
        private Label lblProductName;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private ComboBox cmbCategory;
        private TextBox txtUnitPrice;
        private Label lblUnitPrice;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Panel panel3;
        private TextBox txtSearch;
        private Label lblProductList;
        private DataGridView dgvProducts;
        private Button btnRefresh;
    }
}
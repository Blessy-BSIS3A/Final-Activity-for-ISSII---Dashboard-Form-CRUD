
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Cortez_FinalAct
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            try
            {
                using (OleDbConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE Username = ? AND Password = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        if (result > 0)
                        {
                            MessageBox.Show("Login successful!");

                            this.Hide();

                            using (DashboardForm dashboard = new DashboardForm())
                            {
                                dashboard.ShowDialog();
                            }

                            this.Show();

                            txtPassword.Clear();
                            txtUsername.Clear();
                            txtUsername.Focus();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid username or password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Login error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // Show or hide password
        private void chkShowPassword_CheckedChanged(
            object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;
        }

        // Open Sign Up form
        private void lnkSignUp_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (SignUpForm signup = new SignUpForm())
            {
                this.Hide();
                signup.ShowDialog();
                this.Show();
            }
        }

        // Return to Welcome Page
        private void btnBack_Click(object sender, EventArgs e)
        {
            using (WelcomePage welcome = new WelcomePage())
            {
                this.Hide();
                welcome.ShowDialog();
            }
        }
    }
}

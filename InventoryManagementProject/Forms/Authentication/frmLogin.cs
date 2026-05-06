using InventoryManagementProject.Forms.Dashboard;
using InventoryManagementProject.Helpers;
using InventoryManagementProject.Models;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InventoryManagementProject.Forms.Authentication
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private AuthManager auth = new AuthManager();
        private PasswordChecker passwordChecker = new PasswordChecker();

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            bool success = await auth.SignIn(email, password);
            if (success)
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                new frmDashboard().Show();
                // Proceed to dashboard or main form
            }
            else
            {
                MessageBox.Show("Login failed. Check your credentials.");
            }
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            var password = txtPassword.Text;
            PasswordStrength strength = passwordChecker.GetPasswordStrength(password);

            if (strength == PasswordStrength.Low)
            {
                MessageBox.Show("Password too weak. Please use a stronger password.");
                return;
            }

            if (strength == PasswordStrength.Medium)
            {
                var result = MessageBox.Show(
                    "Your password is not very strong. Do you still want to continue?",
                    "Weak Password Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                    return;
            }

            string email = txtEmail.Text;


            bool success = await auth.SignUp(email, password);
            if (success)
            {
                MessageBox.Show("Account created! You can now login.");
                this.Hide();
                new frmDashboard().Show();
            }
            else
            {
                MessageBox.Show("Sign up failed. Email might already exist.");
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            var strength = passwordChecker.GetPasswordStrength(txtPassword.Text);

            switch (strength)
            {
                case PasswordStrength.Low:
                    lblStrength.Text = "Password Strength: Low";
                    lblStrength.ForeColor = Color.Red;
                    break;
                case PasswordStrength.Medium:
                    lblStrength.Text = "Password Strength: Medium";
                    lblStrength.ForeColor = Color.Orange;
                    break;
                case PasswordStrength.Strong:
                    lblStrength.Text = "Password Strength: Strong";
                    lblStrength.ForeColor = Color.Green;
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

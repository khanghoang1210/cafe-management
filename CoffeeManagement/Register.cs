using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Register : Form
    {
        CoffeeDBDataContext db = new CoffeeDBDataContext();
        string startupPath;
        Login ParentForm;
        public Register()
        {
            InitializeComponent();
            //startupPath = Login.OriginalForm.startUpPath;
            ParentForm = Login.OriginalForm;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (txtUserName.Text.Trim().Length == 0 ||
                txtPassword.Text.Trim().Length == 0 ||
                txtFullName.Text.Trim().Length == 0)
            {
                MessageBox.Show("User name, Password and Full name are not blank", "Input Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (txtPassword.Text != txtCofirmPass.Text)
            {
                MessageBox.Show("Password and Confirm Password are not matched", "Input Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            User SpecificOne = db.Users.Where(x => x.user_name == txtUserName.Text).FirstOrDefault();
            if (SpecificOne != null)
            {
                MessageBox.Show("User name is exsisted", "Input Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            user.user_name = txtUserName.Text;
            user.full_name = txtFullName.Text;
            user.email = txtEmail.Text;
            user.password = txtPassword.Text;
            db.Users.InsertOnSubmit(user);
            db.SubmitChanges();

            MessageBox.Show("Register successful.", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }
    }
}

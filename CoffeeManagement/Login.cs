using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Login : Form
    {
        CoffeeDBDataContext db = new CoffeeDBDataContext();
        public static User currentUser;
        public static Login OriginalForm;
        //public string startUpPath;
        public bool ResetLogin;

        public Login()
        {
            InitializeComponent();
            OriginalForm = this;
            // startUpPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter pass word", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return;
            }
            User SpecificOne = db.Users.Where(x => (x.user_name == txtUserName.Text) && (x.password == txtPassword.Text)).FirstOrDefault();
            if (SpecificOne == null)
            {
                MessageBox.Show("User name or Password is not matched", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtPassword.Text = "";
                txtPassword.Focus();
            }
            if (SpecificOne != null)
            {
                Home home = new Home();
                currentUser = SpecificOne;
                this.Hide();
                home.ShowDialog();
                this.Show();
            }
        }

        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerWindow = new Register();
            this.Hide();
            registerWindow.ShowDialog();
            this.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApplayGround
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            // get the user email and password from the textboxes
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // hardcode the username and password as admin
            string Username = "admin";
            string Password = "admin";

            // check if the user email and password match the hardcoded values
            bool login = (username == Username) && (password == Password);

            // if login is successful, open the home form and close the login form
            if (login)
            {
                Form homeForm = new Form4();
                homeForm.Show();
                this.Hide();
            }
            // otherwise, show an error message and increment the counter
            else
            {
                lblWrongCredintials.Text = "Invalid email or password. Please try again.";
                //MessageBox.Show("Invalid email or password. Please try again.");
                counter++;
                // if the counter reaches 3, disable the login button and show a message
                if (counter == 3)
                {
                    btnLogin.Enabled = false;
                    // check if the user clicked OK and then close the form
                    if (MessageBox.Show("No more attempts. Please contact the administrator.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void chShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            var passwordChar = chShowPassword.Checked ? '\0' : '*';
            txtPassword.PasswordChar = passwordChar;
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplayGround
{
    public partial class regitrationForm : Form
    {
        public regitrationForm()
        {
            InitializeComponent();
        }

        private static bool invalid = false;

        private static string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Use IdnMapping class to convert Unicode domain names.
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
                // Return true if email is in valid format.
                return Regex.IsMatch(email,
                        @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            var passwordChar = checkBox1.Checked ? '\0' : '*';
            txtPassword.PasswordChar = passwordChar;
            txtConfirmPassword.PasswordChar = passwordChar;
            //if (checkBox1.Checked)
            //{
            //    txtPassword.PasswordChar = '\0';
            //    txtConfirmPassword.PasswordChar = '\0';
            //}
            //else
            //{
            //    txtPassword.PasswordChar = '*';
            //    txtConfirmPassword.PasswordChar = '*';
            //}
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            var passwordMatch = string.Equals(txtPassword.Text, txtConfirmPassword.Text);
            lblPassMatch.ForeColor = passwordMatch ? Color.Green : Color.Red;
            lblPassMatch.Text = passwordMatch ? "Password Matchs" : "Please confirm a matching password!";

            //if (txtPassword.Text != txtConfirmPassword.Text)
            //   {
            //       lblPassMatch.ForeColor = Color.Red;
            //       lblPassMatch.Text = "please Confirm a Matching Password!";
            //   }
            //else
            //   {
            //       lblPassMatch.Text = "";
            //   }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            var passwordMatch = string.Equals(txtEmail.Text, txtEmailConfirm.Text);
            lblConfirmEmail.ForeColor = passwordMatch ? Color.Green : Color.Red;
            lblConfirmEmail.Text = passwordMatch ? "Email Matched" : "Please confirm a matching Email!";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            lblEmailValidation.Text = IsValidEmail(email) ? string.Empty : "email not valid";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private void lblPassMatch_Click(object sender, EventArgs e)
        //{
        //    if (txtPassword.Text != txtConfirmPassword.Text)
        //    {
        //        lblPassMatch.ForeColor = Color.Red;
        //        lblPassMatch.Text = "please Confirm a Matching Password!";
        //    }
        //}
    }
}

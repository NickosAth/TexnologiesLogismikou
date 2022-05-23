using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvManagement
{
    public partial class LoginAndRegister : Form
    {
        public LoginAndRegister()
        {
            InitializeComponent();
        }

        private void button_GoToLogin_Click(object sender, EventArgs e)
        {
            panel_login.BringToFront();
            panel_login_bar.BackColor = Color.Yellow;
            panel_register_bar.BackColor = select_color;
            button_GoToLogin.BackColor = select_color;
            button_GoToRegister.BackColor = Color.Black;
        }

        private void button_GoToRegister_Click(object sender, EventArgs e)
        {
            panel_register.BringToFront();
            panel_register_bar.BackColor = Color.Yellow;
            panel_login_bar.BackColor = select_color;
            button_GoToRegister.BackColor = select_color;
            button_GoToLogin.BackColor = Color.Black;

            adminInfo.Visible = false;
        }
        Color select_color = Color.FromArgb(49, 46, 46);

        private void LoginAndRegister_Load(object sender, EventArgs e)
        {
            button_GoToLogin.PerformClick();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(username.Text == "admin" && password.Text == "admin") { 
            CvManagement cvmanagement = new CvManagement();
                Hide();
            cvmanagement.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstName.Text))
            {
                errorProviderFirstName.SetError(firstName, "First name should not be left blank!");
            }
            else
            {
                errorProviderFirstName.SetError(firstName, "");
            }

            if (string.IsNullOrWhiteSpace(lastName.Text))
            {
                errorProvider1.SetError(lastName, "Last name should not be left blank!");
            }
            else
            {
                errorProvider1.SetError(lastName, "");
            }


            if (string.IsNullOrWhiteSpace(user.Text))
            {
                errorProvider2.SetError(lastName, "Username should not be left blank!");
            }
            else
            {
                errorProvider1.SetError(lastName, "");
            }

            if (pass.Text != confirmPass.Text)
            {
                MessageBox.Show("passwords dont match");
            }

            if(agreeWithTerms.Checked == false)
            {
                MessageBox.Show("you need to agree with terms to continue with registration");
            }

            if (agreeWithTerms.Checked == true)
            {
                completed completed = new();
                completed.Show();
                panel_login.BringToFront();
                panel_login_bar.BackColor = Color.Yellow;
                panel_register_bar.BackColor = select_color;
                button_GoToLogin.BackColor = select_color;
                button_GoToRegister.BackColor = Color.Black;

                lastName.Text = "";
                firstName.Text = "";
                user.Text = "";
                pass.Text = "";
                confirmPass.Text = "";
            }
        }

        private void confirmPass_TextChanged(object sender, EventArgs e)
        {
            if (!pass.Text.Equals(String.Empty) && pass.Text.Equals(confirmPass.Text))
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar) ||
                        Char.IsSeparator(e.KeyChar) ||
                        Char.IsSymbol(e.KeyChar);
        }

        private void termsAndServicesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("•You must be a senior or graduate student to use this application." + "\n" + "•You agree to share your cv and every information required in this app." + "\n" + "•You must respect the privacy of each user of the app.");
        }
    }
}

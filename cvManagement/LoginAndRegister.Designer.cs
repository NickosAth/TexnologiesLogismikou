
namespace cvManagement
{
    partial class LoginAndRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_login = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.panel_register = new System.Windows.Forms.Panel();
            this.termsAndServicesLink = new System.Windows.Forms.LinkLabel();
            this.agreeWithTerms = new System.Windows.Forms.CheckBox();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.button_GoToRegister = new System.Windows.Forms.Button();
            this.button_GoToLogin = new System.Windows.Forms.Button();
            this.adminInfo = new System.Windows.Forms.Label();
            this.panel_register_bar = new System.Windows.Forms.Panel();
            this.panel_login_bar = new System.Windows.Forms.Panel();
            this.errorProviderFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_login.SuspendLayout();
            this.panel_register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.Transparent;
            this.panel_login.Controls.Add(this.password);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.username);
            this.panel_login.Controls.Add(this.label1);
            this.panel_login.Controls.Add(this.login);
            this.panel_login.Location = new System.Drawing.Point(1, 126);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(422, 275);
            this.panel_login.TabIndex = 0;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(127, 81);
            this.password.Name = "password";
            this.password.PlaceholderText = "Fill in your password.";
            this.password.Size = new System.Drawing.Size(241, 26);
            this.password.TabIndex = 16;
            this.password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password:";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(127, 41);
            this.username.Name = "username";
            this.username.PlaceholderText = "Fill in your username.";
            this.username.Size = new System.Drawing.Size(241, 26);
            this.username.TabIndex = 7;
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(126)))), ((int)(((byte)(4)))));
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(11, 143);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(396, 44);
            this.login.TabIndex = 14;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // panel_register
            // 
            this.panel_register.BackColor = System.Drawing.Color.Transparent;
            this.panel_register.Controls.Add(this.termsAndServicesLink);
            this.panel_register.Controls.Add(this.agreeWithTerms);
            this.panel_register.Controls.Add(this.confirmPass);
            this.panel_register.Controls.Add(this.pass);
            this.panel_register.Controls.Add(this.user);
            this.panel_register.Controls.Add(this.label7);
            this.panel_register.Controls.Add(this.label6);
            this.panel_register.Controls.Add(this.label5);
            this.panel_register.Controls.Add(this.lastName);
            this.panel_register.Controls.Add(this.label3);
            this.panel_register.Controls.Add(this.button1);
            this.panel_register.Controls.Add(this.label4);
            this.panel_register.Controls.Add(this.firstName);
            this.panel_register.Location = new System.Drawing.Point(-8, 112);
            this.panel_register.Name = "panel_register";
            this.panel_register.Size = new System.Drawing.Size(437, 300);
            this.panel_register.TabIndex = 17;
            // 
            // termsAndServicesLink
            // 
            this.termsAndServicesLink.AutoSize = true;
            this.termsAndServicesLink.LinkColor = System.Drawing.Color.SlateGray;
            this.termsAndServicesLink.Location = new System.Drawing.Point(30, 215);
            this.termsAndServicesLink.Name = "termsAndServicesLink";
            this.termsAndServicesLink.Size = new System.Drawing.Size(97, 15);
            this.termsAndServicesLink.TabIndex = 25;
            this.termsAndServicesLink.TabStop = true;
            this.termsAndServicesLink.Text = "Terms of Services";
            this.termsAndServicesLink.VisitedLinkColor = System.Drawing.Color.Aqua;
            this.termsAndServicesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.termsAndServicesLink_LinkClicked);
            // 
            // agreeWithTerms
            // 
            this.agreeWithTerms.Font = new System.Drawing.Font("High Tower Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.agreeWithTerms.ForeColor = System.Drawing.Color.White;
            this.agreeWithTerms.Location = new System.Drawing.Point(186, 212);
            this.agreeWithTerms.Name = "agreeWithTerms";
            this.agreeWithTerms.Size = new System.Drawing.Size(232, 24);
            this.agreeWithTerms.TabIndex = 24;
            this.agreeWithTerms.Text = "Agree with the terms of services";
            this.agreeWithTerms.UseVisualStyleBackColor = true;
            // 
            // confirmPass
            // 
            this.confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPass.Location = new System.Drawing.Point(127, 180);
            this.confirmPass.MaxLength = 12;
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.PlaceholderText = "Repeat your password.";
            this.confirmPass.Size = new System.Drawing.Size(291, 26);
            this.confirmPass.TabIndex = 22;
            this.confirmPass.UseSystemPasswordChar = true;
            this.confirmPass.TextChanged += new System.EventHandler(this.confirmPass_TextChanged);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass.Location = new System.Drawing.Point(127, 140);
            this.pass.MaxLength = 12;
            this.pass.Name = "pass";
            this.pass.PlaceholderText = "Fill in your password.";
            this.pass.Size = new System.Drawing.Size(291, 26);
            this.pass.TabIndex = 21;
            this.pass.UseSystemPasswordChar = true;
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user.Location = new System.Drawing.Point(127, 101);
            this.user.Name = "user";
            this.user.PlaceholderText = "Fill in your username. Required.";
            this.user.Size = new System.Drawing.Size(291, 26);
            this.user.TabIndex = 20;
            this.user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Confirm Pass:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "First Name:";
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(127, 61);
            this.lastName.Name = "lastName";
            this.lastName.PlaceholderText = "Fill in your Last Name. Required.";
            this.lastName.Size = new System.Drawing.Size(291, 26);
            this.lastName.TabIndex = 16;
            this.lastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Last Name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(398, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username:";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstName.Location = new System.Drawing.Point(127, 21);
            this.firstName.Name = "firstName";
            this.firstName.PlaceholderText = "Fill in your First Name. Required.";
            this.firstName.Size = new System.Drawing.Size(291, 26);
            this.firstName.TabIndex = 7;
            this.firstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastName_KeyPress);
            // 
            // button_GoToRegister
            // 
            this.button_GoToRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button_GoToRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button_GoToRegister.FlatAppearance.BorderSize = 0;
            this.button_GoToRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GoToRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_GoToRegister.ForeColor = System.Drawing.Color.White;
            this.button_GoToRegister.Location = new System.Drawing.Point(215, 31);
            this.button_GoToRegister.Name = "button_GoToRegister";
            this.button_GoToRegister.Size = new System.Drawing.Size(193, 71);
            this.button_GoToRegister.TabIndex = 16;
            this.button_GoToRegister.Text = "Register";
            this.button_GoToRegister.UseVisualStyleBackColor = false;
            this.button_GoToRegister.Click += new System.EventHandler(this.button_GoToRegister_Click);
            // 
            // button_GoToLogin
            // 
            this.button_GoToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button_GoToLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button_GoToLogin.FlatAppearance.BorderSize = 0;
            this.button_GoToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GoToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_GoToLogin.ForeColor = System.Drawing.Color.White;
            this.button_GoToLogin.Location = new System.Drawing.Point(12, 31);
            this.button_GoToLogin.Name = "button_GoToLogin";
            this.button_GoToLogin.Size = new System.Drawing.Size(193, 71);
            this.button_GoToLogin.TabIndex = 17;
            this.button_GoToLogin.Text = "Login";
            this.button_GoToLogin.UseVisualStyleBackColor = false;
            this.button_GoToLogin.Click += new System.EventHandler(this.button_GoToLogin_Click);
            // 
            // adminInfo
            // 
            this.adminInfo.AutoSize = true;
            this.adminInfo.Font = new System.Drawing.Font("Papyrus", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.adminInfo.ForeColor = System.Drawing.Color.White;
            this.adminInfo.Location = new System.Drawing.Point(12, 10);
            this.adminInfo.Name = "adminInfo";
            this.adminInfo.Size = new System.Drawing.Size(105, 18);
            this.adminInfo.TabIndex = 23;
            this.adminInfo.Text = "*admin login too";
            // 
            // panel_register_bar
            // 
            this.panel_register_bar.Location = new System.Drawing.Point(215, 92);
            this.panel_register_bar.Name = "panel_register_bar";
            this.panel_register_bar.Size = new System.Drawing.Size(193, 10);
            this.panel_register_bar.TabIndex = 24;
            // 
            // panel_login_bar
            // 
            this.panel_login_bar.Location = new System.Drawing.Point(12, 92);
            this.panel_login_bar.Name = "panel_login_bar";
            this.panel_login_bar.Size = new System.Drawing.Size(193, 10);
            this.panel_login_bar.TabIndex = 25;
            // 
            // errorProviderFirstName
            // 
            this.errorProviderFirstName.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // LoginAndRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(420, 410);
            this.Controls.Add(this.panel_login_bar);
            this.Controls.Add(this.panel_register_bar);
            this.Controls.Add(this.adminInfo);
            this.Controls.Add(this.button_GoToLogin);
            this.Controls.Add(this.button_GoToRegister);
            this.Controls.Add(this.panel_register);
            this.Controls.Add(this.panel_login);
            this.Name = "LoginAndRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginAndRegister_Load);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_register.ResumeLayout(false);
            this.panel_register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_GoToRegister;
        private System.Windows.Forms.Button button_GoToLogin;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_register;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label adminInfo;
        private System.Windows.Forms.Panel panel_register_bar;
        private System.Windows.Forms.Panel panel_login_bar;
        private System.Windows.Forms.CheckBox agreeWithTerms;
        private System.Windows.Forms.ErrorProvider errorProviderFirstName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.LinkLabel termsAndServicesLink;
    }
}


namespace TEXMEX
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.labelGoToLogIn = new System.Windows.Forms.Label();
            this.labelCloseR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 691);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(227, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(570, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "CREATE YOUR ACCOUNT";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFirstname.Location = new System.Drawing.Point(161, 179);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(310, 41);
            this.txtFirstname.TabIndex = 200;
            this.txtFirstname.Text = "First name";
            this.txtFirstname.TextChanged += new System.EventHandler(this.txtFirstname_TextChanged);
            this.txtFirstname.Enter += new System.EventHandler(this.txtFirstname_Enter);
            this.txtFirstname.Leave += new System.EventHandler(this.txtFirstname_Leave);
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLastname.Location = new System.Drawing.Point(533, 179);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(310, 41);
            this.txtLastname.TabIndex = 4;
            this.txtLastname.Text = "Last name";
            this.txtLastname.TextChanged += new System.EventHandler(this.txtLastname_TextChanged);
            this.txtLastname.Enter += new System.EventHandler(this.txtLastname_Enter);
            this.txtLastname.Leave += new System.EventHandler(this.txtLastname_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmail.Location = new System.Drawing.Point(161, 249);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(682, 41);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "Email Address";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsername.Location = new System.Drawing.Point(161, 320);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(682, 41);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.Location = new System.Drawing.Point(161, 390);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(682, 41);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateAccount.Location = new System.Drawing.Point(161, 556);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(682, 58);
            this.btnCreateAccount.TabIndex = 8;
            this.btnCreateAccount.Text = "CREATE ACCOUNT";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirm.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPasswordConfirm.Location = new System.Drawing.Point(161, 458);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(682, 41);
            this.txtPasswordConfirm.TabIndex = 10;
            this.txtPasswordConfirm.Text = "Confirm Password";
            this.txtPasswordConfirm.Enter += new System.EventHandler(this.txtPasswordConfirm_Enter);
            this.txtPasswordConfirm.Leave += new System.EventHandler(this.txtPasswordConfirm_Leave);
            // 
            // labelGoToLogIn
            // 
            this.labelGoToLogIn.AutoSize = true;
            this.labelGoToLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGoToLogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGoToLogIn.Location = new System.Drawing.Point(386, 637);
            this.labelGoToLogIn.Name = "labelGoToLogIn";
            this.labelGoToLogIn.Size = new System.Drawing.Size(218, 20);
            this.labelGoToLogIn.TabIndex = 201;
            this.labelGoToLogIn.Text = "Ya Tienes Cuenta? Click Aquí";
            this.labelGoToLogIn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelGoToLogIn_MouseClick);
            this.labelGoToLogIn.MouseEnter += new System.EventHandler(this.labelGoToLogIn_MouseEnter);
            this.labelGoToLogIn.MouseLeave += new System.EventHandler(this.labelGoToLogIn_MouseLeave);
            // 
            // labelCloseR
            // 
            this.labelCloseR.AutoSize = true;
            this.labelCloseR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloseR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCloseR.Location = new System.Drawing.Point(858, 9);
            this.labelCloseR.Name = "labelCloseR";
            this.labelCloseR.Size = new System.Drawing.Size(36, 36);
            this.labelCloseR.TabIndex = 9;
            this.labelCloseR.Text = "X";
            this.labelCloseR.Click += new System.EventHandler(this.labelCloseR_Click);
            this.labelCloseR.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.labelCloseR.MouseLeave += new System.EventHandler(this.labelCloseR_MouseLeave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(896, 691);
            this.Controls.Add(this.labelGoToLogIn);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.labelCloseR);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Label labelGoToLogIn;
        private System.Windows.Forms.Label labelCloseR;
    }
}
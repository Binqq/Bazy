namespace BazyDanych
{
    partial class Form1
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.checkBoxEmployees = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(82, 39);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(171, 22);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(82, 110);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(171, 22);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(22, 42);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(43, 17);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(7, 113);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(248, 198);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonLogIn.Size = new System.Drawing.Size(75, 30);
            this.buttonLogIn.TabIndex = 4;
            this.buttonLogIn.Text = "Log in";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // checkBoxEmployees
            // 
            this.checkBoxEmployees.AutoSize = true;
            this.checkBoxEmployees.Location = new System.Drawing.Point(25, 198);
            this.checkBoxEmployees.Name = "checkBoxEmployees";
            this.checkBoxEmployees.Size = new System.Drawing.Size(94, 21);
            this.checkBoxEmployees.TabIndex = 5;
            this.checkBoxEmployees.Text = "Pracownik";
            this.checkBoxEmployees.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(349, 253);
            this.Controls.Add(this.checkBoxEmployees);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "Form1";
            this.Text = "Bank Wróbel&Bojzan SA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.CheckBox checkBoxEmployees;
    }
}


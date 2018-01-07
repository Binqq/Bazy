namespace BazyDanych
{
    partial class Employee
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
            this.buttonCredit = new System.Windows.Forms.Button();
            this.buttonNewConto = new System.Windows.Forms.Button();
            this.buttonCloseConto = new System.Windows.Forms.Button();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCredit
            // 
            this.buttonCredit.Location = new System.Drawing.Point(53, 22);
            this.buttonCredit.Name = "buttonCredit";
            this.buttonCredit.Size = new System.Drawing.Size(123, 41);
            this.buttonCredit.TabIndex = 2;
            this.buttonCredit.Text = "Kredyt";
            this.buttonCredit.UseVisualStyleBackColor = true;
            this.buttonCredit.Click += new System.EventHandler(this.buttonCredit_Click);
            // 
            // buttonNewConto
            // 
            this.buttonNewConto.Location = new System.Drawing.Point(53, 152);
            this.buttonNewConto.Name = "buttonNewConto";
            this.buttonNewConto.Size = new System.Drawing.Size(123, 47);
            this.buttonNewConto.TabIndex = 3;
            this.buttonNewConto.Text = "Założenie konta";
            this.buttonNewConto.UseVisualStyleBackColor = true;
            this.buttonNewConto.Click += new System.EventHandler(this.buttonNewConto_Click);
            // 
            // buttonCloseConto
            // 
            this.buttonCloseConto.Location = new System.Drawing.Point(53, 86);
            this.buttonCloseConto.Name = "buttonCloseConto";
            this.buttonCloseConto.Size = new System.Drawing.Size(123, 45);
            this.buttonCloseConto.TabIndex = 4;
            this.buttonCloseConto.Text = "Zamknięcie konta";
            this.buttonCloseConto.UseVisualStyleBackColor = true;
            this.buttonCloseConto.Click += new System.EventHandler(this.buttonCloseConto_Click);
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Location = new System.Drawing.Point(53, 224);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(123, 53);
            this.buttonTransfer.TabIndex = 5;
            this.buttonTransfer.Text = "Przelewy";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(53, 304);
            this.button1.MinimumSize = new System.Drawing.Size(124, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Wpłata/Wypłata";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(122, 416);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(123, 45);
            this.buttonLogOut.TabIndex = 7;
            this.buttonLogOut.Text = "Wyloguj";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click_1);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(257, 473);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.buttonNewConto);
            this.Controls.Add(this.buttonCloseConto);
            this.Controls.Add(this.buttonCredit);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCredit;
        private System.Windows.Forms.Button buttonNewConto;
        private System.Windows.Forms.Button buttonCloseConto;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLogOut;
    }
}
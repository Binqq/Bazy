namespace BazyDanych
{
    partial class Pay_in_out
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxCash = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPesel = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.buttonPayOut = new System.Windows.Forms.Button();
            this.buttonPayIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(22, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(22, 128);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(100, 22);
            this.textBoxPesel.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(22, 70);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBoxCash
            // 
            this.textBoxCash.Location = new System.Drawing.Point(246, 23);
            this.textBoxCash.Name = "textBoxCash";
            this.textBoxCash.Size = new System.Drawing.Size(100, 22);
            this.textBoxCash.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(155, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 17);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Imię";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(155, 75);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 17);
            this.labelSurname.TabIndex = 5;
            this.labelSurname.Text = "Nazwisko";
            // 
            // labelPesel
            // 
            this.labelPesel.AutoSize = true;
            this.labelPesel.Location = new System.Drawing.Point(155, 128);
            this.labelPesel.Name = "labelPesel";
            this.labelPesel.Size = new System.Drawing.Size(52, 17);
            this.labelPesel.TabIndex = 6;
            this.labelPesel.Text = "PESEL";
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.Location = new System.Drawing.Point(371, 28);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(50, 17);
            this.labelCash.TabIndex = 7;
            this.labelCash.Text = "Kwota ";
            // 
            // buttonPayOut
            // 
            this.buttonPayOut.Location = new System.Drawing.Point(307, 137);
            this.buttonPayOut.Name = "buttonPayOut";
            this.buttonPayOut.Size = new System.Drawing.Size(96, 72);
            this.buttonPayOut.TabIndex = 8;
            this.buttonPayOut.Text = "Wypłata";
            this.buttonPayOut.UseVisualStyleBackColor = true;
            this.buttonPayOut.Click += new System.EventHandler(this.buttonPayOut_Click);
            // 
            // buttonPayIn
            // 
            this.buttonPayIn.Location = new System.Drawing.Point(307, 60);
            this.buttonPayIn.Name = "buttonPayIn";
            this.buttonPayIn.Size = new System.Drawing.Size(96, 71);
            this.buttonPayIn.TabIndex = 9;
            this.buttonPayIn.Text = "Wpłata";
            this.buttonPayIn.UseVisualStyleBackColor = true;
            this.buttonPayIn.Click += new System.EventHandler(this.buttonPayIn_Click);
            // 
            // Pay_in_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 228);
            this.Controls.Add(this.buttonPayIn);
            this.Controls.Add(this.buttonPayOut);
            this.Controls.Add(this.labelCash);
            this.Controls.Add(this.labelPesel);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxCash);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxPesel);
            this.Controls.Add(this.textBoxName);
            this.Name = "Pay_in_out";
            this.Text = "Pay_in_out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxCash;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPesel;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.Button buttonPayOut;
        private System.Windows.Forms.Button buttonPayIn;
    }
}
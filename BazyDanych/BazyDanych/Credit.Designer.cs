namespace BazyDanych
{
    partial class Credit
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelPesel = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.textBoxCash = new System.Windows.Forms.TextBox();
            this.labelCash = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGrantALoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(379, 215);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 28);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Wróć";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(151, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Imie klienta";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(151, 71);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(112, 17);
            this.labelSurname.TabIndex = 4;
            this.labelSurname.Text = "Nazwisko klienta";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // labelPesel
            // 
            this.labelPesel.AutoSize = true;
            this.labelPesel.Location = new System.Drawing.Point(151, 108);
            this.labelPesel.Name = "labelPesel";
            this.labelPesel.Size = new System.Drawing.Size(52, 17);
            this.labelPesel.TabIndex = 6;
            this.labelPesel.Text = "PESEL";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(12, 204);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 22);
            this.textBoxDuration.TabIndex = 7;
            // 
            // textBoxCash
            // 
            this.textBoxCash.Location = new System.Drawing.Point(12, 161);
            this.textBoxCash.Name = "textBoxCash";
            this.textBoxCash.Size = new System.Drawing.Size(100, 22);
            this.textBoxCash.TabIndex = 8;
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.Location = new System.Drawing.Point(151, 164);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(97, 17);
            this.labelCash.TabIndex = 9;
            this.labelCash.Text = "Kwota kredytu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Czas trwania w miesiącach";
            // 
            // buttonGrantALoan
            // 
            this.buttonGrantALoan.Location = new System.Drawing.Point(379, 32);
            this.buttonGrantALoan.Name = "buttonGrantALoan";
            this.buttonGrantALoan.Size = new System.Drawing.Size(115, 105);
            this.buttonGrantALoan.TabIndex = 11;
            this.buttonGrantALoan.Text = "Udziel kredytu";
            this.buttonGrantALoan.UseVisualStyleBackColor = true;
            // 
            // Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 262);
            this.Controls.Add(this.buttonGrantALoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCash);
            this.Controls.Add(this.textBoxCash);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.labelPesel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonBack);
            this.Name = "Credit";
            this.Text = "Credit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelPesel;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.TextBox textBoxCash;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGrantALoan;
    }
}
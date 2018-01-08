namespace BazyDanych
{
    partial class ClientTransfer
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.Pesel = new System.Windows.Forms.TextBox();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.textBoxCash = new System.Windows.Forms.TextBox();
            this.labelCash = new System.Windows.Forms.Label();
            this.textBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.labelAccountNumber = new System.Windows.Forms.Label();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(136, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(190, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 17);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Imię";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(12, 88);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(136, 22);
            this.textBoxSurname.TabIndex = 9;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(190, 93);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 17);
            this.labelSurname.TabIndex = 10;
            this.labelSurname.Text = "Nazwisko";
            // 
            // Pesel
            // 
            this.Pesel.Location = new System.Drawing.Point(12, 156);
            this.Pesel.Name = "Pesel";
            this.Pesel.Size = new System.Drawing.Size(136, 22);
            this.Pesel.TabIndex = 11;
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(190, 159);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(43, 17);
            this.labelPESEL.TabIndex = 12;
            this.labelPESEL.Text = "Pesel";
            // 
            // textBoxCash
            // 
            this.textBoxCash.Location = new System.Drawing.Point(342, 29);
            this.textBoxCash.Name = "textBoxCash";
            this.textBoxCash.Size = new System.Drawing.Size(136, 22);
            this.textBoxCash.TabIndex = 13;
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.Location = new System.Drawing.Point(500, 31);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(106, 17);
            this.labelCash.TabIndex = 14;
            this.labelCash.Text = "Kwota przelewu";
            // 
            // textBoxAccountNumber
            // 
            this.textBoxAccountNumber.Location = new System.Drawing.Point(342, 88);
            this.textBoxAccountNumber.Name = "textBoxAccountNumber";
            this.textBoxAccountNumber.Size = new System.Drawing.Size(136, 22);
            this.textBoxAccountNumber.TabIndex = 15;
            // 
            // labelAccountNumber
            // 
            this.labelAccountNumber.AutoSize = true;
            this.labelAccountNumber.Location = new System.Drawing.Point(500, 91);
            this.labelAccountNumber.Name = "labelAccountNumber";
            this.labelAccountNumber.Size = new System.Drawing.Size(68, 17);
            this.labelAccountNumber.TabIndex = 16;
            this.labelAccountNumber.Text = "Nr. Konta";
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Location = new System.Drawing.Point(468, 240);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(100, 58);
            this.buttonTransfer.TabIndex = 17;
            this.buttonTransfer.Text = "wykonaj przelew";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 273);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 25);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "Cofinij";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ClientTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 310);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.labelAccountNumber);
            this.Controls.Add(this.textBoxAccountNumber);
            this.Controls.Add(this.labelCash);
            this.Controls.Add(this.textBoxCash);
            this.Controls.Add(this.labelPESEL);
            this.Controls.Add(this.Pesel);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "ClientTransfer";
            this.Text = "ClientTransfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox Pesel;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.TextBox textBoxCash;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.TextBox textBoxAccountNumber;
        private System.Windows.Forms.Label labelAccountNumber;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Button buttonBack;
    }
}
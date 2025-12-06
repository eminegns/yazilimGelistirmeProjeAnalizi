namespace ypgProjesi
{
    partial class SatirSayisiHesaplama
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
            this.bttnSShesaplama = new System.Windows.Forms.Button();
            this.lblSS = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPlatform = new System.Windows.Forms.ComboBox();
            this.bttnCocomoGec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnSShesaplama
            // 
            this.bttnSShesaplama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(137)))), ((int)(((byte)(70)))));
            this.bttnSShesaplama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSShesaplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnSShesaplama.Location = new System.Drawing.Point(552, 446);
            this.bttnSShesaplama.Name = "bttnSShesaplama";
            this.bttnSShesaplama.Size = new System.Drawing.Size(155, 76);
            this.bttnSShesaplama.TabIndex = 34;
            this.bttnSShesaplama.Text = "SS Hesaplama";
            this.bttnSShesaplama.UseVisualStyleBackColor = false;
            this.bttnSShesaplama.Click += new System.EventHandler(this.bttnSShesaplama_Click);
            // 
            // lblSS
            // 
            this.lblSS.AutoSize = true;
            this.lblSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSS.Location = new System.Drawing.Point(328, 277);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(69, 25);
            this.lblSS.TabIndex = 33;
            this.lblSS.Text = "Sonuç";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(165, 277);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 25);
            this.label18.TabIndex = 32;
            this.label18.Text = "Satır Sayısı =";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(12, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(330, 32);
            this.label16.TabIndex = 31;
            this.label16.Text = "Satır Sayısı Hesaplama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Programlama Platformu Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(83, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Programlama Platformu";
            // 
            // cmbPlatform
            // 
            this.cmbPlatform.FormattingEnabled = true;
            this.cmbPlatform.Items.AddRange(new object[] {
            "Assembly",
            "COBOL",
            "Fortran",
            "Pascal",
            "C ",
            "Ada",
            "Nesne Kökenli Diller",
            "4.kuşak Diller",
            "Kod Üreticiler"});
            this.cmbPlatform.Location = new System.Drawing.Point(333, 194);
            this.cmbPlatform.Name = "cmbPlatform";
            this.cmbPlatform.Size = new System.Drawing.Size(256, 24);
            this.cmbPlatform.TabIndex = 37;
            // 
            // bttnCocomoGec
            // 
            this.bttnCocomoGec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(137)))), ((int)(((byte)(70)))));
            this.bttnCocomoGec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCocomoGec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnCocomoGec.Location = new System.Drawing.Point(1098, 542);
            this.bttnCocomoGec.Name = "bttnCocomoGec";
            this.bttnCocomoGec.Size = new System.Drawing.Size(126, 40);
            this.bttnCocomoGec.TabIndex = 113;
            this.bttnCocomoGec.Text = "Next";
            this.bttnCocomoGec.UseVisualStyleBackColor = false;
            this.bttnCocomoGec.Click += new System.EventHandler(this.bttnCocomoGec_Click);
            // 
            // SatirSayisiHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1236, 594);
            this.Controls.Add(this.bttnCocomoGec);
            this.Controls.Add(this.cmbPlatform);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnSShesaplama);
            this.Controls.Add(this.lblSS);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Name = "SatirSayisiHesaplama";
            this.Text = "SatirSayisiHesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnSShesaplama;
        private System.Windows.Forms.Label lblSS;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPlatform;
        private System.Windows.Forms.Button bttnCocomoGec;
    }
}
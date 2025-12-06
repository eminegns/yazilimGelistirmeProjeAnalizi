using System;
using System.Windows.Forms;

namespace projehilal
{
    partial class cocomoModel
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
            this.CR1 = new System.Windows.Forms.RadioButton();
            this.CR2 = new System.Windows.Forms.RadioButton();
            this.CR4 = new System.Windows.Forms.RadioButton();
            this.CR5 = new System.Windows.Forms.RadioButton();
            this.CR6 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CGB1 = new System.Windows.Forms.GroupBox();
            this.CGB2 = new System.Windows.Forms.GroupBox();
            this.CButton2 = new System.Windows.Forms.Button();
            this.bttnMaliyetGec = new System.Windows.Forms.Button();
            this.lblGucHesap = new System.Windows.Forms.Label();
            this.lblZamanHesap = new System.Windows.Forms.Label();
            this.bttnZaman = new System.Windows.Forms.Button();
            this.CGB1.SuspendLayout();
            this.CGB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CR1
            // 
            this.CR1.AutoSize = true;
            this.CR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CR1.Location = new System.Drawing.Point(37, 68);
            this.CR1.Margin = new System.Windows.Forms.Padding(4);
            this.CR1.Name = "CR1";
            this.CR1.Size = new System.Drawing.Size(147, 29);
            this.CR1.TabIndex = 0;
            this.CR1.TabStop = true;
            this.CR1.Text = "Temel Model";
            this.CR1.UseVisualStyleBackColor = true;
            // 
            // CR2
            // 
            this.CR2.AutoSize = true;
            this.CR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CR2.Location = new System.Drawing.Point(37, 125);
            this.CR2.Margin = new System.Windows.Forms.Padding(4);
            this.CR2.Name = "CR2";
            this.CR2.Size = new System.Drawing.Size(123, 29);
            this.CR2.TabIndex = 1;
            this.CR2.TabStop = true;
            this.CR2.Text = "Ara Model";
            this.CR2.UseVisualStyleBackColor = true;
            // 
            // CR4
            // 
            this.CR4.AutoSize = true;
            this.CR4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CR4.Location = new System.Drawing.Point(29, 44);
            this.CR4.Margin = new System.Windows.Forms.Padding(4);
            this.CR4.Name = "CR4";
            this.CR4.Size = new System.Drawing.Size(82, 29);
            this.CR4.TabIndex = 2;
            this.CR4.TabStop = true;
            this.CR4.Text = "Ayrık ";
            this.CR4.UseVisualStyleBackColor = true;
            // 
            // CR5
            // 
            this.CR5.AutoSize = true;
            this.CR5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CR5.Location = new System.Drawing.Point(29, 100);
            this.CR5.Margin = new System.Windows.Forms.Padding(4);
            this.CR5.Name = "CR5";
            this.CR5.Size = new System.Drawing.Size(140, 29);
            this.CR5.TabIndex = 4;
            this.CR5.TabStop = true;
            this.CR5.Text = "Yarı Gömülü";
            this.CR5.UseVisualStyleBackColor = true;
            // 
            // CR6
            // 
            this.CR6.AutoSize = true;
            this.CR6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CR6.Location = new System.Drawing.Point(29, 153);
            this.CR6.Margin = new System.Windows.Forms.Padding(4);
            this.CR6.Name = "CR6";
            this.CR6.Size = new System.Drawing.Size(101, 29);
            this.CR6.TabIndex = 6;
            this.CR6.TabStop = true;
            this.CR6.Text = "Gömülü";
            this.CR6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(385, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "COCOMO MODEL SEÇİMİ";
            // 
            // CGB1
            // 
            this.CGB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(169)))), ((int)(((byte)(106)))));
            this.CGB1.Controls.Add(this.CR2);
            this.CGB1.Controls.Add(this.CR1);
            this.CGB1.Location = new System.Drawing.Point(342, 152);
            this.CGB1.Margin = new System.Windows.Forms.Padding(4);
            this.CGB1.Name = "CGB1";
            this.CGB1.Padding = new System.Windows.Forms.Padding(4);
            this.CGB1.Size = new System.Drawing.Size(232, 217);
            this.CGB1.TabIndex = 8;
            this.CGB1.TabStop = false;
            this.CGB1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CGB2
            // 
            this.CGB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(169)))), ((int)(((byte)(106)))));
            this.CGB2.Controls.Add(this.CR6);
            this.CGB2.Controls.Add(this.CR5);
            this.CGB2.Controls.Add(this.CR4);
            this.CGB2.Location = new System.Drawing.Point(655, 152);
            this.CGB2.Margin = new System.Windows.Forms.Padding(4);
            this.CGB2.Name = "CGB2";
            this.CGB2.Padding = new System.Windows.Forms.Padding(4);
            this.CGB2.Size = new System.Drawing.Size(232, 217);
            this.CGB2.TabIndex = 9;
            this.CGB2.TabStop = false;
            // 
            // CButton2
            // 
            this.CButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(137)))), ((int)(((byte)(70)))));
            this.CButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.CButton2.Location = new System.Drawing.Point(655, 413);
            this.CButton2.Margin = new System.Windows.Forms.Padding(4);
            this.CButton2.Name = "CButton2";
            this.CButton2.Size = new System.Drawing.Size(310, 94);
            this.CButton2.TabIndex = 11;
            this.CButton2.Text = "İŞ GÜCÜ HESAPLA";
            this.CButton2.UseVisualStyleBackColor = false;
            this.CButton2.Click += new System.EventHandler(this.CButton2_Click_1);
            // 
            // bttnMaliyetGec
            // 
            this.bttnMaliyetGec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(137)))), ((int)(((byte)(70)))));
            this.bttnMaliyetGec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMaliyetGec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnMaliyetGec.Location = new System.Drawing.Point(1098, 542);
            this.bttnMaliyetGec.Name = "bttnMaliyetGec";
            this.bttnMaliyetGec.Size = new System.Drawing.Size(126, 40);
            this.bttnMaliyetGec.TabIndex = 114;
            this.bttnMaliyetGec.Text = "Next";
            this.bttnMaliyetGec.UseVisualStyleBackColor = false;
            this.bttnMaliyetGec.Click += new System.EventHandler(this.bttnMaliyetGec_Click);
            // 
            // lblGucHesap
            // 
            this.lblGucHesap.AutoSize = true;
            this.lblGucHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblGucHesap.Location = new System.Drawing.Point(972, 440);
            this.lblGucHesap.Name = "lblGucHesap";
            this.lblGucHesap.Size = new System.Drawing.Size(90, 32);
            this.lblGucHesap.TabIndex = 115;
            this.lblGucHesap.Text = "sonuç";
            // 
            // lblZamanHesap
            // 
            this.lblZamanHesap.AutoSize = true;
            this.lblZamanHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblZamanHesap.Location = new System.Drawing.Point(12, 440);
            this.lblZamanHesap.Name = "lblZamanHesap";
            this.lblZamanHesap.Size = new System.Drawing.Size(90, 32);
            this.lblZamanHesap.TabIndex = 116;
            this.lblZamanHesap.Text = "sonuç";
            // 
            // bttnZaman
            // 
            this.bttnZaman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(137)))), ((int)(((byte)(70)))));
            this.bttnZaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.bttnZaman.Location = new System.Drawing.Point(264, 413);
            this.bttnZaman.Margin = new System.Windows.Forms.Padding(4);
            this.bttnZaman.Name = "bttnZaman";
            this.bttnZaman.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bttnZaman.Size = new System.Drawing.Size(310, 94);
            this.bttnZaman.TabIndex = 118;
            this.bttnZaman.Text = "ZAMAN HESAPLA";
            this.bttnZaman.UseVisualStyleBackColor = false;
            this.bttnZaman.Click += new System.EventHandler(this.bttnZaman_Click);
            // 
            // cocomoModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1236, 594);
            this.Controls.Add(this.bttnZaman);
            this.Controls.Add(this.lblZamanHesap);
            this.Controls.Add(this.lblGucHesap);
            this.Controls.Add(this.bttnMaliyetGec);
            this.Controls.Add(this.CButton2);
            this.Controls.Add(this.CGB2);
            this.Controls.Add(this.CGB1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cocomoModel";
            this.Text = "Form1";
            this.CGB1.ResumeLayout(false);
            this.CGB1.PerformLayout();
            this.CGB2.ResumeLayout(false);
            this.CGB2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void CButton1_Click(object sender, EventArgs e)
        {
            double T = 0;
            double K = 0;

            // GroupBox1 Temel Model Seçim (Zaman)
            //Temel - Ayrık
            if (CR1.Checked && CR4.Checked)
            {
                T = 2.5 * (Math.Pow(K, 0.38));
                MessageBox.Show("Zaman: " + T.ToString());
            }
            //Temel - Yarı Gömülü
            else if (CR1.Checked && CR5.Checked)
            {
                T = 2.5 * (Math.Pow(K, 0.35));
                MessageBox.Show("Zaman: " + T.ToString());
            }
            //Temel - Gömülü
            else if (CR1.Checked && CR6.Checked)
            {
                T = 2.5 * (Math.Pow(K, 0.32));
                MessageBox.Show("Zaman: " + T.ToString());
            }
            else
            {
                MessageBox.Show("Geçersiz Seçim");
            }
        }



        #endregion

        public System.Windows.Forms.RadioButton CR1;
        public System.Windows.Forms.RadioButton CR2;
        public System.Windows.Forms.RadioButton CR4;
        public System.Windows.Forms.RadioButton CR5;
        public System.Windows.Forms.RadioButton CR6;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox CGB1;
        public System.Windows.Forms.GroupBox CGB2;
        public Button CButton2;
        private Button bttnMaliyetGec;
        private Label lblGucHesap;
        private Label lblZamanHesap;
        public Button bttnZaman;
    }
}


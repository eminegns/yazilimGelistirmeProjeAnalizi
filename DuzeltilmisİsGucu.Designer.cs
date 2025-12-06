namespace hesaplama
{
    partial class DuzeltilmisİsGucu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCevir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bttnDuzeltilmisGuc = new System.Windows.Forms.Button();
            this.lblMaliyetSonuc = new System.Windows.Forms.Label();
            this.bttnOrtalamaPersonel = new System.Windows.Forms.Button();
            this.lblOrtPersonel = new System.Windows.Forms.Label();
            this.lblHaftaCevir = new System.Windows.Forms.Label();
            this.KullaniciGec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Düzeltilmiş İŞ Gücü Hesaplama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hafta Ay Dönüşümleri ";
            // 
            // btnCevir
            // 
            this.btnCevir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(137)))), ((int)(((byte)(70)))));
            this.btnCevir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCevir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCevir.Location = new System.Drawing.Point(612, 460);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(169, 53);
            this.btnCevir.TabIndex = 11;
            this.btnCevir.Text = "Adam.haftaya çevir";
            this.btnCevir.UseVisualStyleBackColor = false;
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(49, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ortalama Personel Sayısı";
            // 
            // bttnDuzeltilmisGuc
            // 
            this.bttnDuzeltilmisGuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(137)))), ((int)(((byte)(70)))));
            this.bttnDuzeltilmisGuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDuzeltilmisGuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.bttnDuzeltilmisGuc.Location = new System.Drawing.Point(612, 104);
            this.bttnDuzeltilmisGuc.Name = "bttnDuzeltilmisGuc";
            this.bttnDuzeltilmisGuc.Size = new System.Drawing.Size(169, 53);
            this.bttnDuzeltilmisGuc.TabIndex = 110;
            this.bttnDuzeltilmisGuc.Text = "Düzeltilmiş İş Gücünü Hesapla";
            this.bttnDuzeltilmisGuc.UseVisualStyleBackColor = false;
            this.bttnDuzeltilmisGuc.Click += new System.EventHandler(this.bttnDuzeltilmisGuc_Click);
            // 
            // lblMaliyetSonuc
            // 
            this.lblMaliyetSonuc.AutoSize = true;
            this.lblMaliyetSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaliyetSonuc.Location = new System.Drawing.Point(62, 110);
            this.lblMaliyetSonuc.Name = "lblMaliyetSonuc";
            this.lblMaliyetSonuc.Size = new System.Drawing.Size(90, 32);
            this.lblMaliyetSonuc.TabIndex = 111;
            this.lblMaliyetSonuc.Text = "sonuç";
            // 
            // bttnOrtalamaPersonel
            // 
            this.bttnOrtalamaPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(137)))), ((int)(((byte)(70)))));
            this.bttnOrtalamaPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnOrtalamaPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.bttnOrtalamaPersonel.Location = new System.Drawing.Point(612, 273);
            this.bttnOrtalamaPersonel.Name = "bttnOrtalamaPersonel";
            this.bttnOrtalamaPersonel.Size = new System.Drawing.Size(169, 53);
            this.bttnOrtalamaPersonel.TabIndex = 112;
            this.bttnOrtalamaPersonel.Text = "Ortalama Personel hesapla";
            this.bttnOrtalamaPersonel.UseVisualStyleBackColor = false;
            this.bttnOrtalamaPersonel.Click += new System.EventHandler(this.bttnOrtalamaPersonel_Click);
            // 
            // lblOrtPersonel
            // 
            this.lblOrtPersonel.AutoSize = true;
            this.lblOrtPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtPersonel.Location = new System.Drawing.Point(62, 279);
            this.lblOrtPersonel.Name = "lblOrtPersonel";
            this.lblOrtPersonel.Size = new System.Drawing.Size(90, 32);
            this.lblOrtPersonel.TabIndex = 113;
            this.lblOrtPersonel.Text = "sonuç";
            // 
            // lblHaftaCevir
            // 
            this.lblHaftaCevir.AutoSize = true;
            this.lblHaftaCevir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHaftaCevir.Location = new System.Drawing.Point(62, 460);
            this.lblHaftaCevir.Name = "lblHaftaCevir";
            this.lblHaftaCevir.Size = new System.Drawing.Size(90, 32);
            this.lblHaftaCevir.TabIndex = 114;
            this.lblHaftaCevir.Text = "sonuç";
            // 
            // KullaniciGec
            // 
            this.KullaniciGec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(137)))), ((int)(((byte)(70)))));
            this.KullaniciGec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KullaniciGec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciGec.Location = new System.Drawing.Point(1048, 542);
            this.KullaniciGec.Name = "KullaniciGec";
            this.KullaniciGec.Size = new System.Drawing.Size(126, 40);
            this.KullaniciGec.TabIndex = 115;
            this.KullaniciGec.Text = "Next";
            this.KullaniciGec.UseVisualStyleBackColor = false;
            this.KullaniciGec.Click += new System.EventHandler(this.KullaniciGec_Click);
            // 
            // DuzeltilmisİsGucu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1236, 594);
            this.Controls.Add(this.KullaniciGec);
            this.Controls.Add(this.lblHaftaCevir);
            this.Controls.Add(this.lblOrtPersonel);
            this.Controls.Add(this.bttnOrtalamaPersonel);
            this.Controls.Add(this.lblMaliyetSonuc);
            this.Controls.Add(this.bttnDuzeltilmisGuc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCevir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DuzeltilmisİsGucu";
            this.Text = "DuzeltilmisİsGucu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCevir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttnDuzeltilmisGuc;
        private System.Windows.Forms.Label lblMaliyetSonuc;
        private System.Windows.Forms.Button bttnOrtalamaPersonel;
        private System.Windows.Forms.Label lblOrtPersonel;
        private System.Windows.Forms.Label lblHaftaCevir;
        private System.Windows.Forms.Button KullaniciGec;
    }
}



namespace OptikOtomasyonu
{
    partial class FrmFiyatGuncelle
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
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.LblYeniFiyat = new OptikOtomasyonu.lblstandart();
            this.TxtYeniFiyat = new OptikOtomasyonu.Txtnumeric();
            this.lblstandart1 = new OptikOtomasyonu.lblstandart();
            this.TxtBarkod = new OptikOtomasyonu.TxtStandart();
            this.LblFiyat = new OptikOtomasyonu.lblstandart();
            this.LblUrunAdi = new OptikOtomasyonu.lblstandart();
            this.LblBarkod = new OptikOtomasyonu.lblstandart();
            this.lblstandart4 = new OptikOtomasyonu.lblstandart();
            this.lblstandart3 = new OptikOtomasyonu.lblstandart();
            this.lblstandart2 = new OptikOtomasyonu.lblstandart();
            this.SuspendLayout();
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.Sienna;
            this.BtnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.BtnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(161, 303);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(94, 40);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // LblYeniFiyat
            // 
            this.LblYeniFiyat.AutoSize = true;
            this.LblYeniFiyat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LblYeniFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblYeniFiyat.ForeColor = System.Drawing.Color.Black;
            this.LblYeniFiyat.Location = new System.Drawing.Point(31, 285);
            this.LblYeniFiyat.Name = "LblYeniFiyat";
            this.LblYeniFiyat.Size = new System.Drawing.Size(98, 25);
            this.LblYeniFiyat.TabIndex = 23;
            this.LblYeniFiyat.Text = "Yeni Fiyat";
            // 
            // TxtYeniFiyat
            // 
            this.TxtYeniFiyat.BackColor = System.Drawing.Color.White;
            this.TxtYeniFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtYeniFiyat.Location = new System.Drawing.Point(31, 313);
            this.TxtYeniFiyat.Name = "TxtYeniFiyat";
            this.TxtYeniFiyat.Size = new System.Drawing.Size(115, 30);
            this.TxtYeniFiyat.TabIndex = 1;
            this.TxtYeniFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblstandart1
            // 
            this.lblstandart1.AutoSize = true;
            this.lblstandart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblstandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart1.ForeColor = System.Drawing.Color.Black;
            this.lblstandart1.Location = new System.Drawing.Point(26, 36);
            this.lblstandart1.Name = "lblstandart1";
            this.lblstandart1.Size = new System.Drawing.Size(164, 25);
            this.lblstandart1.TabIndex = 21;
            this.lblstandart1.Text = "Barkod Okutunuz";
            // 
            // TxtBarkod
            // 
            this.TxtBarkod.BackColor = System.Drawing.Color.White;
            this.TxtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBarkod.Location = new System.Drawing.Point(27, 64);
            this.TxtBarkod.Name = "TxtBarkod";
            this.TxtBarkod.Size = new System.Drawing.Size(317, 30);
            this.TxtBarkod.TabIndex = 0;
            this.TxtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBarkod_KeyDown);
            // 
            // LblFiyat
            // 
            this.LblFiyat.AutoSize = true;
            this.LblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblFiyat.ForeColor = System.Drawing.Color.Sienna;
            this.LblFiyat.Location = new System.Drawing.Point(122, 205);
            this.LblFiyat.Name = "LblFiyat";
            this.LblFiyat.Size = new System.Drawing.Size(112, 25);
            this.LblFiyat.TabIndex = 19;
            this.LblFiyat.Text = "LblStandart";
            // 
            // LblUrunAdi
            // 
            this.LblUrunAdi.AutoSize = true;
            this.LblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblUrunAdi.ForeColor = System.Drawing.Color.Sienna;
            this.LblUrunAdi.Location = new System.Drawing.Point(122, 171);
            this.LblUrunAdi.Name = "LblUrunAdi";
            this.LblUrunAdi.Size = new System.Drawing.Size(112, 25);
            this.LblUrunAdi.TabIndex = 18;
            this.LblUrunAdi.Text = "LblStandart";
            // 
            // LblBarkod
            // 
            this.LblBarkod.AutoSize = true;
            this.LblBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblBarkod.ForeColor = System.Drawing.Color.Sienna;
            this.LblBarkod.Location = new System.Drawing.Point(122, 137);
            this.LblBarkod.Name = "LblBarkod";
            this.LblBarkod.Size = new System.Drawing.Size(112, 25);
            this.LblBarkod.TabIndex = 17;
            this.LblBarkod.Text = "LblStandart";
            // 
            // lblstandart4
            // 
            this.lblstandart4.AutoSize = true;
            this.lblstandart4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblstandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart4.ForeColor = System.Drawing.Color.Sienna;
            this.lblstandart4.Location = new System.Drawing.Point(62, 205);
            this.lblstandart4.Name = "lblstandart4";
            this.lblstandart4.Size = new System.Drawing.Size(54, 25);
            this.lblstandart4.TabIndex = 16;
            this.lblstandart4.Text = "Fiyat";
            // 
            // lblstandart3
            // 
            this.lblstandart3.AutoSize = true;
            this.lblstandart3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblstandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart3.ForeColor = System.Drawing.Color.Sienna;
            this.lblstandart3.Location = new System.Drawing.Point(28, 171);
            this.lblstandart3.Name = "lblstandart3";
            this.lblstandart3.Size = new System.Drawing.Size(88, 25);
            this.lblstandart3.TabIndex = 15;
            this.lblstandart3.Text = "Ürün Adı";
            // 
            // lblstandart2
            // 
            this.lblstandart2.AutoSize = true;
            this.lblstandart2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblstandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart2.ForeColor = System.Drawing.Color.Sienna;
            this.lblstandart2.Location = new System.Drawing.Point(42, 137);
            this.lblstandart2.Name = "lblstandart2";
            this.lblstandart2.Size = new System.Drawing.Size(74, 25);
            this.lblstandart2.TabIndex = 14;
            this.lblstandart2.Text = "Barkod";
            // 
            // FrmFiyatGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 376);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.LblYeniFiyat);
            this.Controls.Add(this.TxtYeniFiyat);
            this.Controls.Add(this.lblstandart1);
            this.Controls.Add(this.TxtBarkod);
            this.Controls.Add(this.LblFiyat);
            this.Controls.Add(this.LblUrunAdi);
            this.Controls.Add(this.LblBarkod);
            this.Controls.Add(this.lblstandart4);
            this.Controls.Add(this.lblstandart3);
            this.Controls.Add(this.lblstandart2);
            this.MaximumSize = new System.Drawing.Size(379, 423);
            this.MinimumSize = new System.Drawing.Size(379, 423);
            this.Name = "FrmFiyatGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN FİYAT GÜNCELLE";
            this.Load += new System.EventHandler(this.FrmFiyatGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lblstandart LblFiyat;
        private lblstandart LblUrunAdi;
        private lblstandart LblBarkod;
        private lblstandart lblstandart4;
        private lblstandart lblstandart3;
        private lblstandart lblstandart2;
        private lblstandart lblstandart1;
        private TxtStandart TxtBarkod;
        private System.Windows.Forms.Button BtnKaydet;
        private lblstandart LblYeniFiyat;
        private Txtnumeric TxtYeniFiyat;
    }
}
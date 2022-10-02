
namespace OptikOtomasyonu
{
    partial class FrmGelirGider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirGider));
            this.lblgelirgider = new OptikOtomasyonu.lblstandart();
            this.lblstandart2 = new OptikOtomasyonu.lblstandart();
            this.CmbOdemeturu = new System.Windows.Forms.ComboBox();
            this.txtnakit = new OptikOtomasyonu.Txtnumeric();
            this.txtkart = new OptikOtomasyonu.Txtnumeric();
            this.lblstandart3 = new OptikOtomasyonu.lblstandart();
            this.lblstandart4 = new OptikOtomasyonu.lblstandart();
            this.lblstandart5 = new OptikOtomasyonu.lblstandart();
            this.txtaciklama = new OptikOtomasyonu.TxtStandart();
            this.lblstandart6 = new OptikOtomasyonu.lblstandart();
            this.datetarih = new System.Windows.Forms.DateTimePicker();
            this.btnekle = new OptikOtomasyonu.Btnstandart();
            this.SuspendLayout();
            // 
            // lblgelirgider
            // 
            this.lblgelirgider.AutoSize = true;
            this.lblgelirgider.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblgelirgider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblgelirgider.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblgelirgider.Location = new System.Drawing.Point(13, 13);
            this.lblgelirgider.Name = "lblgelirgider";
            this.lblgelirgider.Size = new System.Drawing.Size(125, 25);
            this.lblgelirgider.TabIndex = 0;
            this.lblgelirgider.Text = "LblGelirGider";
            // 
            // lblstandart2
            // 
            this.lblstandart2.AutoSize = true;
            this.lblstandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblstandart2.Location = new System.Drawing.Point(13, 58);
            this.lblstandart2.Name = "lblstandart2";
            this.lblstandart2.Size = new System.Drawing.Size(123, 25);
            this.lblstandart2.TabIndex = 1;
            this.lblstandart2.Text = "Ödeme Türü";
            // 
            // CmbOdemeturu
            // 
            this.CmbOdemeturu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOdemeturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOdemeturu.FormattingEnabled = true;
            this.CmbOdemeturu.Items.AddRange(new object[] {
            "NAKİT",
            "KART",
            "KART-NAKİT"});
            this.CmbOdemeturu.Location = new System.Drawing.Point(13, 86);
            this.CmbOdemeturu.Name = "CmbOdemeturu";
            this.CmbOdemeturu.Size = new System.Drawing.Size(290, 33);
            this.CmbOdemeturu.TabIndex = 4;
            this.CmbOdemeturu.SelectedIndexChanged += new System.EventHandler(this.CmbOdemeturu_SelectedIndexChanged);
            // 
            // txtnakit
            // 
            this.txtnakit.BackColor = System.Drawing.Color.White;
            this.txtnakit.Enabled = false;
            this.txtnakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnakit.Location = new System.Drawing.Point(13, 180);
            this.txtnakit.Name = "txtnakit";
            this.txtnakit.Size = new System.Drawing.Size(134, 30);
            this.txtnakit.TabIndex = 5;
            this.txtnakit.Text = "0";
            this.txtnakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtkart
            // 
            this.txtkart.BackColor = System.Drawing.Color.White;
            this.txtkart.Enabled = false;
            this.txtkart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtkart.Location = new System.Drawing.Point(169, 180);
            this.txtkart.Name = "txtkart";
            this.txtkart.Size = new System.Drawing.Size(134, 30);
            this.txtkart.TabIndex = 5;
            this.txtkart.Text = "0";
            this.txtkart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblstandart3
            // 
            this.lblstandart3.AutoSize = true;
            this.lblstandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart3.ForeColor = System.Drawing.Color.DarkRed;
            this.lblstandart3.Location = new System.Drawing.Point(8, 149);
            this.lblstandart3.Name = "lblstandart3";
            this.lblstandart3.Size = new System.Drawing.Size(56, 25);
            this.lblstandart3.TabIndex = 6;
            this.lblstandart3.Text = "Nakit";
            // 
            // lblstandart4
            // 
            this.lblstandart4.AutoSize = true;
            this.lblstandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart4.ForeColor = System.Drawing.Color.DarkRed;
            this.lblstandart4.Location = new System.Drawing.Point(164, 149);
            this.lblstandart4.Name = "lblstandart4";
            this.lblstandart4.Size = new System.Drawing.Size(48, 25);
            this.lblstandart4.TabIndex = 6;
            this.lblstandart4.Text = "Kart";
            // 
            // lblstandart5
            // 
            this.lblstandart5.AutoSize = true;
            this.lblstandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart5.ForeColor = System.Drawing.Color.DarkRed;
            this.lblstandart5.Location = new System.Drawing.Point(18, 241);
            this.lblstandart5.Name = "lblstandart5";
            this.lblstandart5.Size = new System.Drawing.Size(92, 25);
            this.lblstandart5.TabIndex = 7;
            this.lblstandart5.Text = "Açıklama";
            // 
            // txtaciklama
            // 
            this.txtaciklama.BackColor = System.Drawing.Color.White;
            this.txtaciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtaciklama.Location = new System.Drawing.Point(18, 269);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(285, 110);
            this.txtaciklama.TabIndex = 8;
            // 
            // lblstandart6
            // 
            this.lblstandart6.AutoSize = true;
            this.lblstandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart6.ForeColor = System.Drawing.Color.DarkRed;
            this.lblstandart6.Location = new System.Drawing.Point(18, 399);
            this.lblstandart6.Name = "lblstandart6";
            this.lblstandart6.Size = new System.Drawing.Size(57, 25);
            this.lblstandart6.TabIndex = 9;
            this.lblstandart6.Text = "Tarih";
            // 
            // datetarih
            // 
            this.datetarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datetarih.Location = new System.Drawing.Point(23, 427);
            this.datetarih.Name = "datetarih";
            this.datetarih.Size = new System.Drawing.Size(280, 30);
            this.datetarih.TabIndex = 10;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.DarkRed;
            this.btnekle.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.White;
            this.btnekle.Image = ((System.Drawing.Image)(resources.GetObject("btnekle.Image")));
            this.btnekle.Location = new System.Drawing.Point(178, 461);
            this.btnekle.Margin = new System.Windows.Forms.Padding(1);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(125, 72);
            this.btnekle.TabIndex = 11;
            this.btnekle.Text = "  EKLE";
            this.btnekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // FrmGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 543);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.datetarih);
            this.Controls.Add(this.lblstandart6);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.lblstandart5);
            this.Controls.Add(this.lblstandart4);
            this.Controls.Add(this.lblstandart3);
            this.Controls.Add(this.txtkart);
            this.Controls.Add(this.txtnakit);
            this.Controls.Add(this.CmbOdemeturu);
            this.Controls.Add(this.lblstandart2);
            this.Controls.Add(this.lblgelirgider);
            this.MaximumSize = new System.Drawing.Size(352, 590);
            this.MinimumSize = new System.Drawing.Size(352, 590);
            this.Name = "FrmGelirGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GELİR GİDER İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmGelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lblstandart lblgelirgider;
        private lblstandart lblstandart2;
        private System.Windows.Forms.ComboBox CmbOdemeturu;
        private Txtnumeric txtnakit;
        private Txtnumeric txtkart;
        private lblstandart lblstandart3;
        private lblstandart lblstandart4;
        private lblstandart lblstandart5;
        private TxtStandart txtaciklama;
        private lblstandart lblstandart6;
        private System.Windows.Forms.DateTimePicker datetarih;
        private Btnstandart btnekle;
    }
}
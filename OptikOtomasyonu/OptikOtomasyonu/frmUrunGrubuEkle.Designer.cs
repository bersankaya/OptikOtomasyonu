
namespace OptikOtomasyonu
{
    partial class frmUrunGrubuEkle
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
            OptikOtomasyonu.Btnstandart BtnSil;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunGrubuEkle));
            this.ListUrunGrup = new System.Windows.Forms.ListBox();
            this.BtnEkle = new OptikOtomasyonu.Btnstandart();
            this.TxtUrunGrup = new OptikOtomasyonu.TxtStandart();
            this.lblstandart1 = new OptikOtomasyonu.lblstandart();
            BtnSil = new OptikOtomasyonu.Btnstandart();
            this.SuspendLayout();
            // 
            // BtnSil
            // 
            BtnSil.BackColor = System.Drawing.Color.Olive;
            BtnSil.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            BtnSil.ForeColor = System.Drawing.Color.White;
            BtnSil.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.Image")));
            BtnSil.Location = new System.Drawing.Point(17, 344);
            BtnSil.Margin = new System.Windows.Forms.Padding(1);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new System.Drawing.Size(137, 79);
            BtnSil.TabIndex = 3;
            BtnSil.Text = "SİL";
            BtnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BtnSil.UseVisualStyleBackColor = false;
            BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // ListUrunGrup
            // 
            this.ListUrunGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListUrunGrup.FormattingEnabled = true;
            this.ListUrunGrup.ItemHeight = 25;
            this.ListUrunGrup.Location = new System.Drawing.Point(12, 86);
            this.ListUrunGrup.Name = "ListUrunGrup";
            this.ListUrunGrup.Size = new System.Drawing.Size(324, 254);
            this.ListUrunGrup.TabIndex = 2;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.Tomato;
            this.BtnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.ForeColor = System.Drawing.Color.White;
            this.BtnEkle.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(194, 344);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(1);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(137, 79);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = " EKLE";
            this.BtnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtUrunGrup
            // 
            this.TxtUrunGrup.BackColor = System.Drawing.Color.White;
            this.TxtUrunGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtUrunGrup.Location = new System.Drawing.Point(12, 50);
            this.TxtUrunGrup.Name = "TxtUrunGrup";
            this.TxtUrunGrup.Size = new System.Drawing.Size(319, 30);
            this.TxtUrunGrup.TabIndex = 1;
            // 
            // lblstandart1
            // 
            this.lblstandart1.AutoSize = true;
            this.lblstandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblstandart1.Location = new System.Drawing.Point(7, 6);
            this.lblstandart1.Name = "lblstandart1";
            this.lblstandart1.Size = new System.Drawing.Size(147, 25);
            this.lblstandart1.TabIndex = 0;
            this.lblstandart1.Text = "Ürün Grubu Adı";
            // 
            // frmUrunGrubuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(348, 452);
            this.Controls.Add(BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.ListUrunGrup);
            this.Controls.Add(this.TxtUrunGrup);
            this.Controls.Add(this.lblstandart1);
            this.Name = "frmUrunGrubuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Grubu İşlemleri";
            this.Load += new System.EventHandler(this.frmUrunGrubuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lblstandart lblstandart1;
        private TxtStandart TxtUrunGrup;
        private System.Windows.Forms.ListBox ListUrunGrup;
        private Btnstandart BtnEkle;
    }
}
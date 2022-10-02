
namespace OptikOtomasyonu
{
    partial class FrmStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStok));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Panelislemturu = new System.Windows.Forms.Panel();
            this.cmbislemturu = new System.Windows.Forms.ComboBox();
            this.lblstandart1 = new OptikOtomasyonu.lblstandart();
            this.btnAra = new OptikOtomasyonu.Btnstandart();
            this.PanelTarihler = new System.Windows.Forms.Panel();
            this.lblstandart5 = new OptikOtomasyonu.lblstandart();
            this.datebitis = new System.Windows.Forms.DateTimePicker();
            this.datebaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblstandart4 = new OptikOtomasyonu.lblstandart();
            this.PanelUrunGrubu = new System.Windows.Forms.Panel();
            this.cmburungrubu = new System.Windows.Forms.ComboBox();
            this.lblstandart3 = new OptikOtomasyonu.lblstandart();
            this.PanelFiltreleme = new System.Windows.Forms.Panel();
            this.RdUrunGrubunaGore = new System.Windows.Forms.RadioButton();
            this.rdTumu = new System.Windows.Forms.RadioButton();
            this.lblstandart2 = new OptikOtomasyonu.lblstandart();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.LblKullanici = new OptikOtomasyonu.lblstandart();
            this.BtnRaporAl = new OptikOtomasyonu.Btnstandart();
            this.TxtUrunAra = new OptikOtomasyonu.TxtStandart();
            this.lblstandart6 = new OptikOtomasyonu.lblstandart();
            this.gridStok = new OptikOtomasyonu.ozelgrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Panelislemturu.SuspendLayout();
            this.PanelTarihler.SuspendLayout();
            this.PanelUrunGrubu.SuspendLayout();
            this.PanelFiltreleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStok)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1663, 777);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1655, 742);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürün Stoğu";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Linen;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Linen;
            this.splitContainer1.Panel1.Controls.Add(this.Panelislemturu);
            this.splitContainer1.Panel1.Controls.Add(this.btnAra);
            this.splitContainer1.Panel1.Controls.Add(this.PanelTarihler);
            this.splitContainer1.Panel1.Controls.Add(this.PanelUrunGrubu);
            this.splitContainer1.Panel1.Controls.Add(this.PanelFiltreleme);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1649, 736);
            this.splitContainer1.SplitterDistance = 363;
            this.splitContainer1.TabIndex = 0;
            // 
            // Panelislemturu
            // 
            this.Panelislemturu.Controls.Add(this.cmbislemturu);
            this.Panelislemturu.Controls.Add(this.lblstandart1);
            this.Panelislemturu.Location = new System.Drawing.Point(0, 3);
            this.Panelislemturu.Name = "Panelislemturu";
            this.Panelislemturu.Size = new System.Drawing.Size(349, 131);
            this.Panelislemturu.TabIndex = 7;
            // 
            // cmbislemturu
            // 
            this.cmbislemturu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbislemturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbislemturu.FormattingEnabled = true;
            this.cmbislemturu.Items.AddRange(new object[] {
            "Stok Durumu\t",
            "Stok Giriş İzleme"});
            this.cmbislemturu.Location = new System.Drawing.Point(26, 63);
            this.cmbislemturu.Name = "cmbislemturu";
            this.cmbislemturu.Size = new System.Drawing.Size(320, 33);
            this.cmbislemturu.TabIndex = 3;
            // 
            // lblstandart1
            // 
            this.lblstandart1.AutoSize = true;
            this.lblstandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart1.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblstandart1.Location = new System.Drawing.Point(29, 25);
            this.lblstandart1.Name = "lblstandart1";
            this.lblstandart1.Size = new System.Drawing.Size(104, 25);
            this.lblstandart1.TabIndex = 2;
            this.lblstandart1.Text = "İşlem Türü";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.DarkRed;
            this.btnAra.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.Location = new System.Drawing.Point(197, 620);
            this.btnAra.Margin = new System.Windows.Forms.Padding(1);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(149, 65);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "ARA";
            this.btnAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // PanelTarihler
            // 
            this.PanelTarihler.Controls.Add(this.lblstandart5);
            this.PanelTarihler.Controls.Add(this.datebitis);
            this.PanelTarihler.Controls.Add(this.datebaslangic);
            this.PanelTarihler.Controls.Add(this.lblstandart4);
            this.PanelTarihler.Location = new System.Drawing.Point(5, 437);
            this.PanelTarihler.Name = "PanelTarihler";
            this.PanelTarihler.Size = new System.Drawing.Size(344, 179);
            this.PanelTarihler.TabIndex = 5;
            // 
            // lblstandart5
            // 
            this.lblstandart5.AutoSize = true;
            this.lblstandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart5.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblstandart5.Location = new System.Drawing.Point(20, 106);
            this.lblstandart5.Name = "lblstandart5";
            this.lblstandart5.Size = new System.Drawing.Size(102, 25);
            this.lblstandart5.TabIndex = 3;
            this.lblstandart5.Text = "Bitiş Tarihi";
            // 
            // datebitis
            // 
            this.datebitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datebitis.Location = new System.Drawing.Point(15, 134);
            this.datebitis.Name = "datebitis";
            this.datebitis.Size = new System.Drawing.Size(326, 30);
            this.datebitis.TabIndex = 2;
            // 
            // datebaslangic
            // 
            this.datebaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datebaslangic.Location = new System.Drawing.Point(21, 48);
            this.datebaslangic.Name = "datebaslangic";
            this.datebaslangic.Size = new System.Drawing.Size(320, 30);
            this.datebaslangic.TabIndex = 1;
            // 
            // lblstandart4
            // 
            this.lblstandart4.AutoSize = true;
            this.lblstandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart4.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblstandart4.Location = new System.Drawing.Point(20, 20);
            this.lblstandart4.Name = "lblstandart4";
            this.lblstandart4.Size = new System.Drawing.Size(151, 25);
            this.lblstandart4.TabIndex = 0;
            this.lblstandart4.Text = "Başlangıç Tarihi";
            // 
            // PanelUrunGrubu
            // 
            this.PanelUrunGrubu.Controls.Add(this.cmburungrubu);
            this.PanelUrunGrubu.Controls.Add(this.lblstandart3);
            this.PanelUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PanelUrunGrubu.Location = new System.Drawing.Point(5, 323);
            this.PanelUrunGrubu.Name = "PanelUrunGrubu";
            this.PanelUrunGrubu.Size = new System.Drawing.Size(344, 108);
            this.PanelUrunGrubu.TabIndex = 3;
            // 
            // cmburungrubu
            // 
            this.cmburungrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmburungrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmburungrubu.FormattingEnabled = true;
            this.cmburungrubu.Location = new System.Drawing.Point(20, 59);
            this.cmburungrubu.Name = "cmburungrubu";
            this.cmburungrubu.Size = new System.Drawing.Size(324, 33);
            this.cmburungrubu.TabIndex = 1;
            // 
            // lblstandart3
            // 
            this.lblstandart3.AutoSize = true;
            this.lblstandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart3.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblstandart3.Location = new System.Drawing.Point(15, 21);
            this.lblstandart3.Name = "lblstandart3";
            this.lblstandart3.Size = new System.Drawing.Size(113, 25);
            this.lblstandart3.TabIndex = 0;
            this.lblstandart3.Text = "Ürün Grubu";
            // 
            // PanelFiltreleme
            // 
            this.PanelFiltreleme.Controls.Add(this.RdUrunGrubunaGore);
            this.PanelFiltreleme.Controls.Add(this.rdTumu);
            this.PanelFiltreleme.Controls.Add(this.lblstandart2);
            this.PanelFiltreleme.Location = new System.Drawing.Point(5, 140);
            this.PanelFiltreleme.Name = "PanelFiltreleme";
            this.PanelFiltreleme.Size = new System.Drawing.Size(344, 177);
            this.PanelFiltreleme.TabIndex = 2;
            // 
            // RdUrunGrubunaGore
            // 
            this.RdUrunGrubunaGore.AutoSize = true;
            this.RdUrunGrubunaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdUrunGrubunaGore.ForeColor = System.Drawing.Color.DarkCyan;
            this.RdUrunGrubunaGore.Location = new System.Drawing.Point(15, 100);
            this.RdUrunGrubunaGore.Name = "RdUrunGrubunaGore";
            this.RdUrunGrubunaGore.Size = new System.Drawing.Size(204, 29);
            this.RdUrunGrubunaGore.TabIndex = 3;
            this.RdUrunGrubunaGore.TabStop = true;
            this.RdUrunGrubunaGore.Text = "Ürün Grubuna Göre";
            this.RdUrunGrubunaGore.UseVisualStyleBackColor = true;
            // 
            // rdTumu
            // 
            this.rdTumu.AutoSize = true;
            this.rdTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTumu.ForeColor = System.Drawing.Color.DarkCyan;
            this.rdTumu.Location = new System.Drawing.Point(15, 66);
            this.rdTumu.Name = "rdTumu";
            this.rdTumu.Size = new System.Drawing.Size(84, 29);
            this.rdTumu.TabIndex = 2;
            this.rdTumu.TabStop = true;
            this.rdTumu.Text = "Tümü";
            this.rdTumu.UseVisualStyleBackColor = true;
            // 
            // lblstandart2
            // 
            this.lblstandart2.AutoSize = true;
            this.lblstandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart2.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblstandart2.Location = new System.Drawing.Point(10, 23);
            this.lblstandart2.Name = "lblstandart2";
            this.lblstandart2.Size = new System.Drawing.Size(142, 25);
            this.lblstandart2.TabIndex = 1;
            this.lblstandart2.Text = "Filtreleme Türü";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Linen;
            this.splitContainer2.Panel1.Controls.Add(this.LblKullanici);
            this.splitContainer2.Panel1.Controls.Add(this.BtnRaporAl);
            this.splitContainer2.Panel1.Controls.Add(this.TxtUrunAra);
            this.splitContainer2.Panel1.Controls.Add(this.lblstandart6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridStok);
            this.splitContainer2.Size = new System.Drawing.Size(1282, 736);
            this.splitContainer2.SplitterDistance = 109;
            this.splitContainer2.TabIndex = 0;
            // 
            // LblKullanici
            // 
            this.LblKullanici.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblKullanici.AutoSize = true;
            this.LblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblKullanici.ForeColor = System.Drawing.Color.Black;
            this.LblKullanici.Location = new System.Drawing.Point(1175, 5);
            this.LblKullanici.Name = "LblKullanici";
            this.LblKullanici.Size = new System.Drawing.Size(85, 25);
            this.LblKullanici.TabIndex = 8;
            this.LblKullanici.Text = "Kullanıcı";
            // 
            // BtnRaporAl
            // 
            this.BtnRaporAl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnRaporAl.BackColor = System.Drawing.Color.SlateGray;
            this.BtnRaporAl.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.BtnRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRaporAl.ForeColor = System.Drawing.Color.White;
            this.BtnRaporAl.Image = ((System.Drawing.Image)(resources.GetObject("BtnRaporAl.Image")));
            this.BtnRaporAl.Location = new System.Drawing.Point(1109, 31);
            this.BtnRaporAl.Margin = new System.Windows.Forms.Padding(1);
            this.BtnRaporAl.Name = "BtnRaporAl";
            this.BtnRaporAl.Size = new System.Drawing.Size(172, 69);
            this.BtnRaporAl.TabIndex = 18;
            this.BtnRaporAl.Text = "Rapor Al";
            this.BtnRaporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRaporAl.UseVisualStyleBackColor = false;
            this.BtnRaporAl.Click += new System.EventHandler(this.BtnRaporAl_Click);
            // 
            // TxtUrunAra
            // 
            this.TxtUrunAra.BackColor = System.Drawing.Color.White;
            this.TxtUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtUrunAra.Location = new System.Drawing.Point(42, 56);
            this.TxtUrunAra.Name = "TxtUrunAra";
            this.TxtUrunAra.Size = new System.Drawing.Size(266, 30);
            this.TxtUrunAra.TabIndex = 1;
            this.TxtUrunAra.TextChanged += new System.EventHandler(this.TxtUrunAra_TextChanged);
            // 
            // lblstandart6
            // 
            this.lblstandart6.AutoSize = true;
            this.lblstandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblstandart6.Location = new System.Drawing.Point(37, 28);
            this.lblstandart6.Name = "lblstandart6";
            this.lblstandart6.Size = new System.Drawing.Size(90, 25);
            this.lblstandart6.TabIndex = 0;
            this.lblstandart6.Text = "Ürün Ara";
            // 
            // gridStok
            // 
            this.gridStok.AllowUserToAddRows = false;
            this.gridStok.AllowUserToDeleteRows = false;
            this.gridStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStok.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridStok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridStok.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStok.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStok.EnableHeadersVisualStyles = false;
            this.gridStok.Location = new System.Drawing.Point(0, 0);
            this.gridStok.Name = "gridStok";
            this.gridStok.ReadOnly = true;
            this.gridStok.RowHeadersVisible = false;
            this.gridStok.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStok.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridStok.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridStok.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.gridStok.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridStok.RowTemplate.Height = 32;
            this.gridStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStok.Size = new System.Drawing.Size(1282, 623);
            this.gridStok.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1655, 742);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cam Stoğu";
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1663, 777);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok İzleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStok_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Panelislemturu.ResumeLayout(false);
            this.Panelislemturu.PerformLayout();
            this.PanelTarihler.ResumeLayout(false);
            this.PanelTarihler.PerformLayout();
            this.PanelUrunGrubu.ResumeLayout(false);
            this.PanelUrunGrubu.PerformLayout();
            this.PanelFiltreleme.ResumeLayout(false);
            this.PanelFiltreleme.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel Panelislemturu;
        private System.Windows.Forms.ComboBox cmbislemturu;
        private lblstandart lblstandart1;
        private Btnstandart btnAra;
        private System.Windows.Forms.Panel PanelTarihler;
        private lblstandart lblstandart5;
        private System.Windows.Forms.DateTimePicker datebitis;
        private System.Windows.Forms.DateTimePicker datebaslangic;
        private lblstandart lblstandart4;
        private System.Windows.Forms.Panel PanelUrunGrubu;
        private System.Windows.Forms.ComboBox cmburungrubu;
        private lblstandart lblstandart3;
        private System.Windows.Forms.Panel PanelFiltreleme;
        private System.Windows.Forms.RadioButton RdUrunGrubunaGore;
        private System.Windows.Forms.RadioButton rdTumu;
        private lblstandart lblstandart2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private TxtStandart TxtUrunAra;
        private lblstandart lblstandart6;
        private ozelgrid gridStok;
        private Btnstandart BtnRaporAl;
        internal lblstandart LblKullanici;
    }
}
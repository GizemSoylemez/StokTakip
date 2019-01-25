namespace GFStokTakip.Modul_Zimmet
{
    partial class frmZimmetListesi
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtDepartman = new DevExpress.XtraEditors.TextEdit();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtPersonelAdi = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ZimmetKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepartmanAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PersonelKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunAlisFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PersonelAdiSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PersonelRutbe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IseBaslangicTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TeslimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelAdi.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Ürün Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Departman";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Personel Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(11, 136);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 0;
            // 
            // txtDepartman
            // 
            this.txtDepartman.Location = new System.Drawing.Point(11, 86);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(100, 20);
            this.txtDepartman.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(515, 363);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.ZimmetKodu,
            this.TeslimTarihi,
            this.UrunAdi,
            this.UrunKodu,
            this.UrunAlisFiyat,
            this.DepartmanAdi,
            this.PersonelKodu,
            this.PersonelAdiSoyadi,
            this.PersonelRutbe,
            this.IseBaslangicTarihi});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Location = new System.Drawing.Point(11, 39);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelAdi.TabIndex = 0;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtUrunAdi);
            this.xtraTabPage1.Controls.Add(this.txtDepartman);
            this.xtraTabPage1.Controls.Add(this.txtPersonelAdi);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(178, 335);
            this.xtraTabPage1.Text = "Arama";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(184, 363);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(704, 363);
            this.splitContainerControl1.SplitterPosition = 184;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::GFStokTakip.Properties.Resources.Sil32x32;
            this.btnSil.Location = new System.Drawing.Point(90, 162);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(73, 36);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::GFStokTakip.Properties.Resources.Ara32x32;
            this.btnAra.Location = new System.Drawing.Point(11, 162);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(73, 36);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // ZimmetKodu
            // 
            this.ZimmetKodu.Caption = "Zimmet Kodu";
            this.ZimmetKodu.FieldName = "ZimmetKodu";
            this.ZimmetKodu.Name = "ZimmetKodu";
            this.ZimmetKodu.OptionsColumn.AllowEdit = false;
            this.ZimmetKodu.OptionsColumn.AllowFocus = false;
            this.ZimmetKodu.Visible = true;
            this.ZimmetKodu.VisibleIndex = 0;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Caption = "Ürün Adı";
            this.UrunAdi.FieldName = "UrunAdi";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.OptionsColumn.AllowEdit = false;
            this.UrunAdi.OptionsColumn.AllowFocus = false;
            this.UrunAdi.Visible = true;
            this.UrunAdi.VisibleIndex = 1;
            // 
            // UrunKodu
            // 
            this.UrunKodu.Caption = "Ürün Kodu";
            this.UrunKodu.FieldName = "UrunKodu";
            this.UrunKodu.Name = "UrunKodu";
            this.UrunKodu.OptionsColumn.AllowEdit = false;
            this.UrunKodu.OptionsColumn.AllowFocus = false;
            this.UrunKodu.Visible = true;
            this.UrunKodu.VisibleIndex = 5;
            // 
            // DepartmanAdi
            // 
            this.DepartmanAdi.Caption = "Departman Adı";
            this.DepartmanAdi.FieldName = "DepartmanAdi";
            this.DepartmanAdi.Name = "DepartmanAdi";
            this.DepartmanAdi.OptionsColumn.AllowEdit = false;
            this.DepartmanAdi.OptionsColumn.AllowFocus = false;
            this.DepartmanAdi.Visible = true;
            this.DepartmanAdi.VisibleIndex = 2;
            // 
            // PersonelKodu
            // 
            this.PersonelKodu.Caption = "Personel Kodu";
            this.PersonelKodu.FieldName = "PersonelKodu";
            this.PersonelKodu.Name = "PersonelKodu";
            this.PersonelKodu.OptionsColumn.AllowEdit = false;
            this.PersonelKodu.OptionsColumn.AllowFocus = false;
            this.PersonelKodu.Visible = true;
            this.PersonelKodu.VisibleIndex = 4;
            // 
            // UrunAlisFiyat
            // 
            this.UrunAlisFiyat.Caption = "Alış Fiyatı";
            this.UrunAlisFiyat.FieldName = "UrunAlisFiyat";
            this.UrunAlisFiyat.Name = "UrunAlisFiyat";
            this.UrunAlisFiyat.OptionsColumn.AllowEdit = false;
            this.UrunAlisFiyat.OptionsColumn.AllowFocus = false;
            this.UrunAlisFiyat.Visible = true;
            this.UrunAlisFiyat.VisibleIndex = 3;
            // 
            // PersonelAdiSoyadi
            // 
            this.PersonelAdiSoyadi.Caption = "Adı Soyadı";
            this.PersonelAdiSoyadi.FieldName = "PersonelAdiSoyadi";
            this.PersonelAdiSoyadi.Name = "PersonelAdiSoyadi";
            this.PersonelAdiSoyadi.OptionsColumn.AllowEdit = false;
            this.PersonelAdiSoyadi.OptionsColumn.AllowFocus = false;
            this.PersonelAdiSoyadi.Visible = true;
            this.PersonelAdiSoyadi.VisibleIndex = 6;
            // 
            // PersonelRutbe
            // 
            this.PersonelRutbe.Caption = "Rütbe";
            this.PersonelRutbe.FieldName = "PersonelRutbe";
            this.PersonelRutbe.Name = "PersonelRutbe";
            this.PersonelRutbe.OptionsColumn.AllowEdit = false;
            this.PersonelRutbe.OptionsColumn.AllowFocus = false;
            this.PersonelRutbe.Visible = true;
            this.PersonelRutbe.VisibleIndex = 7;
            // 
            // IseBaslangicTarihi
            // 
            this.IseBaslangicTarihi.Caption = "İşe Başlangıç Tarihi";
            this.IseBaslangicTarihi.FieldName = "IseBaslangicTarihi";
            this.IseBaslangicTarihi.Name = "IseBaslangicTarihi";
            this.IseBaslangicTarihi.OptionsColumn.AllowEdit = false;
            this.IseBaslangicTarihi.OptionsColumn.AllowFocus = false;
            this.IseBaslangicTarihi.Visible = true;
            this.IseBaslangicTarihi.VisibleIndex = 8;
            // 
            // TeslimTarihi
            // 
            this.TeslimTarihi.Caption = "Teslim Tarihi";
            this.TeslimTarihi.FieldName = "TeslimTarihi";
            this.TeslimTarihi.Name = "TeslimTarihi";
            this.TeslimTarihi.OptionsColumn.AllowEdit = false;
            this.TeslimTarihi.OptionsColumn.AllowFocus = false;
            this.TeslimTarihi.Visible = true;
            this.TeslimTarihi.VisibleIndex = 9;
            // 
            // frmZimmetListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 363);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmZimmetListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zimmet Listesi";
            this.Load += new System.EventHandler(this.frmZimmetListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelAdi.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn UrunAlisFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn DepartmanAdi;
        private DevExpress.XtraGrid.Columns.GridColumn UrunKodu;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn UrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn ZimmetKodu;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.TextEdit txtDepartman;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn PersonelKodu;
        private DevExpress.XtraEditors.TextEdit txtPersonelAdi;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.GridColumn PersonelAdiSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn TeslimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn PersonelRutbe;
        private DevExpress.XtraGrid.Columns.GridColumn IseBaslangicTarihi;
    }
}
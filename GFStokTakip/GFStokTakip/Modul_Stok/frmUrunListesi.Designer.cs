namespace GFStokTakip.Modul_Stok
{
    partial class frmUrunListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunListesi));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunKodu = new DevExpress.XtraEditors.TextEdit();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunAlisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunAlisFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPDFYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.btnXLSYazdir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(627, 334);
            this.splitContainerControl1.SplitterPosition = 184;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(184, 334);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.btnXLSYazdir);
            this.xtraTabPage1.Controls.Add(this.btnPDFYazdir);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtBarkod);
            this.xtraTabPage1.Controls.Add(this.txtUrunAdi);
            this.xtraTabPage1.Controls.Add(this.txtUrunKodu);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(178, 306);
            this.xtraTabPage1.Text = "Arama";
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
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Barkod";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ürün Adı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ürün Kodu";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(11, 136);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(100, 20);
            this.txtBarkod.TabIndex = 0;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(11, 86);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 0;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(11, 39);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(100, 20);
            this.txtUrunKodu.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(438, 334);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.UrunKodu,
            this.UrunAdi,
            this.UrunBarkod,
            this.UrunStokMiktari,
            this.UrunAlisTarihi,
            this.UrunAlisFiyat});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // UrunKodu
            // 
            this.UrunKodu.Caption = "Ürün Kodu";
            this.UrunKodu.FieldName = "UrunKodu";
            this.UrunKodu.Name = "UrunKodu";
            this.UrunKodu.OptionsColumn.AllowEdit = false;
            this.UrunKodu.OptionsColumn.AllowFocus = false;
            this.UrunKodu.Visible = true;
            this.UrunKodu.VisibleIndex = 0;
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
            // UrunBarkod
            // 
            this.UrunBarkod.Caption = "Barkod";
            this.UrunBarkod.FieldName = "UrunBarkod";
            this.UrunBarkod.Name = "UrunBarkod";
            this.UrunBarkod.OptionsColumn.AllowEdit = false;
            this.UrunBarkod.OptionsColumn.AllowFocus = false;
            this.UrunBarkod.Visible = true;
            this.UrunBarkod.VisibleIndex = 5;
            // 
            // UrunStokMiktari
            // 
            this.UrunStokMiktari.Caption = "Adet";
            this.UrunStokMiktari.FieldName = "UrunStokMiktari";
            this.UrunStokMiktari.Name = "UrunStokMiktari";
            this.UrunStokMiktari.OptionsColumn.AllowEdit = false;
            this.UrunStokMiktari.OptionsColumn.AllowFocus = false;
            this.UrunStokMiktari.Visible = true;
            this.UrunStokMiktari.VisibleIndex = 2;
            // 
            // UrunAlisTarihi
            // 
            this.UrunAlisTarihi.Caption = "Alış Tarihi";
            this.UrunAlisTarihi.FieldName = "UrunAlisTarihi";
            this.UrunAlisTarihi.Name = "UrunAlisTarihi";
            this.UrunAlisTarihi.OptionsColumn.AllowEdit = false;
            this.UrunAlisTarihi.OptionsColumn.AllowFocus = false;
            this.UrunAlisTarihi.Visible = true;
            this.UrunAlisTarihi.VisibleIndex = 4;
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
            // btnPDFYazdir
            // 
            this.btnPDFYazdir.ImageOptions.Image = global::GFStokTakip.Properties.Resources.Ara32x32;
            this.btnPDFYazdir.Location = new System.Drawing.Point(11, 204);
            this.btnPDFYazdir.Name = "btnPDFYazdir";
            this.btnPDFYazdir.Size = new System.Drawing.Size(152, 36);
            this.btnPDFYazdir.TabIndex = 2;
            this.btnPDFYazdir.Text = "Listeyi Yazdır(PDF)";
            this.btnPDFYazdir.Click += new System.EventHandler(this.btnPDFYazdir_Click);
            // 
            // btnXLSYazdir
            // 
            this.btnXLSYazdir.ImageOptions.Image = global::GFStokTakip.Properties.Resources.Ara32x32;
            this.btnXLSYazdir.Location = new System.Drawing.Point(11, 246);
            this.btnXLSYazdir.Name = "btnXLSYazdir";
            this.btnXLSYazdir.Size = new System.Drawing.Size(152, 36);
            this.btnXLSYazdir.TabIndex = 2;
            this.btnXLSYazdir.Text = "Listeyi Yazdır(XLS)";
            this.btnXLSYazdir.Click += new System.EventHandler(this.btnXLSYazdir_Click);
            // 
            // frmUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 334);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUrunListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.frmUrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.TextEdit txtUrunKodu;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn UrunKodu;
        private DevExpress.XtraGrid.Columns.GridColumn UrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn UrunBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn UrunStokMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn UrunAlisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn UrunAlisFiyat;
        private DevExpress.XtraEditors.SimpleButton btnPDFYazdir;
        private DevExpress.XtraEditors.SimpleButton btnXLSYazdir;
    }
}
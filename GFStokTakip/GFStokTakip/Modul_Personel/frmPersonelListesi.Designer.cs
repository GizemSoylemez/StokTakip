namespace GFStokTakip.Modul_Musteri
{
    partial class frmMusteriListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriListesi));
            this.PersonelSifre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PersonelAdiSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PersonelKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PersonelKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPersonelAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtPersonelKodu = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtDepartman = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.PersonelRutbe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepartmanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SorumluOldDepartmanID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelKodu.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonelSifre
            // 
            this.PersonelSifre.Caption = "Şifre";
            this.PersonelSifre.FieldName = "PersonelSifre";
            this.PersonelSifre.Name = "PersonelSifre";
            this.PersonelSifre.OptionsColumn.AllowEdit = false;
            this.PersonelSifre.OptionsColumn.AllowFocus = false;
            this.PersonelSifre.OptionsColumn.FixedWidth = true;
            this.PersonelSifre.Visible = true;
            this.PersonelSifre.VisibleIndex = 4;
            // 
            // PersonelAdiSoyadi
            // 
            this.PersonelAdiSoyadi.Caption = "Personel Adı Soyadı";
            this.PersonelAdiSoyadi.FieldName = "PersonelAdiSoyadi";
            this.PersonelAdiSoyadi.Name = "PersonelAdiSoyadi";
            this.PersonelAdiSoyadi.OptionsColumn.AllowEdit = false;
            this.PersonelAdiSoyadi.OptionsColumn.AllowFocus = false;
            this.PersonelAdiSoyadi.OptionsColumn.FixedWidth = true;
            this.PersonelAdiSoyadi.Visible = true;
            this.PersonelAdiSoyadi.VisibleIndex = 1;
            // 
            // PersonelKodu
            // 
            this.PersonelKodu.Caption = "Personel Kodu";
            this.PersonelKodu.FieldName = "PersonelKodu";
            this.PersonelKodu.Name = "PersonelKodu";
            this.PersonelKodu.OptionsColumn.AllowEdit = false;
            this.PersonelKodu.OptionsColumn.AllowFocus = false;
            this.PersonelKodu.OptionsColumn.FixedWidth = true;
            this.PersonelKodu.Visible = true;
            this.PersonelKodu.VisibleIndex = 0;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::GFStokTakip.Properties.Resources.Sil32x32;
            this.btnSil.Location = new System.Drawing.Point(90, 162);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(73, 36);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::GFStokTakip.Properties.Resources.Ara32x32;
            this.btnAra.Location = new System.Drawing.Point(11, 162);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(73, 36);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Departman";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Personel Adı";
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(558, 304);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.PersonelKodu,
            this.PersonelAdiSoyadi,
            this.PersonelRutbe,
            this.PersonelKullaniciAdi,
            this.PersonelSifre,
            this.DepartmanID,
            this.SorumluOldDepartmanID});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // PersonelKullaniciAdi
            // 
            this.PersonelKullaniciAdi.Caption = "Kullanıcı Adı";
            this.PersonelKullaniciAdi.FieldName = "PersonelKullaniciAdi";
            this.PersonelKullaniciAdi.Name = "PersonelKullaniciAdi";
            this.PersonelKullaniciAdi.OptionsColumn.AllowEdit = false;
            this.PersonelKullaniciAdi.OptionsColumn.AllowFocus = false;
            this.PersonelKullaniciAdi.OptionsColumn.FixedWidth = true;
            this.PersonelKullaniciAdi.Visible = true;
            this.PersonelKullaniciAdi.VisibleIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Personel Kodu";
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Location = new System.Drawing.Point(11, 86);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelAdi.TabIndex = 0;
            // 
            // txtPersonelKodu
            // 
            this.txtPersonelKodu.Location = new System.Drawing.Point(11, 39);
            this.txtPersonelKodu.Name = "txtPersonelKodu";
            this.txtPersonelKodu.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelKodu.TabIndex = 0;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtDepartman);
            this.xtraTabPage1.Controls.Add(this.txtPersonelAdi);
            this.xtraTabPage1.Controls.Add(this.txtPersonelKodu);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(178, 276);
            this.xtraTabPage1.Text = "Arama";
            // 
            // txtDepartman
            // 
            this.txtDepartman.Location = new System.Drawing.Point(11, 136);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(100, 20);
            this.txtDepartman.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(184, 304);
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
            this.splitContainerControl1.Size = new System.Drawing.Size(747, 304);
            this.splitContainerControl1.SplitterPosition = 184;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // PersonelRutbe
            // 
            this.PersonelRutbe.Caption = "Personel Rütbesi";
            this.PersonelRutbe.FieldName = "PersonelRutbe";
            this.PersonelRutbe.Name = "PersonelRutbe";
            this.PersonelRutbe.OptionsColumn.AllowEdit = false;
            this.PersonelRutbe.OptionsColumn.AllowFocus = false;
            this.PersonelRutbe.OptionsColumn.FixedWidth = true;
            this.PersonelRutbe.Visible = true;
            this.PersonelRutbe.VisibleIndex = 2;
            this.PersonelRutbe.Width = 87;
            // 
            // DepartmanID
            // 
            this.DepartmanID.Caption = "Departman";
            this.DepartmanID.FieldName = "DepartmanID";
            this.DepartmanID.Name = "DepartmanID";
            this.DepartmanID.OptionsColumn.AllowEdit = false;
            this.DepartmanID.OptionsColumn.AllowFocus = false;
            this.DepartmanID.OptionsColumn.FixedWidth = true;
            this.DepartmanID.Visible = true;
            this.DepartmanID.VisibleIndex = 5;
            this.DepartmanID.Width = 74;
            // 
            // SorumluOldDepartmanID
            // 
            this.SorumluOldDepartmanID.Caption = "Sorumlu Olduğu Departman";
            this.SorumluOldDepartmanID.FieldName = "SorumluOldDepartmanID";
            this.SorumluOldDepartmanID.Name = "SorumluOldDepartmanID";
            this.SorumluOldDepartmanID.OptionsColumn.AllowEdit = false;
            this.SorumluOldDepartmanID.OptionsColumn.AllowFocus = false;
            this.SorumluOldDepartmanID.OptionsColumn.FixedWidth = true;
            this.SorumluOldDepartmanID.Visible = true;
            this.SorumluOldDepartmanID.VisibleIndex = 6;
            this.SorumluOldDepartmanID.Width = 79;
            // 
            // frmMusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 304);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusteriListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMusteriListesi";
            this.Load += new System.EventHandler(this.frmMusteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelKodu.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn PersonelSifre;
        private DevExpress.XtraGrid.Columns.GridColumn PersonelAdiSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn PersonelKodu;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn PersonelKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPersonelAdi;
        private DevExpress.XtraEditors.TextEdit txtPersonelKodu;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.TextEdit txtDepartman;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.GridColumn PersonelRutbe;
        private DevExpress.XtraGrid.Columns.GridColumn DepartmanID;
        private DevExpress.XtraGrid.Columns.GridColumn SorumluOldDepartmanID;
    }
}
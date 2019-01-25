namespace GFStokTakip.Modul_Kullanicilar
{
    partial class frmKullaniciYonetimi
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnYeniKullanici = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PersonelAdiSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PersonelKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PersonelRutbe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PersonelKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SorumluOldDepartman = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnYeniKullanici);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(646, 40);
            this.panelControl1.TabIndex = 2;
            // 
            // btnYeniKullanici
            // 
            this.btnYeniKullanici.Location = new System.Drawing.Point(16, 5);
            this.btnYeniKullanici.Name = "btnYeniKullanici";
            this.btnYeniKullanici.Size = new System.Drawing.Size(175, 24);
            this.btnYeniKullanici.TabIndex = 0;
            this.btnYeniKullanici.Text = "Yeni Kullanıcı Girişi";
            this.btnYeniKullanici.Click += new System.EventHandler(this.btnYeniKullanici_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(646, 268);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.PersonelAdiSoyadi,
            this.PersonelKodu,
            this.PersonelRutbe,
            this.PersonelKullaniciAdi,
            this.SorumluOldDepartman});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.OptionsColumn.ReadOnly = true;
            // 
            // PersonelAdiSoyadi
            // 
            this.PersonelAdiSoyadi.Caption = "Adı Soyadı";
            this.PersonelAdiSoyadi.FieldName = "PersonelAdiSoyadi";
            this.PersonelAdiSoyadi.Name = "PersonelAdiSoyadi";
            this.PersonelAdiSoyadi.OptionsColumn.AllowEdit = false;
            this.PersonelAdiSoyadi.OptionsColumn.AllowFocus = false;
            this.PersonelAdiSoyadi.OptionsColumn.FixedWidth = true;
            this.PersonelAdiSoyadi.OptionsColumn.ReadOnly = true;
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
            this.PersonelKodu.OptionsColumn.ReadOnly = true;
            this.PersonelKodu.Visible = true;
            this.PersonelKodu.VisibleIndex = 0;
            // 
            // PersonelRutbe
            // 
            this.PersonelRutbe.Caption = "Rütbe";
            this.PersonelRutbe.FieldName = "PersonelRutbe";
            this.PersonelRutbe.Name = "PersonelRutbe";
            this.PersonelRutbe.OptionsColumn.AllowEdit = false;
            this.PersonelRutbe.OptionsColumn.AllowFocus = false;
            this.PersonelRutbe.OptionsColumn.FixedWidth = true;
            this.PersonelRutbe.OptionsColumn.ReadOnly = true;
            this.PersonelRutbe.Visible = true;
            this.PersonelRutbe.VisibleIndex = 3;
            // 
            // PersonelKullaniciAdi
            // 
            this.PersonelKullaniciAdi.Caption = "Kullanıcı Adı";
            this.PersonelKullaniciAdi.FieldName = "PersonelKullaniciAdi";
            this.PersonelKullaniciAdi.Name = "PersonelKullaniciAdi";
            this.PersonelKullaniciAdi.OptionsColumn.AllowEdit = false;
            this.PersonelKullaniciAdi.OptionsColumn.AllowFocus = false;
            this.PersonelKullaniciAdi.OptionsColumn.FixedWidth = true;
            this.PersonelKullaniciAdi.OptionsColumn.ReadOnly = true;
            this.PersonelKullaniciAdi.Visible = true;
            this.PersonelKullaniciAdi.VisibleIndex = 2;
            // 
            // SorumluOldDepartman
            // 
            this.SorumluOldDepartman.Caption = "Departman";
            this.SorumluOldDepartman.FieldName = "SorumluOldDepartman";
            this.SorumluOldDepartman.Name = "SorumluOldDepartman";
            this.SorumluOldDepartman.OptionsColumn.AllowEdit = false;
            this.SorumluOldDepartman.OptionsColumn.AllowFocus = false;
            this.SorumluOldDepartman.OptionsColumn.FixedWidth = true;
            this.SorumluOldDepartman.OptionsColumn.ReadOnly = true;
            this.SorumluOldDepartman.Visible = true;
            this.SorumluOldDepartman.VisibleIndex = 4;
            // 
            // frmKullaniciYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 308);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmKullaniciYonetimi";
            this.Text = "frmKullaniciYonetimi";
            this.Load += new System.EventHandler(this.frmKullaniciYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnYeniKullanici;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn PersonelAdiSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn PersonelKodu;
        private DevExpress.XtraGrid.Columns.GridColumn PersonelRutbe;
        private DevExpress.XtraGrid.Columns.GridColumn PersonelKullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn SorumluOldDepartman;
    }
}
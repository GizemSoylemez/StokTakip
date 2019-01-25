namespace GFStokTakip.Modul_Zimmet
{
    partial class frmZimmetIadeNeden
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtNedenAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNedenKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ZimmetIadeKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ZimmetIadeNeden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNedenAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNedenKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtNedenAdi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtNedenKodu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(331, 90);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Zimmet İade Nedenleri";
            // 
            // txtNedenAdi
            // 
            this.txtNedenAdi.Location = new System.Drawing.Point(81, 62);
            this.txtNedenAdi.Name = "txtNedenAdi";
            this.txtNedenAdi.Size = new System.Drawing.Size(147, 20);
            this.txtNedenAdi.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Neden Adı";
            // 
            // txtNedenKodu
            // 
            this.txtNedenKodu.Location = new System.Drawing.Point(81, 36);
            this.txtNedenKodu.Name = "txtNedenKodu";
            this.txtNedenKodu.Size = new System.Drawing.Size(147, 20);
            this.txtNedenKodu.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Neden Kodu";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = global::GFStokTakip.Properties.Resources.Kaydet24x24;
            this.btnKaydet.Location = new System.Drawing.Point(28, 33);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 29);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.liste);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 90);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(331, 251);
            this.groupControl2.TabIndex = 2;
            // 
            // liste
            // 
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(2, 20);
            this.liste.MainView = this.gridView1;
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(327, 163);
            this.liste.TabIndex = 0;
            this.liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.ZimmetIadeKodu,
            this.ZimmetIadeNeden});
            this.gridView1.GridControl = this.liste;
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
            // ZimmetIadeKodu
            // 
            this.ZimmetIadeKodu.Caption = "Neden Kodu";
            this.ZimmetIadeKodu.FieldName = "ZimmetIadeKodu";
            this.ZimmetIadeKodu.Name = "ZimmetIadeKodu";
            this.ZimmetIadeKodu.OptionsColumn.AllowEdit = false;
            this.ZimmetIadeKodu.OptionsColumn.AllowFocus = false;
            this.ZimmetIadeKodu.OptionsColumn.FixedWidth = true;
            this.ZimmetIadeKodu.Visible = true;
            this.ZimmetIadeKodu.VisibleIndex = 0;
            // 
            // ZimmetIadeNeden
            // 
            this.ZimmetIadeNeden.Caption = "Neden Adı";
            this.ZimmetIadeNeden.FieldName = "ZimmetIadeNeden";
            this.ZimmetIadeNeden.Name = "ZimmetIadeNeden";
            this.ZimmetIadeNeden.OptionsColumn.AllowEdit = false;
            this.ZimmetIadeNeden.OptionsColumn.AllowFocus = false;
            this.ZimmetIadeNeden.OptionsColumn.FixedWidth = true;
            this.ZimmetIadeNeden.Visible = true;
            this.ZimmetIadeNeden.VisibleIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnKaydet);
            this.groupControl3.Controls.Add(this.btnSil);
            this.groupControl3.Controls.Add(this.btnKapat);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 183);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(327, 66);
            this.groupControl3.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::GFStokTakip.Properties.Resources.Sil24x24;
            this.btnSil.Location = new System.Drawing.Point(129, 33);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 29);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = global::GFStokTakip.Properties.Resources.Kapat24x24;
            this.btnKapat.Location = new System.Drawing.Point(230, 33);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 29);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // frmZimmetIadeNeden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 341);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmZimmetIadeNeden";
            this.Text = "frmZimmetIadeNeden";
            this.Load += new System.EventHandler(this.frmZimmetIadeNeden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNedenAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNedenKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtNedenAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNedenKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn ZimmetIadeKodu;
        private DevExpress.XtraGrid.Columns.GridColumn ZimmetIadeNeden;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}
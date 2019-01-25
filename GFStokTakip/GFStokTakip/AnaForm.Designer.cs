namespace GFStokTakip
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnUrunEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUrunListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUrunGruplari = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUrunHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnPersonelEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnPersonelGruplari = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnPersonelListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnPersonelHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnTeminYerleri = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnUrunTurleri = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnTeminYeri = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnZimmetEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnZimmetListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnKullanici = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.txtAltKullanici = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnYoneticiIslemleri = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnUrunEkle,
            this.barBtnUrunListesi,
            this.barBtnUrunGruplari,
            this.barBtnUrunHareketleri,
            this.barbtnPersonelEkle,
            this.barbtnPersonelGruplari,
            this.barbtnPersonelListesi,
            this.barbtnPersonelHareketleri,
            this.barbtnTeminYerleri,
            this.barbtnUrunTurleri,
            this.barbtnTeminYeri,
            this.barbtnZimmetEkle,
            this.barbtnZimmetListesi,
            this.barbtnKullanici,
            this.barButtonItem1,
            this.txtAltKullanici,
            this.barbtnYoneticiIslemleri});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.QuickToolbarItemLinks.Add(this.barbtnKullanici);
            this.ribbon.Size = new System.Drawing.Size(710, 162);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnUrunEkle
            // 
            this.barBtnUrunEkle.Caption = "Ürün Ekle";
            this.barBtnUrunEkle.Id = 1;
            this.barBtnUrunEkle.ImageOptions.LargeImage = global::GFStokTakip.Properties.Resources.Stok_Kartı32x32;
            this.barBtnUrunEkle.Name = "barBtnUrunEkle";
            this.barBtnUrunEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUrunEkle_ItemClick);
            // 
            // barBtnUrunListesi
            // 
            this.barBtnUrunListesi.Caption = "Ürün Listesi";
            this.barBtnUrunListesi.Id = 2;
            this.barBtnUrunListesi.ImageOptions.LargeImage = global::GFStokTakip.Properties.Resources.Stok_Liste32x32;
            this.barBtnUrunListesi.Name = "barBtnUrunListesi";
            this.barBtnUrunListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUrunListesi_ItemClick);
            // 
            // barBtnUrunGruplari
            // 
            this.barBtnUrunGruplari.Caption = "Markalar";
            this.barBtnUrunGruplari.Id = 3;
            this.barBtnUrunGruplari.ImageOptions.LargeImage = global::GFStokTakip.Properties.Resources.Stok_Grup32x32;
            this.barBtnUrunGruplari.Name = "barBtnUrunGruplari";
            this.barBtnUrunGruplari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUrunGruplari_ItemClick);
            // 
            // barBtnUrunHareketleri
            // 
            this.barBtnUrunHareketleri.Caption = "Ürün Hareketleri";
            this.barBtnUrunHareketleri.Id = 4;
            this.barBtnUrunHareketleri.ImageOptions.LargeImage = global::GFStokTakip.Properties.Resources.Stok_Hareket32x32;
            this.barBtnUrunHareketleri.Name = "barBtnUrunHareketleri";
            this.barBtnUrunHareketleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUrunHareketleri_ItemClick);
            // 
            // barbtnPersonelEkle
            // 
            this.barbtnPersonelEkle.Caption = "Personel Ekle";
            this.barbtnPersonelEkle.Id = 5;
            this.barbtnPersonelEkle.ImageOptions.LargeImage = global::GFStokTakip.Properties.Resources.Cari_Kart32x32;
            this.barbtnPersonelEkle.Name = "barbtnPersonelEkle";
            this.barbtnPersonelEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnMusteriEkle_ItemClick);
            // 
            // barbtnPersonelGruplari
            // 
            this.barbtnPersonelGruplari.Caption = "Personel Departmanlari";
            this.barbtnPersonelGruplari.Id = 6;
            this.barbtnPersonelGruplari.ImageOptions.LargeImage = global::GFStokTakip.Properties.Resources.Cari_Grup32x32;
            this.barbtnPersonelGruplari.Name = "barbtnPersonelGruplari";
            this.barbtnPersonelGruplari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnMusteriGruplari_ItemClick);
            // 
            // barbtnPersonelListesi
            // 
            this.barbtnPersonelListesi.Caption = "Personel Listesi";
            this.barbtnPersonelListesi.Id = 7;
            this.barbtnPersonelListesi.ImageOptions.LargeImage = global::GFStokTakip.Properties.Resources.Cari_Liste32x32;
            this.barbtnPersonelListesi.Name = "barbtnPersonelListesi";
            this.barbtnPersonelListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnMusteriListesi_ItemClick);
            // 
            // barbtnPersonelHareketleri
            // 
            this.barbtnPersonelHareketleri.Caption = "Personel Hareketleri";
            this.barbtnPersonelHareketleri.Id = 8;
            this.barbtnPersonelHareketleri.ImageOptions.LargeImage = global::GFStokTakip.Properties.Resources.Cari_Hareket32x32;
            this.barbtnPersonelHareketleri.Name = "barbtnPersonelHareketleri";
            this.barbtnPersonelHareketleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnMusteriHareketleri_ItemClick);
            // 
            // barbtnTeminYerleri
            // 
            this.barbtnTeminYerleri.Caption = "Temin Yerleri";
            this.barbtnTeminYerleri.Id = 9;
            this.barbtnTeminYerleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnTeminYerleri.ImageOptions.Image")));
            this.barbtnTeminYerleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnTeminYerleri.ImageOptions.LargeImage")));
            this.barbtnTeminYerleri.Name = "barbtnTeminYerleri";
            this.barbtnTeminYerleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnTeminYerleri_ItemClick);
            // 
            // barbtnUrunTurleri
            // 
            this.barbtnUrunTurleri.Caption = "Ürün Türleri";
            this.barbtnUrunTurleri.Id = 10;
            this.barbtnUrunTurleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnUrunTurleri.ImageOptions.Image")));
            this.barbtnUrunTurleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnUrunTurleri.ImageOptions.LargeImage")));
            this.barbtnUrunTurleri.Name = "barbtnUrunTurleri";
            this.barbtnUrunTurleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnUrunTurleri_ItemClick);
            // 
            // barbtnTeminYeri
            // 
            this.barbtnTeminYeri.Caption = "Temin Yerleri";
            this.barbtnTeminYeri.Id = 11;
            this.barbtnTeminYeri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnTeminYeri.ImageOptions.Image")));
            this.barbtnTeminYeri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnTeminYeri.ImageOptions.LargeImage")));
            this.barbtnTeminYeri.Name = "barbtnTeminYeri";
            this.barbtnTeminYeri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnTeminYeri_ItemClick);
            // 
            // barbtnZimmetEkle
            // 
            this.barbtnZimmetEkle.Caption = "Zimmet Ekle";
            this.barbtnZimmetEkle.Id = 12;
            this.barbtnZimmetEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnZimmetEkle.ImageOptions.Image")));
            this.barbtnZimmetEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnZimmetEkle.ImageOptions.LargeImage")));
            this.barbtnZimmetEkle.Name = "barbtnZimmetEkle";
            this.barbtnZimmetEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnZimmetEkle_ItemClick);
            // 
            // barbtnZimmetListesi
            // 
            this.barbtnZimmetListesi.Caption = "Zimmet Listesi";
            this.barbtnZimmetListesi.Id = 13;
            this.barbtnZimmetListesi.ImageOptions.LargeImage = global::GFStokTakip.Properties.Resources.Banka_Liste32x32;
            this.barbtnZimmetListesi.Name = "barbtnZimmetListesi";
            this.barbtnZimmetListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnZimmetListesi_ItemClick);
            // 
            // barbtnKullanici
            // 
            this.barbtnKullanici.Caption = "barButtonItem1";
            this.barbtnKullanici.Id = 14;
            this.barbtnKullanici.Name = "barbtnKullanici";
            this.barbtnKullanici.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnKullanici_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Kullanıcı :";
            this.barButtonItem1.Id = 15;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // txtAltKullanici
            // 
            this.txtAltKullanici.Id = 16;
            this.txtAltKullanici.Name = "txtAltKullanici";
            // 
            // barbtnYoneticiIslemleri
            // 
            this.barbtnYoneticiIslemleri.Caption = "Yönetici İşlemleri";
            this.barbtnYoneticiIslemleri.Id = 17;
            this.barbtnYoneticiIslemleri.ImageOptions.LargeImage = global::GFStokTakip.Properties.Resources.Senet_Bordro32x32;
            this.barbtnYoneticiIslemleri.Name = "barbtnYoneticiIslemleri";
            this.barbtnYoneticiIslemleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnYoneticiIslemleri_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = global::GFStokTakip.Properties.Resources.Stok32x32;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Stok İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnUrunEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnUrunListesi);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnUrunGruplari);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnUrunTurleri);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnTeminYeri);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Stok İşlemleri";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.ImageOptions.Image = global::GFStokTakip.Properties.Resources.Cari32x32;
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Personel İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnPersonelEkle);
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnPersonelGruplari);
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnPersonelListesi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Personel İşlemleri";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.ImageOptions.Image = global::GFStokTakip.Properties.Resources.FireFox32x32;
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Zimmet İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtnZimmetEkle);
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtnZimmetListesi);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Zimmet İşlemleri";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Yönetici İşlemleri";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barbtnYoneticiIslemleri);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Yönetici İşlemleri";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.txtAltKullanici);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(710, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnUrunEkle;
        private DevExpress.XtraBars.BarButtonItem barBtnUrunListesi;
        private DevExpress.XtraBars.BarButtonItem barBtnUrunGruplari;
        private DevExpress.XtraBars.BarButtonItem barBtnUrunHareketleri;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barbtnPersonelEkle;
        private DevExpress.XtraBars.BarButtonItem barbtnPersonelGruplari;
        private DevExpress.XtraBars.BarButtonItem barbtnPersonelListesi;
        private DevExpress.XtraBars.BarButtonItem barbtnPersonelHareketleri;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barbtnTeminYerleri;
        private DevExpress.XtraBars.BarButtonItem barbtnUrunTurleri;
        private DevExpress.XtraBars.BarButtonItem barbtnTeminYeri;
        private DevExpress.XtraBars.BarButtonItem barbtnZimmetEkle;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barbtnZimmetListesi;
        private DevExpress.XtraBars.BarButtonItem barbtnKullanici;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem txtAltKullanici;
        private DevExpress.XtraBars.BarButtonItem barbtnYoneticiIslemleri;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}
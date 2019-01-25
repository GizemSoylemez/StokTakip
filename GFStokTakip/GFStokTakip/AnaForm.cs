using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace GFStokTakip
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        public static Fonksiyonlar.TBL_Personeller Kullanici;
        public static int UserID = -1;
        public static int Aktarma = -1;
        public AnaForm()
        {
            InitializeComponent();
        }
        public AnaForm(Fonksiyonlar.TBL_Personeller GelenKullanici)
        {
            InitializeComponent();
            Kullanici = GelenKullanici;
            UserID = Kullanici.ID;
            txtAltKullanici.Caption = Kullanici.PersonelAdiSoyadi;
            if(Kullanici.PersonelRutbe=="Bölüm Sorumlusu")
            {
                barbtnKullanici.Visibility = BarItemVisibility.Never;
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void barBtnUrunEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.UrunKarti();
        }

        private void barBtnUrunListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.UrunListesi();
        }

        private void barBtnUrunGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.UrunMarkalari();
        }

        private void barBtnUrunHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.UrunHareketleri();
        }

        private void barbtnMusteriEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.PersonelEkle();
        }

        private void barbtnMusteriGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.Departmanlar();
        }

        private void barbtnMusteriListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.PersonelListesi();
        }

        private void barbtnMusteriHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barbtnTeminYerleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.UrunTeminleri();
        }

        private void barbtnUrunTurleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.UrunTurleri();
        }

        private void barbtnTeminYeri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.UrunTeminleri();
        }

        private void barbtnZimmetEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.ZimmetEkle();
        }

        private void barbtnZimmetListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.ZimmetListesi();
        }

        private void barbtnKullanici_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KullaniciYonetimi();
        }

        private void barbtnYoneticiIslemleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KullaniciYonetimi();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GFStokTakip.Modul_Zimmet
{
    public partial class frmZimmetIadeEkle : DevExpress.XtraEditors.XtraForm
    {
        bool Edit = false;
        int IadeID = -1;
        int DepartmanID = -1;
        int PersonelID = -1;
        int UrunID = -1;
        Fonksiyonlar.DataBaseDataContext DB = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        public frmZimmetIadeEkle()
        {
            InitializeComponent();
            if (AnaForm.Kullanici.PersonelRutbe == "Bölüm Sorumlusu")
            {
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
        }

        private void frmZimmetIadeEkle_Load(object sender, EventArgs e)
        {

        }

        void Temizle()
        {
            txtPersonelAdi.Text = "";
            txtPersonelKodu.Text = "";;
            txtIadeNedeni.Text = "";
            txtTeslimTarihi.Text = "";
            txtUrunAdi.Text = "";
            txtUrunKodu.Text = "";
            txtIadeNedeniKodu.Text = "";
            
            UrunID = -1;
            PersonelID = -1;
            IadeID = -1;
            DepartmanID = -1;
            Edit = false;
            AnaForm.Aktarma = -1;
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_ZimmetHata Zimmet = new Fonksiyonlar.TBL_ZimmetHata();
                Zimmet.HataAciklama = txtIadeAciklamasi.Text;
                Zimmet.UrunID = UrunID;
                Zimmet.PersonelID = PersonelID;
                Zimmet.ZimmetID = IadeID;
                Zimmet.IadeTarihi = DateTime.Parse(txtTeslimTarihi.Text);
                
                Zimmet.SaveDate = DateTime.Now;
                Zimmet.SaveUser = AnaForm.UserID;

                DB.TBL_ZimmetHatas.InsertOnSubmit(Zimmet);
                DB.SubmitChanges();
                Fonksiyonlar.TBL_Urunler Urun = DB.TBL_Urunlers.First(s => s.ID == UrunID);
                Urun.UrunStokMiktari = Urun.UrunStokMiktari + 1;
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Zimmet Hata Kaydı Oluşturuldu");
                Temizle();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_ZimmetHata Zimmet = DB.TBL_ZimmetHatas.First(s => s.ID == IadeID);
                Zimmet.HataAciklama = txtIadeAciklamasi.Text;
                Zimmet.UrunID = UrunID;
                Zimmet.PersonelID = PersonelID;
                Zimmet.ZimmetID = IadeID;
                Zimmet.IadeTarihi = DateTime.Parse(txtTeslimTarihi.Text);
                Zimmet.EditDate = DateTime.Now;
                Zimmet.EditUser = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }
        void Sil()
        {
            try
            {
                DB.TBL_ZimmetHatas.DeleteOnSubmit(DB.TBL_ZimmetHatas.First(s => s.ID == IadeID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        public void Ac(int ID)
        {
            Edit = true;
            IadeID = ID;
            Fonksiyonlar.TBL_ZimmetHata Zimmet = DB.TBL_ZimmetHatas.First(s => s.ID == IadeID);
            PersonelAc(Zimmet.PersonelID.Value);
            UrunAc(Zimmet.UrunID.Value);
            ZimmetAc(Zimmet.ZimmetID.Value);
            txtTeslimTarihi.Text = Zimmet.IadeTarihi.ToString();
            txtIadeAciklamasi.Text = Zimmet.HataAciklama;


        }
        void PersonelAc(int ID)
        {
            PersonelID = ID;
            txtPersonelAdi.Text = DB.TBL_Personellers.First(s => s.ID == PersonelID).PersonelAdiSoyadi;
            txtPersonelKodu.Text = DB.TBL_Personellers.First(s => s.ID == PersonelID).PersonelKodu;
        }
        void UrunAc(int ID)
        {
            UrunID = ID;
            txtUrunAdi.Text = DB.TBL_Urunlers.First(s => s.ID == UrunID).UrunAdi;
            txtPersonelKodu.Text = DB.TBL_Urunlers.First(s => s.ID == UrunID).UrunKodu;
        }
        void ZimmetAc(int ID)
        {
            IadeID = ID;
            txtUrunAdi.Text = DB.TBL_ZimmetIadeNedens.First(s => s.ID == IadeID).ZimmetIadeNeden;
            txtPersonelKodu.Text = DB.TBL_ZimmetIadeNedens.First(s => s.ID == IadeID).ZimmetIadeKodu;
        }

        private void txtIadeNedeniKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.ZimmetHataListesi(true);
            if (ID > 0)
            {
                UrunAc(ID);

            }
            AnaForm.Aktarma = -1;
        }

        private void txtUrunKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.UrunListesi(true);
            if (ID > 0)
            {
                UrunAc(ID);

            }
            AnaForm.Aktarma = -1;
        }

        private void txtPersonelKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.PersonelListesi(true);
            if (ID > 0)
            {
                PersonelAc(ID);

            }
            AnaForm.Aktarma = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtIadeNedeniKodu.Text != "" && txtPersonelKodu.Text != "" && txtTeslimTarihi.Text != "" && txtUrunKodu.Text != "")
            {
                if (Edit && IadeID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
                else
                    YeniKaydet();
            }
            else
                MessageBox.Show("Boş Değer Girmeyiniz");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && IadeID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTeslimTarihi_EditValueChanged(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            if (Convert.ToDateTime(txtTeslimTarihi.Text.ToString()) >= d)
            {
                MessageBox.Show("Bugünkü tarihten büyük olamaz.");
            }
        }
    }
}
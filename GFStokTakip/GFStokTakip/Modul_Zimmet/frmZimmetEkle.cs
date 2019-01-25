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
    public partial class frmZimmetEkle : DevExpress.XtraEditors.XtraForm
    {
        bool Edit = false;
        int PersonelID = -1;
        int UrunID = -1;
        int ZimmetID = -1;
        int DepartmanID = -1;
        Fonksiyonlar.DataBaseDataContext DB = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        public frmZimmetEkle()
        {
            InitializeComponent();
            if (AnaForm.Kullanici.PersonelRutbe == "Bölüm Sorumlusu")
            {
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
        }

        private void frmZimmetEkle_Load(object sender, EventArgs e)
        {
            txtZimmetKodu.Text = Numara.ZimmetKodNumarasi();
        }

        void Temizle()
        {
            txtPersonelAdi.Text = "";
            txtPersonelKodu.Text = "";
            txtStokSayisi.Text = "";
            txtTeslimTarihi.Text = "";
            txtUrunAdi.Text = "";
            txtUrunKodu.Text = "";
            txtZimmetKodu.Text = Numara.ZimmetKodNumarasi();
            UrunID = -1;
            PersonelID = -1;
            ZimmetID = -1;
            DepartmanID = -1;
            Edit = false;
            AnaForm.Aktarma = -1;
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_Zimmetler Zimmet = new Fonksiyonlar.TBL_Zimmetler();
                Zimmet.TeslimTarihi = DateTime.Parse(txtTeslimTarihi.Text);
                Zimmet.ZimmetKodu = txtZimmetKodu.Text;
                Zimmet.UrunID = UrunID;
                Zimmet.PersonelID = PersonelID;
                Zimmet.DepartmanID = DepartmanID;
                Zimmet.SaveDate = DateTime.Now;
                Zimmet.SaveUser = AnaForm.UserID;

                DB.TBL_Zimmetlers.InsertOnSubmit(Zimmet);
                DB.SubmitChanges();
                Fonksiyonlar.TBL_Urunler Urun = DB.TBL_Urunlers.First(s => s.ID == UrunID);
                Urun.UrunStokMiktari = Urun.UrunStokMiktari - 1;
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Zimmet Kaydı Oluşturuldu");
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
                Fonksiyonlar.TBL_Zimmetler Zimmet = DB.TBL_Zimmetlers.First(s => s.ID == ZimmetID);
                Zimmet.TeslimTarihi = DateTime.Parse(txtTeslimTarihi.Text);
                Zimmet.ZimmetKodu = txtZimmetKodu.Text;
                Zimmet.UrunID = UrunID;
                Zimmet.PersonelID = PersonelID;
                Zimmet.DepartmanID = DepartmanID;
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
                DB.TBL_Zimmetlers.DeleteOnSubmit(DB.TBL_Zimmetlers.First(s => s.ID == ZimmetID));
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
            ZimmetID = ID;
            Fonksiyonlar.TBL_Zimmetler Zimmet = DB.TBL_Zimmetlers.First(s => s.ID == ZimmetID);
            PersonelAc(Zimmet.PersonelID.Value);
            UrunAc(Zimmet.UrunID.Value);
            DepartmanAc(Zimmet.DepartmanID.Value);
            txtTeslimTarihi.Text = Zimmet.TeslimTarihi.ToString();
            txtZimmetKodu.Text = Zimmet.ZimmetKodu;


        }
        void PersonelAc(int ID)
        {
            PersonelID = ID;
            txtPersonelAdi.Text = DB.TBL_Personellers.First(s => s.ID == PersonelID).PersonelAdiSoyadi;
            txtPersonelKodu.Text = DB.TBL_Personellers.First(s => s.ID == PersonelID).PersonelKodu;
        }

        void DepartmanAc(int ID)
        {
            DepartmanID = ID;
            txtDepartmanAdi.Text = DB.TBL_Departmanlars.First(s => s.ID == DepartmanID).DepartmanAdi;
            txtDepartmanKodu.Text = DB.TBL_Departmanlars.First(s => s.ID == DepartmanID).DepartmanKodu;
        }

        void UrunAc(int ID)
        {
            UrunID = ID;
            txtUrunAdi.Text = DB.TBL_Urunlers.First(s => s.ID == UrunID).UrunAdi;
            txtUrunKodu.Text = DB.TBL_Urunlers.First(s => s.ID == UrunID).UrunKodu;
            txtStokSayisi.Text = DB.TBL_Urunlers.First(s => s.ID == UrunID).UrunStokMiktari.ToString();
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
            if (txtDepartmanKodu.Text != "" && txtPersonelKodu.Text != "" && txtUrunKodu.Text != "" && txtTeslimTarihi.Text != "" && txtStokSayisi.Text != "")
            {
                if (Edit && ZimmetID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
                else
                    YeniKaydet();
            }
            else
                MessageBox.Show("Boş Alan Bırakmayınız");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && ZimmetID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDepartmanKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.DepartmanListesi(true);
            if (ID > 0)
            {
                DepartmanAc(ID);

            }
            AnaForm.Aktarma = -1;
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
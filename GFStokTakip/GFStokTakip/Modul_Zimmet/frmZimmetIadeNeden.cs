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
    public partial class frmZimmetIadeNeden : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext db = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        int SecimID = -1;
        bool Edit = false;

        public frmZimmetIadeNeden()
        {
            InitializeComponent();
            if (AnaForm.Kullanici.PersonelRutbe == "Bölüm Sorumlusu")
            {
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
        }

        private void frmZimmetIadeNeden_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in db.TBL_ZimmetIadeNedens
                      select s;
            liste.DataSource = lst;
        }

        void Temizle()
        {
            txtNedenAdi.Text = "";
            txtNedenKodu.Text = "";
            Edit = false;
            Listele();
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_ZimmetIadeNeden ZimmetNeden = new Fonksiyonlar.TBL_ZimmetIadeNeden();
                ZimmetNeden.ZimmetIadeNeden = txtNedenAdi.Text;
                ZimmetNeden.ZimmetIadeKodu = txtNedenKodu.Text;
                ZimmetNeden.SaveDate = DateTime.Now;
                ZimmetNeden.SaveUser = AnaForm.UserID;
                db.TBL_ZimmetIadeNedens.InsertOnSubmit(ZimmetNeden);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Marka Kaydı Oluşturuldu.");
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }

        }
        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_ZimmetIadeNeden ZimmetNeden = db.TBL_ZimmetIadeNedens.First(s => s.ID == SecimID);
                ZimmetNeden.ZimmetIadeNeden = txtNedenAdi.Text;
                ZimmetNeden.ZimmetIadeKodu = txtNedenKodu.Text;
                ZimmetNeden.EditUser = AnaForm.UserID;
                ZimmetNeden.EditDate = DateTime.Now;
                db.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }

        }
        void Sil()
        {
            try
            {
                db.TBL_ZimmetIadeNedens.DeleteOnSubmit(db.TBL_ZimmetIadeNedens.First(s => s.ID == SecimID));
                db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtNedenAdi.Text = gridView1.GetFocusedRowCellValue("ZimmetIadeNeden").ToString();
                txtNedenKodu.Text = gridView1.GetFocusedRowCellValue("ZimmetIadeKodu").ToString();
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtNedenAdi.Text != "" && txtNedenKodu.Text != "")
            {
                if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
                else
                    YeniKaydet();
            }
            else
                MessageBox.Show("Boş Değer Girmeyiniz.");
        }
    }
}
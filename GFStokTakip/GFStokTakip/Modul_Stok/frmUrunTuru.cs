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

namespace GFStokTakip.Modul_Stok
{
    public partial class frmUrunTuru : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext db = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        int SecimID = -1;
        bool Edit = false;

        public frmUrunTuru()
        {
            InitializeComponent();
            if (AnaForm.Kullanici.PersonelRutbe == "Bölüm Sorumlusu")
            {
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
        }

        private void frmUrunTuru_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in db.TBL_UrunTurus
                      select s;
            liste.DataSource = lst;
        }

        void Temizle()
        {
            txtUrunTuruAdi.Text = "";
            txtUrunTuruKodu.Text = "";
            Edit = false;
            Listele();
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_UrunTuru UrunTuru = new Fonksiyonlar.TBL_UrunTuru();
                UrunTuru.UrunTuruAdi = txtUrunTuruAdi.Text;
                UrunTuru.UrunTuruKodu = txtUrunTuruKodu.Text;
                UrunTuru.UrunTuruSaveDate = DateTime.Now;
                UrunTuru.UrunTuruSaveUser = AnaForm.UserID;
                db.TBL_UrunTurus.InsertOnSubmit(UrunTuru);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Ürün Türü Kaydı Oluşturuldu.");
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
                Fonksiyonlar.TBL_UrunTuru UrunTuru = db.TBL_UrunTurus.First(s => s.ID == SecimID);
                UrunTuru.UrunTuruAdi = txtUrunTuruAdi.Text;
                UrunTuru.UrunTuruKodu = txtUrunTuruKodu.Text;
                UrunTuru.UrunTuruEditUser = AnaForm.UserID;
                UrunTuru.UrunTuruEditDate = DateTime.Now;
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
                db.TBL_UrunTurus.DeleteOnSubmit(db.TBL_UrunTurus.First(s => s.ID == SecimID));
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
                txtUrunTuruAdi.Text = gridView1.GetFocusedRowCellValue("UrunTuruAdi").ToString();
                txtUrunTuruKodu.Text = gridView1.GetFocusedRowCellValue("UrunTuruKodu").ToString();
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
            if (txtUrunTuruAdi.Text != "" && txtUrunTuruKodu.Text != "")
            {
                if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
                else
                    YeniKaydet();
            }
            else
                MessageBox.Show("Gerekli Alanları Doldurunuz");
        }
    }
}
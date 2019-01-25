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
    public partial class frmUrunTeminleri : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext db = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        int SecimID = -1;
        bool Edit = false;

        public frmUrunTeminleri()
        {
            InitializeComponent();
            if (AnaForm.Kullanici.PersonelRutbe == "Bölüm Sorumlusu")
            {
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
        }

        private void frmUrunTeminleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in db.TBL_Temins
                      select s;
            liste.DataSource = lst;
        }

        void Temizle()
        {
            txtTeminAdi.Text = "";
            txtTeminKodu.Text = "";
            Edit = false;
            Listele();
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_Temin Temin = new Fonksiyonlar.TBL_Temin();
                Temin.TeminAdi = txtTeminAdi.Text;
                Temin.TeminKodu = txtTeminKodu.Text;
                Temin.TeminSaveDate = DateTime.Now;
                Temin.TeminSaveUser = AnaForm.UserID;
                db.TBL_Temins.InsertOnSubmit(Temin);
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
                Fonksiyonlar.TBL_Temin Temin = db.TBL_Temins.First(s => s.ID == SecimID);
                Temin.TeminAdi = txtTeminAdi.Text;
                Temin.TeminKodu = txtTeminKodu.Text;
                Temin.TeminEditUser = AnaForm.UserID;
                Temin.TeminEditDate = DateTime.Now;
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
                db.TBL_Temins.DeleteOnSubmit(db.TBL_Temins.First(s => s.ID == SecimID));
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
                txtTeminAdi.Text = gridView1.GetFocusedRowCellValue("TeminAdi").ToString();
                txtTeminKodu.Text = gridView1.GetFocusedRowCellValue("TeminKodu").ToString();
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
            if (txtTeminAdi.Text != "" && txtTeminKodu.Text != "")
            {
                if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
                else
                    YeniKaydet();
            }
            else
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz");
        }
    }
}
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
using System.Data.Linq;

namespace GFStokTakip.Modul_Stok
{
    public partial class frmUrunMarkalari : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext db = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        int SecimID = -1;
        bool Edit = false;


        public frmUrunMarkalari()
        {
            InitializeComponent();
            if (AnaForm.Kullanici.PersonelRutbe == "Bölüm Sorumlusu")
            {
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
        }

        private void frmUrunGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in db.TBL_UrunMarkas
                      select s;
            liste.DataSource = lst;
        }

        void Temizle()
        {
            txtMarkaAdi.Text = "";
            txtMarkaKodu.Text = "";
            Edit = false;
            Listele();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_UrunMarka Marka = new Fonksiyonlar.TBL_UrunMarka();
                Marka.MarkaAdi = txtMarkaAdi.Text;
                Marka.MarkaKodu = txtMarkaKodu.Text;
                Marka.MarkaSaveDate = DateTime.Now;
                Marka.MarkaSaveUser = AnaForm.UserID;
                db.TBL_UrunMarkas.InsertOnSubmit(Marka);
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
                Fonksiyonlar.TBL_UrunMarka Marka = db.TBL_UrunMarkas.First(s => s.ID == SecimID);
                Marka.MarkaAdi = txtMarkaAdi.Text;
                Marka.MarkaKodu = txtMarkaKodu.Text;
                Marka.MarkaEditUser = AnaForm.UserID;
                Marka.MarkaEditDate = DateTime.Now;
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
                db.TBL_UrunMarkas.DeleteOnSubmit(db.TBL_UrunMarkas.First(s => s.ID == SecimID));
                db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
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
            if (txtMarkaAdi.Text != "" && txtMarkaKodu.Text != "")
            {
                if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
                else
                    YeniKaydet();
            }
            else
                MessageBox.Show("Gerekli Alanları Doldurunuz");
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtMarkaAdi.Text = gridView1.GetFocusedRowCellValue("MarkaAdi").ToString();
                txtMarkaKodu.Text = gridView1.GetFocusedRowCellValue("MarkaKodu").ToString();
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
            if(Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}
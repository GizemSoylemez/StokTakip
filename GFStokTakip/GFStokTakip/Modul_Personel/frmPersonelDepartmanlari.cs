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

namespace GFStokTakip.Modul_Musteri
{
    public partial class frmMusteriGruplari : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext DB = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        public bool Secim = false;
        bool Edit = false;
        int SecimID = -1;

        public frmMusteriGruplari()
        {
            InitializeComponent();
            if (AnaForm.Kullanici.PersonelRutbe == "Bölüm Sorumlusu")
            {
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }

        }

        void Temizle()
        {
            txtDepartmanAdi.Text = "";
            txtDepartmanKodu.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_Departmanlars
                      select s;
            liste.DataSource = lst;
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtDepartmanAdi.Text = gridView1.GetFocusedRowCellValue("DepartmanAdi").ToString();
                txtDepartmanKodu.Text = gridView1.GetFocusedRowCellValue("DepartmanKodu").ToString();

            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_Departmanlar Departman = new Fonksiyonlar.TBL_Departmanlar();
                Departman.DepartmanAdi = txtDepartmanAdi.Text;
                Departman.DepartmanKodu = txtDepartmanKodu.Text;
                Departman.SaveDate = DateTime.Now;
                Departman.SaveUser = AnaForm.UserID;
                DB.TBL_Departmanlars.InsertOnSubmit(Departman);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Departman Kaydı Oluşturuldu");
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
                Fonksiyonlar.TBL_Departmanlar Departman = DB.TBL_Departmanlars.First(s => s.ID == SecimID);
                Departman.DepartmanAdi = txtDepartmanAdi.Text;
                Departman.DepartmanKodu = txtDepartmanKodu.Text;
                Departman.EditDate = DateTime.Now;
                Departman.EditUser = AnaForm.UserID;
                DB.SubmitChanges();
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
                DB.TBL_Departmanlars.DeleteOnSubmit(DB.TBL_Departmanlars.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtDepartmanAdi.Text != "" && txtDepartmanKodu.Text != "")
            {
                if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
                else
                    YeniKaydet();
            }
            else
                MessageBox.Show("Boş Değer Girmeyiniz.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMusteriGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimID >0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}
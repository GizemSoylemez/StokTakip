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

namespace GFStokTakip.Modul_Kullanicilar
{
    public partial class frmKullaniciYonetimi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext DB = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        int secim = -1;
        public frmKullaniciYonetimi()
        {
            InitializeComponent();
            this.Shown += frmKullaniciYonetimi_Shown;
        }
        void Listele()
        {
            var lst = from s in DB.TBL_Personellers
                      where s.PersonelRutbe.Contains("Admin") || s.PersonelRutbe.Contains("Yetkili") || s.PersonelRutbe.Contains("Bölüm Sorumlusu")
                      select s;
            gridControl1.DataSource = lst;
        }
        private void frmKullaniciYonetimi_Shown(object sender, EventArgs e)
        {
            Listele();
        }

        private void frmKullaniciYonetimi_Load(object sender, EventArgs e)
        {

        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            Formlar.PersonelEkle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Formlar.PersonelEkle(true, secim);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Mesajlar.Sil()==DialogResult.Yes)
            DB.TBL_Personellers.DeleteOnSubmit(DB.TBL_Personellers.First(s => s.ID == secim));
            DB.SubmitChanges();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            secim = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            Formlar.PersonelEkle(true, secim);
            Listele();
        }
    }
}
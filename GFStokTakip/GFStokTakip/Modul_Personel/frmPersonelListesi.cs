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
    public partial class frmMusteriListesi : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        int SecimID = -1;
        Fonksiyonlar.DataBaseDataContext DB = new Fonksiyonlar.DataBaseDataContext();
        public frmMusteriListesi()
        {
            InitializeComponent();
        }

        private void frmMusteriListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in DB.TBL_Personellers
                      where s.PersonelAdiSoyadi.Contains(txtPersonelAdi.Text) && s.PersonelKodu.Contains(txtPersonelKodu.Text) && s.PersonelKullaniciAdi.Contains(txtDepartman.Text)
                      select s;
            Liste.DataSource = lst;
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {
                SecimID = -1;
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
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
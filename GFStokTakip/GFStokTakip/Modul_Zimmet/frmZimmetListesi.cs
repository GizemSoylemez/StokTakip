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
    public partial class frmZimmetListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext DB = new Fonksiyonlar.DataBaseDataContext();
        public bool Secim = false;
        int secimID = -1;
        public frmZimmetListesi()
        {
            InitializeComponent();
        }

        private void frmZimmetListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.VW_ZimmetListesis
                      where s.UrunAdi.Contains(txtUrunAdi.Text) && s.PersonelAdiSoyadi.Contains(txtPersonelAdi.Text) && s.DepartmanAdi.Contains(txtDepartman.Text)
                      select s;
            Liste.DataSource = lst;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtDepartman.Text = "";
            txtPersonelAdi.Text = "";
            txtUrunAdi.Text = "";
        }

        void Sec()
        {
            try
            {
                secimID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {
                secimID = -1;
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && secimID > 0)
            {
                AnaForm.Aktarma = secimID;
                this.Close();
            }
        }
    }
}
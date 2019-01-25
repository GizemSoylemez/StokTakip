using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Data.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GFStokTakip.Modul_Stok
{
    public partial class frmUrunListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext DB = new Fonksiyonlar.DataBaseDataContext();
        public bool Secim = false;
        int secimID = -1;
        public frmUrunListesi()
        {
            InitializeComponent();
        }

        private void frmUrunListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_Urunlers
                      where s.UrunAdi.Contains(txtUrunAdi.Text) && s.UrunBarkod.Contains(txtBarkod.Text) && s.UrunKodu.Contains(txtUrunKodu.Text)
                      select s;
            Liste.DataSource = lst;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtBarkod.Text = "";
            txtUrunKodu.Text = "";
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
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && secimID >0)
            {
                AnaForm.Aktarma = secimID;
                this.Close();
            }
        }

        private void btnPDFYazdir_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "Acrobat Reader|*.pdf";
                if(sf.ShowDialog()==DialogResult.OK)
                {
                    Liste.ExportToPdf(sf.FileName);
                }
            }
        }

        private void btnXLSYazdir_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "Acrobat Reader|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    Liste.ExportToXls(sf.FileName);
                }
            }
        }
    }
}
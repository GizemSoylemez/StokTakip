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
using System.Reflection;
using DevExpress.XtraReports.UI;

namespace GFStokTakip.Modul_Stok
{
    public partial class frmUrunEkle : DevExpress.XtraEditors.XtraForm
    {
        bool Edit = false;
        int MarkaID = -1;
        int UrunID = -1;
        int TeminID = -1;
        int UrunTuruID = -1;
        Fonksiyonlar.DataBaseDataContext DB = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        public frmUrunEkle()
        {
            InitializeComponent();
            if(AnaForm.Kullanici.PersonelRutbe=="Bölüm Sorumlusu")
            {
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
             txtUrunKodu.Text = Numara.UrunKodNumarasi();
        }
        void Temizle()
        {
            txtUrunKodu.Text = Numara.UrunKodNumarasi();
            txtAciklama.Text = "";
            txtAlisFiyati.Text = "";
            txtBarkod.Text = "";
            txtMarkaAdi.Text = "";
            txtMarkaKodu.Text = "";
            txtStokMiktari.Text = "";
            txtSubeAdi.Text = "";
            txtTeminKodu.Text = "";
            txtUrunAdi.Text = "";
            txtUrunTuruAdi.Text = "";
            txtUrunTuruKodu.Text = "";
            Edit = false;
            MarkaID = -1;
            UrunID = -1;
            AnaForm.Aktarma = -1;
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_Urunler Urun = new Fonksiyonlar.TBL_Urunler();
                Urun.UrunAdi = txtUrunAdi.Text;
                Urun.UrunAlisFiyat = decimal.Parse(txtAlisFiyati.Text);
                Urun.UrunAlisTarihi = Convert.ToDateTime(txtAlisTarihi.Text);
                Urun.UrunBarkod = txtBarkod.Text;
                Urun.UrunKodu = txtUrunKodu.Text;
                Urun.UrunStokMiktari = int.Parse(txtStokMiktari.Text);
                Urun.UrunTuruAciklama = txtAciklama.Text;
                Urun.UrunSaveDate = DateTime.Now;
                Urun.UrunSaveUser = AnaForm.UserID;
                Urun.UrunTeminSubeAdi = txtSubeAdi.Text;
                Urun.UrunTuruID = UrunTuruID;
                Urun.UrunTeminID = TeminID;
                Urun.UrunMarkaID = MarkaID;
                
                DB.TBL_Urunlers.InsertOnSubmit(Urun);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Ürün Kaydı Oluşturuldu");
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
                Fonksiyonlar.TBL_Urunler Urun = DB.TBL_Urunlers.First(s => s.ID == UrunID);
                Urun.UrunAdi = txtUrunAdi.Text;
                Urun.UrunAlisFiyat = decimal.Parse(txtAlisFiyati.Text);
                Urun.UrunAlisTarihi = Convert.ToDateTime(txtAlisTarihi.Text);
                Urun.UrunBarkod = txtBarkod.Text;
                Urun.UrunKodu = txtUrunKodu.Text;
                Urun.UrunStokMiktari = int.Parse(txtStokMiktari.Text);
                Urun.UrunTuruAciklama = txtAciklama.Text;
                Urun.UrunEditDate = DateTime.Now;
                Urun.UrunEditUser = AnaForm.UserID;
                Urun.UrunTeminSubeAdi = txtSubeAdi.Text;
                Urun.UrunTuruID = UrunTuruID;
                Urun.UrunTeminID = TeminID;
                Urun.UrunMarkaID = MarkaID;
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
               DB.TBL_Urunlers.DeleteOnSubmit(DB.TBL_Urunlers.First(s => s.ID == UrunID));
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
            UrunID = ID;
            Fonksiyonlar.TBL_Urunler Urun = DB.TBL_Urunlers.First(s => s.ID == UrunID);
            MarkaAc(Urun.UrunMarkaID.Value);
            TeminAc(Urun.UrunTeminID.Value);
            UrunTuruAc(Urun.UrunTuruID.Value);
            txtAciklama.Text = Urun.UrunTuruAciklama.ToString();
            txtAlisFiyati.Text = Urun.UrunAlisFiyat.ToString();
            txtAlisTarihi.Text = Urun.UrunAlisTarihi.ToString();
            txtBarkod.Text = Urun.UrunBarkod.ToString();
            txtStokMiktari.Text = Urun.UrunStokMiktari.ToString();
            txtSubeAdi.Text = Urun.UrunTeminSubeAdi.ToString();
            txtUrunAdi.Text = Urun.UrunAdi.ToString();
            txtUrunKodu.Text = Urun.UrunKodu.ToString();
            
            
        }

        void MarkaAc(int ID)
        {
            MarkaID = ID;
            txtMarkaAdi.Text = DB.TBL_UrunMarkas.First(s => s.ID == MarkaID).MarkaAdi;
            txtMarkaKodu.Text = DB.TBL_UrunMarkas.First(s => s.ID == MarkaID).MarkaKodu;
        }

        void TeminAc(int ID)
        {
            TeminID = ID;
            txtTeminYeriAdi.Text = DB.TBL_Temins.First(s => s.ID == TeminID).TeminAdi;
            txtTeminKodu.Text = DB.TBL_Temins.First(s => s.ID == TeminID).TeminKodu;
        }

        void UrunTuruAc(int ID)
        {
            UrunTuruID = ID;
            txtUrunTuruAdi.Text = DB.TBL_UrunTurus.First(s => s.ID == UrunTuruID).UrunTuruAdi;
            txtUrunTuruKodu.Text = DB.TBL_UrunTurus.First(s => s.ID == UrunTuruID).UrunTuruKodu;
        }
        

        private void txtUrunKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.UrunListesi(true);
            if(ID >0)
            {
                Ac(ID);
                
            }
            AnaForm.Aktarma = -1;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && UrunID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunKodu.Text != "" && txtUrunTuruKodu.Text != "" && txtTeminKodu.Text != "" && txtMarkaKodu.Text != "" && txtAlisFiyati.Text != "" && txtAlisTarihi.Text != "" && txtStokMiktari.Text != "")
            {
                if (Edit && UrunID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
                else
                    YeniKaydet();
            }
            else
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz.");
        }

        private void txtMarkaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.UrunMarkalari(true);
            if (ID > 0)
            {
                MarkaAc(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void txtUrunTuruKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.UrunTurleri(true);
            if (ID > 0)
            {
                UrunTuruAc(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void txtTeminKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.UrunTeminleri(true);
            if (ID > 0)
            {
                TeminAc(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            var srg = DB.VW_Urunlers.Where(s => s.UrunKodu == txtUrunKodu.Text);
            DataSet ds = new DataSet();
            ds.Tables.Add(LINQToDataTable(srg));

            UrunYazdir rpr = new UrunYazdir();
            rpr.DataSource = ds;
            rpr.ShowPreview();
        }

        public DataTable LINQToDataTable<T>(IEnumerable<T> Lnqlst)
        {
            DataTable dt = new DataTable();


            PropertyInfo[] columns = null;

            if (Lnqlst == null) return dt;

            foreach (T Record in Lnqlst)
            {

                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }

                DataRow dr = dt.NewRow();

                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
                    (Record, null);
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void txtAlisTarihi_EditValueChanged(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            if (Convert.ToDateTime(txtAlisTarihi.Text.ToString()) >= d)
            {
                MessageBox.Show("Bugünkü tarihten büyük olamaz.");
            }
        }

        private void txtAlisFiyati_EditValueChanged(object sender, EventArgs e)
        {
            if(txtAlisFiyati.Properties.MaxLength >= 6)
            {
                MessageBox.Show("Çok Uzun Bir Değer Girdiniz");
                txtAlisFiyati.Text = "";
            }
        }

        private void txtAlisFiyati_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != null)
                if (e.NewValue.ToString().Length > 10)
                {
                    e.Cancel = true;
                    MessageBox.Show("Çok Uzun Bir Değer Girdiniz");
                    txtAlisFiyati.Text = "";
                }
                
        }
    }
}
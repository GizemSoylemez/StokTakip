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
    public partial class frmMusteriEkle : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext DB = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        bool Edit = false;
        int PersonelID = -1;
        int DepartmanID = -1;
        string SorumluDepartmanID = "";
        public frmMusteriEkle()
        {
            InitializeComponent();
            if (AnaForm.Kullanici.PersonelRutbe == "Bölüm Sorumlusu")
            {
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {
            txtPersonelKodu.Text = Numara.MusteriKodNumarasi();
            
        }

        void Temizle()
        {
            foreach (Control CT in groupControl1.Controls)
                if (CT is DevExpress.XtraEditors.TextEdit || CT is DevExpress.XtraEditors.ButtonEdit) CT.Text = "";

            foreach (Control CE in groupControl2.Controls)
                if (CE is DevExpress.XtraEditors.TextEdit || CE is DevExpress.XtraEditors.ButtonEdit || CE is DevExpress.XtraEditors.MemoEdit) CE.Text = "";
            Edit = false;
            txtPersonelKodu.Text = Numara.MusteriKodNumarasi();
            PersonelID = -1;
            DepartmanID = -1;
            AnaForm.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_Personeller Personel = new Fonksiyonlar.TBL_Personeller();
                Personel.Adres = txtAdres.Text;
                Personel.Ilce = txtIlce.Text;
                Personel.IseBaslangicTarihi = DateTime.Parse(txtIseBaslangicTarihi.Text);
                Personel.Mail = txtMailInfo.Text;
                Personel.PersonelAdiSoyadi = txtPersonelAdi.Text;
                Personel.PersonelKodu = txtPersonelKodu.Text;
                if(rbtnAdmin.Checked)
                {
                    Personel.PersonelRutbe = "Admin";
                    Personel.PersonelKullaniciAdi = txtPersonelKullaniciAdi.Text;
                    if(txtPersonelSifre.Text==txtPersonelSifreTekrar.Text)
                    {
                        Personel.PersonelSifre = txtPersonelSifre.Text;
                    }
                    Personel.SorumluOldDepartman = "Hepsi";
                }
                else if (rbtnYetkili.Checked)
                {
                    Personel.PersonelRutbe = "Yetkili";
                    Personel.PersonelKullaniciAdi = txtPersonelKullaniciAdi.Text;
                    if (txtPersonelSifre.Text == txtPersonelSifreTekrar.Text)
                    {
                        Personel.PersonelSifre = txtPersonelSifre.Text;
                    }
                    Personel.SorumluOldDepartman = "Hepsi";
                }
                else if (rbtnBolumSorumlusu.Checked)
                {
                    Personel.PersonelRutbe = "Bölüm Sorumlusu";
                    Personel.PersonelKullaniciAdi = txtPersonelKullaniciAdi.Text;
                    if (txtPersonelSifre.Text == txtPersonelSifreTekrar.Text)
                    {
                        Personel.PersonelSifre = txtPersonelSifre.Text;
                    }
                    Personel.SorumluOldDepartman = SorumluDepartmanID;
                }
                else if (rbtnPersonel.Checked)
                {
                    Personel.PersonelRutbe = "Personel";
                }

                if(rbtnAktif.Checked)
                {
                    Personel.PersonelAktif = true;
                }
                else if(rbtnPasif.Checked)
                {
                    Personel.PersonelAktif = false;
                    Personel.AyrilmaTarihi = DateTime.Parse(txtAyrilmaTarihi.Text);
                }
                Personel.Sehir = txtSehir.Text;
                Personel.Telefon1 = txtTelefon1.Text;
                Personel.Telefon2 = txtTelefon2.Text;
                Personel.WebAdres = txtWebAdres.Text;
                Personel.DepartmanID = DepartmanID;
                Personel.PersonelKullaniciAdi = txtPersonelKullaniciAdi.Text;
                Personel.SaveDate = DateTime.Now;
                Personel.SaveUser = AnaForm.UserID;
                Personel.Sehir = txtSehir.Text;
                Personel.Telefon1 = txtTelefon1.Text;
                Personel.Telefon2 = txtTelefon2.Text;
                Personel.WebAdres = txtWebAdres.Text;
                DB.TBL_Personellers.InsertOnSubmit(Personel);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Personel Kaydı Oluşturuldu");
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
                Fonksiyonlar.TBL_Personeller Personel = DB.TBL_Personellers.First(s => s.ID == PersonelID);
                Personel.Adres = txtAdres.Text;
                Personel.Ilce = txtIlce.Text;
                Personel.IseBaslangicTarihi = DateTime.Parse(txtIseBaslangicTarihi.Text);
                Personel.Mail = txtMailInfo.Text;
                Personel.PersonelAdiSoyadi = txtPersonelAdi.Text;
                Personel.PersonelKodu = txtPersonelKodu.Text;
                if (rbtnAdmin.Checked)
                {
                    Personel.PersonelRutbe = "Admin";
                    Personel.PersonelKullaniciAdi = txtPersonelKullaniciAdi.Text;
                    if (txtPersonelSifre.Text == txtPersonelSifreTekrar.Text)
                    {
                        Personel.PersonelSifre = txtPersonelSifre.Text;
                    }
                    Personel.SorumluOldDepartman = "Hepsi";
                }
                else if (rbtnYetkili.Checked)
                {
                    Personel.PersonelRutbe = "Yetkili";
                    Personel.PersonelKullaniciAdi = txtPersonelKullaniciAdi.Text;
                    if (txtPersonelSifre.Text == txtPersonelSifreTekrar.Text)
                    {
                        Personel.PersonelSifre = txtPersonelSifre.Text;
                    }
                    Personel.SorumluOldDepartman = "Hepsi";
                }
                else if (rbtnBolumSorumlusu.Checked)
                {
                    Personel.PersonelRutbe = "Bölüm Sorumlusu";
                    Personel.PersonelKullaniciAdi = txtPersonelKullaniciAdi.Text;
                    if (txtPersonelSifre.Text == txtPersonelSifreTekrar.Text)
                    {
                        Personel.PersonelSifre = txtPersonelSifre.Text;
                    }
                    Personel.SorumluOldDepartman = SorumluDepartmanID;
                }
                else if (rbtnPersonel.Checked)
                {
                    Personel.PersonelRutbe = "Personel";
                }
                if (rbtnAktif.Checked)
                {
                    Personel.PersonelAktif = true;
                }
                else if (rbtnPasif.Checked)
                {
                    Personel.PersonelAktif = false;
                    Personel.AyrilmaTarihi = DateTime.Parse(txtAyrilmaTarihi.Text);
                }

                Personel.Sehir = txtSehir.Text;
                Personel.Telefon1 = txtTelefon1.Text;
                Personel.Telefon2 = txtTelefon2.Text;
                Personel.WebAdres = txtWebAdres.Text;
                Personel.DepartmanID = DepartmanID;
                Personel.PersonelKullaniciAdi = txtPersonelKullaniciAdi.Text;
                Personel.EditDate = DateTime.Now;
                Personel.EditUser = AnaForm.UserID;
                Personel.Sehir = txtSehir.Text;
                Personel.Telefon1 = txtTelefon1.Text;
                Personel.Telefon2 = txtTelefon2.Text;
                Personel.WebAdres = txtWebAdres.Text;
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
                DB.TBL_Personellers.DeleteOnSubmit(DB.TBL_Personellers.First(s => s.ID == PersonelID));
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
            try
            {
                Edit = true;
                PersonelID = ID;
                Fonksiyonlar.TBL_Personeller Personel = DB.TBL_Personellers.First(s => s.ID == PersonelID);
                txtAdres.Text = Personel.Adres;
                txtIlce.Text = Personel.Ilce;
                txtIseBaslangicTarihi.Text = Personel.IseBaslangicTarihi.ToString();
                txtMailInfo.Text = Personel.Mail;
                txtPersonelAdi.Text = Personel.PersonelAdiSoyadi;
                txtPersonelKodu.Text = Personel.PersonelKodu;
                txtSehir.Text = Personel.Sehir;
                txtTelefon1.Text = Personel.Telefon1;
                txtTelefon2.Text = Personel.Telefon2;
                txtWebAdres.Text = Personel.WebAdres;
                if (Personel.PersonelRutbe == "Admin")
                {
                    rbtnAdmin.Checked = true;
                    txtPersonelKullaniciAdi.Text = Personel.PersonelKullaniciAdi;
                    txtPersonelSifre.Text = Personel.PersonelSifre;
                    Personel.SorumluOldDepartman = "Hepsi";
                }
                else if (Personel.PersonelRutbe == "Yetkili")
                {
                    rbtnYetkili.Checked = true;
                    txtPersonelKullaniciAdi.Text = Personel.PersonelKullaniciAdi;
                    txtPersonelSifre.Text = Personel.PersonelSifre;
                    Personel.SorumluOldDepartman = "Hepsi";
                }
                else if (Personel.PersonelRutbe == "Bölüm Sorumlusu")
                {
                    rbtnBolumSorumlusu.Checked = true;
                    txtPersonelKullaniciAdi.Text = Personel.PersonelKullaniciAdi;
                    txtPersonelSifre.Text = Personel.PersonelSifre;
                    SorumluDepartmanAc(Personel.SorumluOldDepartman);
                }
                else if (Personel.PersonelRutbe == "Personel")
                {
                    rbtnPersonel.Checked = true;
                }
                if(Personel.PersonelAktif==true)
                {
                    rbtnAktif.Checked = true;
                }
                else if(Personel.PersonelAktif==false)
                {
                    rbtnPasif.Checked = true;
                    txtAyrilmaTarihi.Text = Personel.AyrilmaTarihi.ToString();
                }
                GrupAc(Personel.DepartmanID.Value);
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void GrupAc(int ID)
        {
            try
            {
                DepartmanID = ID;
                Fonksiyonlar.TBL_Departmanlar Departman = DB.TBL_Departmanlars.First(s => s.ID == DepartmanID);
                txtDepartmanAdi.Text = Departman.DepartmanAdi;
                txtDepartmanKodu.Text = Departman.DepartmanKodu;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void SorumluDepartmanAc(string ID)
        {
            try
            {
                SorumluDepartmanID = ID;
                Fonksiyonlar.TBL_Departmanlar Departman = DB.TBL_Departmanlars.First(s => s.DepartmanAdi == SorumluDepartmanID);
                txtSorumluDepartman.Text = Departman.DepartmanAdi;
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
            if (Edit && PersonelID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
                if (Edit && PersonelID >= 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
                else
                    YeniKaydet();
            
        }

        private void txtGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.Departmanlar(true);
            if(ID>0)
            {
                GrupAc(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void txtMusteriKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.PersonelListesi(true);
            if(ID>0)
            {
                Ac(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void rbtnPersonel_CheckedChanged(object sender, EventArgs e)
        {
            txtPersonelKullaniciAdi.Visible = false;
            txtPersonelSifre.Visible = false;
            txtPersonelSifreTekrar.Visible = false;
            txtSorumluDepartman.Visible = false;
            lblDepartman.Visible = false;
            lblKullaniciAdi.Visible = false;
            lblSifre.Visible = false;
            lblSifreTekrar.Visible = false;
        }

        private void rbtnBolumSorumlusu_CheckedChanged(object sender, EventArgs e)
        {
            txtPersonelKullaniciAdi.Visible = true;
            txtPersonelSifre.Visible = true;
            txtPersonelSifreTekrar.Visible = true;
            txtSorumluDepartman.Visible = true;
            lblDepartman.Visible = true;
            lblKullaniciAdi.Visible = true;
            lblSifre.Visible = true;
            lblSifreTekrar.Visible = true;
        }

        private void rbtnYetkili_CheckedChanged(object sender, EventArgs e)
        {
            txtPersonelKullaniciAdi.Visible = true;
            txtPersonelSifre.Visible = true;
            txtPersonelSifreTekrar.Visible = true;
            txtSorumluDepartman.Visible = false;
            lblDepartman.Visible = false;
            lblKullaniciAdi.Visible = true;
            lblSifre.Visible = true;
            lblSifreTekrar.Visible = true;
        }

        private void rbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            txtPersonelKullaniciAdi.Visible = true;
            txtPersonelSifre.Visible = true;
            txtPersonelSifreTekrar.Visible = true;
            txtSorumluDepartman.Visible = false;
            lblDepartman.Visible = false;
            lblKullaniciAdi.Visible = true;
            lblSifre.Visible = true;
            lblSifreTekrar.Visible = true;
        }

        private void rbtnAktif_CheckedChanged(object sender, EventArgs e)
        {
            txtAyrilmaTarihi.Enabled = false;
            lblAyrilmaTarihi.Enabled = false;
        }

        private void rbtnPasif_CheckedChanged(object sender, EventArgs e)
        {
            txtAyrilmaTarihi.Enabled = true;
            lblAyrilmaTarihi.Enabled = true;
        }

        private void txtIseBaslangicTarihi_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAyrilmaTarihi_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
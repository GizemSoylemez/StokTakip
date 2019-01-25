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

namespace GFStokTakip
{
    public partial class frmLoginForm : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.DataBaseDataContext DB = new Fonksiyonlar.DataBaseDataContext();
        string rutbe = "";
        public frmLoginForm()
        {
            InitializeComponent();
            txtKullanici.Focus();
        }

        public void btnGiris_Click(object sender, EventArgs e)
        {
            bool admin = rbtnAdmin.Checked;
            bool bolumSorumlusu = rbtnBolumSorumlusu.Checked;
            bool yetkili = rbtnYetkili.Checked;
            GirisYap(txtKullanici.Text, txtSifre.Text,admin,bolumSorumlusu,yetkili);
        }

        public int GirisYap(string kullaniciAdi,string sifre,bool admin,bool bolumSorumlusu,bool yetkili)
        {
            if (kullaniciAdi != "" && sifre != "")
            {
                if (admin == true || bolumSorumlusu == true || yetkili == true)
                {
                    try
                    {
                        if (admin)
                        {
                            rutbe = "Admin";
                        }
                        if (yetkili)
                        {
                            rutbe = "Yetkili";
                        }
                        if (bolumSorumlusu)
                        {
                            rutbe = "Bölüm Sorumlusu";
                        }
                        Fonksiyonlar.TBL_Personeller Kullanici = DB.TBL_Personellers.First(s => s.PersonelKullaniciAdi == kullaniciAdi.Trim() && s.PersonelSifre == sifre.Trim() && s.PersonelRutbe == rutbe);
                        Kullanici.LastLogin = DateTime.Now;
                        DB.SubmitChanges();
                        this.Hide();
                        AnaForm frm = new AnaForm(Kullanici);
                        frm.Show();
                        return 0;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Giriş Yapılamadı Bilgileriniz Yanlıştır. Tekrar Deneyiniz");
                        return 1;
                    }
                }
                else
                {
                    MessageBox.Show("Yetki Seçiniz.");
                    return 2;
                }
            }
            else
            {
                MessageBox.Show("Boş Değer Girmeyiniz.");
                return 3;
            }
        }

        private void frmLoginForm_Load(object sender, EventArgs e)
        {
            txtSifre.Properties.PasswordChar = '*';
        }

        private void rbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
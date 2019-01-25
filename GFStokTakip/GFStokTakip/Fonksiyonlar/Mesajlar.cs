using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace GFStokTakip.Fonksiyonlar
{
    class Mesajlar
    {
        public void YeniKayit(string Mesaj)
        {
            MessageBox.Show(Mesaj,"Yeni Kayıt Girişi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili Kayıt Kalıcı Olarak Güncellenecektir \n İşlemi Onaylıyormusunuz ?","Güncelleme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
        public void Guncelle(bool Guncelleme)
        {
            MessageBox.Show("Kayıt Güncellenmiştir.","Kayıt Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili Kayıt Kalıcı Olarak Silinecektir \n İşlemi Onaylıyormusunuz ? ","Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
        public void Hata(Exception Hata)
        {
            MessageBox.Show(Hata.Message,"Hata Oluştu",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}

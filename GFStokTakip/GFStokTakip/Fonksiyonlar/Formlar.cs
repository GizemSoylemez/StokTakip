using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFStokTakip.Fonksiyonlar
{
    class Formlar
    {
        #region Ürün İşlemleri
        public int UrunListesi(bool Secim = false)
        {
            Modul_Stok.frmUrunListesi frm = new Modul_Stok.frmUrunListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }
        public int UrunMarkalari(bool Secim = false)
        {
            Modul_Stok.frmUrunMarkalari frm = new Modul_Stok.frmUrunMarkalari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }

        public int UrunTurleri(bool Secim = false)
        {
            Modul_Stok.frmUrunTuru frm = new Modul_Stok.frmUrunTuru();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }
        public int UrunTeminleri(bool Secim = false)
        {
            Modul_Stok.frmUrunTeminleri frm = new Modul_Stok.frmUrunTeminleri();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }

        public void UrunHareketleri(bool Ac = false)
        {

        }
        public void UrunKarti(bool Ac = false)
        {
            Modul_Stok.frmUrunEkle frm = new Modul_Stok.frmUrunEkle();

            frm.ShowDialog();
        }
        #endregion

        public int Departmanlar(bool Secim = false)
        {
            Modul_Musteri.frmMusteriGruplari frm = new Modul_Musteri.frmMusteriGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }

        public int PersonelListesi(bool Secim=false)
        {
            Modul_Musteri.frmMusteriListesi frm = new Modul_Musteri.frmMusteriListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
                
            return AnaForm.Aktarma;
        }
        public void PersonelEkle(bool Ac=false,int MusteriID=-1)
        {
            Modul_Musteri.frmMusteriEkle frm = new Modul_Musteri.frmMusteriEkle();
            if (Ac) frm.Ac(MusteriID);
            frm.ShowDialog();
        }

        public void ZimmetEkle(bool Ac = false, int ZimmetID = -1)
        {
            Modul_Zimmet.frmZimmetEkle frm = new Modul_Zimmet.frmZimmetEkle();
            if (Ac) frm.Ac(ZimmetID);
            frm.ShowDialog();
        }

        public int ZimmetListesi(bool Secim = false)
        {
            Modul_Zimmet.frmZimmetListesi frm = new Modul_Zimmet.frmZimmetListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

        public int DepartmanListesi(bool Secim = false)
        {
            Modul_Musteri.frmMusteriGruplari frm = new Modul_Musteri.frmMusteriGruplari();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

        public void KullaniciYonetimi()
        {
            Modul_Kullanicilar.frmKullaniciYonetimi frm = new Modul_Kullanicilar.frmKullaniciYonetimi();
            frm.ShowDialog();
        }
        public int ZimmetHataListesi(bool Secim = false)
        {
            Modul_Zimmet.frmZimmetIadeNeden frm = new Modul_Zimmet.frmZimmetIadeNeden();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }
    }
}

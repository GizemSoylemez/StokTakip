using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GFStokTakip;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void BaglantiTesti()
        {
            GFStokTakip.Fonksiyonlar.DataBaseDataContext DB = new GFStokTakip.Fonksiyonlar.DataBaseDataContext();
        }

        [TestMethod()]
        public void GirisYapTest()
        {
            int beklenenDeger = 0;

            string kullaniciAdi = "Furkan581907";
            string sifre = "123";
            frmLoginForm a = new frmLoginForm();
            int sonuc = a.GirisYap(kullaniciAdi, sifre,true,false,false);
            Assert.AreEqual(beklenenDeger, sonuc);
        }


        [TestMethod()]
        public void GirisYapTest1()
        {
            int beklenenDeger = 1;

            string kullaniciAdi = "Fççkdskönds";
            string sifre = "123";
            frmLoginForm a = new frmLoginForm();
            int sonuc = a.GirisYap(kullaniciAdi, sifre, true, true, true);
            Assert.AreEqual(beklenenDeger, sonuc);
        }

        [TestMethod()]
        public void GirisYapTest2()
        {
            int beklenenDeger = 2;

            string kullaniciAdi = "Gizem";
            string sifre = "1235";
            frmLoginForm a = new frmLoginForm();
            int sonuc = a.GirisYap(kullaniciAdi, sifre, false, false, false);
            Assert.AreEqual(beklenenDeger, sonuc);
        }

        [TestMethod()]
        public void GirisYapTest3()
        {
            int beklenenDeger = 3;

            string kullaniciAdi = "";
            string sifre = "";
            frmLoginForm a = new frmLoginForm();
            int sonuc = a.GirisYap(kullaniciAdi, sifre, true, true, false);
            Assert.AreEqual(beklenenDeger, sonuc);
        }
        
    }
}

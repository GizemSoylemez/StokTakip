using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFStokTakip.Fonksiyonlar
{
    class Numara
    {
        DataBaseDataContext DB = new DataBaseDataContext();
        Mesajlar Mesajlar = new Mesajlar();
        public string UrunKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_Urunlers
                                        orderby s.ID descending
                                        select s).First().UrunKodu);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');//sol tarafından 7 hane 0 olacak hale getir.
                return Num;

            }
            catch (Exception)
            {

                return "0000001";


            }
        }
        public string MusteriKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_Personellers
                                        orderby s.ID descending
                                        select s).First().PersonelKodu);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');//sol tarafından 7 hane 0 olacak hale getir.
                return Num;

            }
            catch (Exception)
            {

                return "0000001";


            }
        }
        public string ZimmetKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_Zimmetlers
                                        orderby s.ID descending
                                        select s).First().ZimmetKodu);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');//sol tarafından 7 hane 0 olacak hale getir.
                return Num;

            }
            catch (Exception)
            {

                return "0000001";


            }
        }
    }
}

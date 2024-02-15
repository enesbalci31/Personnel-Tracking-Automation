using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiberKayit
{
    class islemler
    {

        SiberKayitEntities vt = new SiberKayitEntities();

        public bool kayit(string adi,string soyadi,string tcno,DateTime giris)
        {

            try
            {
                siber siberkayit = new siber();
                siberkayit.adi = adi;
                siberkayit.Soyadi = soyadi;
                siberkayit.TcNo = tcno;
                siberkayit.girisTarihi = giris;

                vt.siber.Add(siberkayit);
                 vt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }


        }
        public bool sil(int silinecekid)
        {
            try
            {
                siber sil = new siber();

                var silinecek = vt.siber.FirstOrDefault(x => x.id == silinecekid);
                vt.siber.Remove(silinecek);
                vt.SaveChanges();
                return true;
            }
            
            catch(Exception ex)
            {
                return false;
            }

        }

        public bool guncelle(int id,string yeniAd,string yeniSoyad,string yeniTc)
        {
            var guncellenecekk = vt.siber.FirstOrDefault(x => x.id == id);

            if (guncellenecekk != null)
            {
                guncellenecekk.adi = yeniAd;
                guncellenecekk.Soyadi = yeniSoyad;
                guncellenecekk.TcNo = yeniTc;

                vt.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    

    }
}

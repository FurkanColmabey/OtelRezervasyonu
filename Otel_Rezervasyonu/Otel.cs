using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyonu
{
    class Otel
    {
        internal string[] otelTip = { "denizTek", "denizCift", "denizIkiz", "havuzTek", "havuzCift", "havuzIkiz" };
        
        //Odaları yarattık.

        Oda oda1 = new Oda("denizTek");
        Oda oda2 = new Oda("denizCift");
        Oda oda3 = new Oda("denizIkiz");
        Oda oda4 = new Oda("havuzTek");
        Oda oda5 = new Oda("havuzCift");
        Oda oda6 = new Oda("havuzIkiz");




        public bool odaMusaitMi(DateTime baslangic, DateTime bitis, string odaTip)
        {
            //Girilen tarihte odanın doluluğunu kontrol ettirdik.

            bool result = false;

            Console.WriteLine("qwdqwd" + odaTip);

            if (odaTip == "denizTek")
                result = oda1.tarihKontrol(baslangic, bitis);
            else if (odaTip == "denizCift")
                result = oda2.tarihKontrol(baslangic, bitis);
            else if (odaTip == "denizIkiz")
                result = oda3.tarihKontrol(baslangic, bitis);
            else if (odaTip == "havuzTek")
                result = oda4.tarihKontrol(baslangic, bitis);
            else if (odaTip == "havuzCift")
                result = oda5.tarihKontrol(baslangic, bitis);
            else if (odaTip == "havuzIkiz")
                result = oda6.tarihKontrol(baslangic, bitis);


            return result;
        }

        public string rezervasyonYap(DateTime baslangic, DateTime bitis, string odaTip)
        {
            //Girilen tarihleri rezerveEt fonksiyonunu çağırarak arraylist'imize ekliyoruz.

            string result = "boş";
            if (odaTip == "denizTek")
            {
                result = oda1.rezerveEt(baslangic, bitis);
                oda1.Doluluk++;
            }
            else if (odaTip == "denizCift")
            {
                result = oda2.rezerveEt(baslangic, bitis);
                oda2.Doluluk++;
            }
            else if (odaTip == "denizIkiz")
            {
                result = oda3.rezerveEt(baslangic, bitis);
                oda3.Doluluk++;
            }
            else if (odaTip == "havuzTek")
            {
                result = oda4.rezerveEt(baslangic, bitis);
                oda4.Doluluk++;
            }
            else if (odaTip == "havuzCift")
            {
                result = oda5.rezerveEt(baslangic, bitis);
                oda5.Doluluk++;
            }
            else if (odaTip == "havuzIkiz")
            {
                result = oda6.rezerveEt(baslangic, bitis);
                oda6.Doluluk++;
            }


            return result;

        }

        public void rezervasyonIptal(int index, string odaTip)
        {
            //Fonksiyona gönderilen index ve oda tipini seçili listboxdan 
            //rezerveIptal fonksiyonunu çağırarak arraylistimizden çıkartıyoruz..
            if (odaTip == "denizTek")
            {
                oda1.rezerveIptal(index);
                oda1.Doluluk--;
            }
            else if (odaTip == "denizCift")
            {
                oda2.rezerveIptal(index);
                oda2.Doluluk--;
            }
            else if (odaTip == "denizIkiz")
            {
                oda3.rezerveIptal(index);
                oda3.Doluluk--;
            }
            else if (odaTip == "havuzTek")
            {
                oda4.rezerveIptal(index);
                oda4.Doluluk--;
            }
            else if (odaTip == "havuzCift")
            {
                oda5.rezerveIptal(index);
                oda5.Doluluk--;
            }
            else if (odaTip == "havuzIkiz")
            {
                oda6.rezerveIptal(index);
                oda6.Doluluk--;
            }
        }

        public int odaDoluluk(string odaTip)
        {
            // Seçili odanın doluluğunu label üzerinden yazdırmayı denedik.
            // 

            Console.WriteLine(oda1.Doluluk);
            if (odaTip == "denizTek")
                return oda1.Doluluk;
            else if (odaTip == "denizCift")
                return oda2.Doluluk;
            else if (odaTip == "denizIkiz")
                return oda3.Doluluk;
            else if (odaTip == "havuzTek")
                return oda4.Doluluk;
            else if (odaTip == "havuzCift")
                return oda5.Doluluk;
            else if (odaTip == "havuzIkiz")
                return oda6.Doluluk;
            else
                return 0;
        }

    }
}

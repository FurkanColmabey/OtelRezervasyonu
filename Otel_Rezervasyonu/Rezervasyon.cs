using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyonu
{
    class Rezervasyon : Otel
    {

        Otel otel = new Otel();

        public int odaDurumSorgula(DateTime baslangic, DateTime bitis, string odaTip)
        {

            
            
            //istisnai durumları ayarlamak için rezervasyonyap butonuna değerler gönderdik.
            //oda müsaitse 1
            //girilen tarih doluysa 3
            //oda tipi seçilmediyse 4
            //diğer durumlarda 0 gönderiyor..

            if(DateTime.Compare(baslangic,bitis) > 0 || DateTime.Compare(baslangic, bitis) == 0)
            {
                return 3;
            }
            else if(odaTip == null)
            {
                return 4;
            }
            else
            {
                bool result = otel.odaMusaitMi(baslangic, bitis, odaTip);

                if (result == true)
                    return 1;
                else
                    return 0;
            }
            
        }


        public void rezervasyonIptalIlet(int index, string odaTip)
        {
            otel.rezervasyonIptal(index,odaTip);
        }

        public string rezervasyonIstekIlet(DateTime baslangic, DateTime bitis, string odaTip)
        {
            return otel.rezervasyonYap(baslangic, bitis, odaTip);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Otel_Rezervasyonu
{
    class Oda
    {
        private ArrayList baslangicDizi = new ArrayList();
        private ArrayList bitisDizi = new ArrayList();

        private string manzara;
        private int kat;
        private int doluluk = 0;
        private string tip;

        public Oda(string tip)
        {
            this.tip = tip;
        }


        public string Manzara
        {
            get { return manzara; }
            set { manzara = value; }
        }


        public int Kat
        {
            get { return kat; }
            set { kat = value; }
        }

        public int Doluluk
        {
            get { return doluluk; }
            set { doluluk = value; }
        }

        public bool tarihKontrol(DateTime baslangic, DateTime bitis)
        {
            //bool tipinde result1 ve result2 tanımladık.
            //bu result1 ve result2 girilen tarihin daha önce rezerve edilmiş tarihler arasında olup olmadığını kontrol ediyor.
            //girilen tarihin başlangıç ve bitiş tarihlerini ayrı ayrı alıp daha önce rezerve edilen tarihlerin 
            //başlangıcından büyük ve bitişinden küçük ise false;
            //diğer durumlarda true değerini odaMüsaitMi? fonksionu içerisine gönderiyor.

            bool result1 = false;
            bool result2 = false;
            
            if(baslangicDizi.Count == 0)
            {
                //Console.WriteLine("count ,if");

                result1 = true;
                result2 = true;
            }
            else
            {
                //Compare komutu ile iki tarihin zamanlarını karşılaştırdık
                // = 0 tarihler aynı
                // > 0 ilk tarih daha büyük
                // < 0 ilk tarih daha küçük

                foreach (DateTime a in baslangicDizi)
                {
                    int temp = DateTime.Compare(a, baslangic);
                    //Console.WriteLine("foreach deneme" + temp);
                    if (temp == 0)
                    {
                        result1 = false;
                        break;
                    }
                    else
                        result1 = true;
                }
                foreach (DateTime b in bitisDizi)
                {
                    int temp = DateTime.Compare(b, bitis);
                    if (temp == 0)
                    {
                        result2 = false;
                        break;
                    }
                    else
                        result2 = true;
                }

                if(result1 == true && result2 == true)
                {
                    bool temp1 = false;
                    bool temp2 = false;
                    foreach (DateTime a in baslangicDizi)
                    {
                        int temp = DateTime.Compare(a, baslangic);
                        if(temp < 0)
                        {
                            temp1 = true;
                            break;
                        }

                    }

                    foreach (DateTime b in bitisDizi)
                    {
                        int temp = DateTime.Compare(b, bitis);
                        if (temp > 0)
                        {
                            temp2 = true;
                            break;
                        }

                    }

                    Console.WriteLine($"temp1 : {temp1} temp 2: {temp2}");

                    if(temp1 == true && temp2 == true)
                    {
                        result1 = false;
                        result2 = false;
                    }

                    


                }

            }

            


            if (result1 == false || result2 == false)
                return false;
            else
                return true;
        }

        public string rezerveEt(DateTime baslangic, DateTime bitis)
        {

            
            

            //Console.WriteLine("atama yapıldı");

            baslangicDizi.Add(baslangic);
            bitisDizi.Add(bitis);

           


            string result = tip + " - " + baslangic.ToString("dd MMMM, yyyy") + " - " + bitis.ToString("dd MMMM, yyyy");

            return result;
        }

        public void rezerveIptal(int index)
        {
            //Console.WriteLine(tip);
            baslangicDizi.RemoveAt(index);
            bitisDizi.RemoveAt(index);

            foreach(DateTime i in baslangicDizi)
            {
                //Console.WriteLine("silindiii" + i);
            }
            
        }


    }
}

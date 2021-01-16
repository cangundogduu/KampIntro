using System;

namespace Ödev6_Class_ve_Döngüler_karışık
{
    class Program
    {
        static void Main(string[] args)
        {
            URUN urun1 = new URUN();
            urun1.UrunAdi = "kazak";
            urun1.UrunBeden = "XL";
            urun1.UrunFiyat = 30;
            urun1.UrunRenk = "kırmızı";

            URUN urun2 = new URUN();
            urun2.UrunAdi = "gömlek";
            urun2.UrunBeden = "L";
            urun2.UrunFiyat = 100;
            urun2.UrunRenk = "beyaz";

            URUN urun3 = new URUN();
            urun3.UrunAdi = "tişört";
            urun3.UrunBeden = "M";
            urun3.UrunFiyat = 25;
            urun3.UrunRenk = "mavi";

            URUN[] ürünler = new URUN[] { urun1, urun2, urun3 };

            for (int i = 0; i < ürünler.Length; i++)
            {
                Console.WriteLine(ürünler[i].UrunAdi + " + " + ürünler[i].UrunBeden + " + " + ürünler[i].UrunRenk + " + " + ürünler[i].UrunFiyat);
            }
            Console.WriteLine("-------------------");

            foreach (var içerik in ürünler)
            {
                Console.WriteLine(içerik.UrunAdi+" "+içerik.UrunBeden+" "+içerik.UrunRenk+" "+içerik.UrunFiyat);
            }
            Console.WriteLine("-------------------");


            int j = 0;
            while (j < ürünler.Length)
            {
                


                Console.WriteLine(ürünler[j].UrunAdi+" + "+ürünler[j].UrunBeden+" + "+ürünler[j].UrunRenk + " + " + ürünler[j].UrunFiyat);
                j++;
           
            }




            Console.ReadLine();



        }
    }

    class URUN
    {
        public string UrunAdi { get; set; }
        public string UrunRenk { get; set; }
        public int UrunFiyat { get; set; }
        public string UrunBeden { get; set; }
    }
}

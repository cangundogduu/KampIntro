using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type safety= tip güvenliği
            //Do not repeat your self =kendini asla tekrarlama

            string KategoriEtiketi = "Kategori ";
            int OgrenciSayisi = 32000;
            double FaizOrani = 1.45;
            bool SistemeGirisYapmismi = false;
            double DolarDun = 7.55;
            double DolarBugun= 7.55;

            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("Azalış Butonu Göster");
            }
            else if (DolarDun<DolarBugun)
            {
                Console.WriteLine("Artış Butonu Göster.");
            }
            else
            {
                Console.WriteLine("Değişim Yok Butonu Göster");
            }
            if (SistemeGirisYapmismi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }


            Console.WriteLine(KategoriEtiketi);
            Console.ReadLine();
        }
    }
}

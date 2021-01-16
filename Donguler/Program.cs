using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {


            //array-dizi
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme","Java Programcı Yetiştirme Kursu","Python Yetiştirme Kursu","Mobil Uygulama" };


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
               
            }
            Console.WriteLine("----------------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("----------------------");
            Console.WriteLine("Sayfa sonu");


            

            Console.ReadLine();
        }
    }
}

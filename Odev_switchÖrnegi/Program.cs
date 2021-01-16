using System;

namespace Odev_switchÖrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            string []Sehirler = new string[] { "İstanbul","Ankara","Sivas","Rize" };

            Console.WriteLine("Şehrinizi Seçiniz.");
            sayi = int.Parse(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine(Sehirler[0]);
                    break;
                case 2:
                    Console.WriteLine(Sehirler[1]);
                    break;

                case 3:
                    Console.WriteLine(Sehirler[2]);
                    break;

                case 4:
                    Console.WriteLine(Sehirler[3]);
                    break;


                default:
                    Console.WriteLine("Yanlış Seçim ,Yeniden Deneyin...");
                    break;



                    




            }
            Console.ReadLine();
        }
    }
}

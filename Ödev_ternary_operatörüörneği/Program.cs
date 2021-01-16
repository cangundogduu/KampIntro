using System;

namespace Ödev_ternary_operatörüörneği
{
    class Program
    {
        static void Main(string[] args)
        {


            int sayi1;
            Console.WriteLine("Lütfen Bir Sayı Giriniz...");
            sayi1 = int.Parse(Console.ReadLine());

            //Ternary Operatörü Örneği
            string sonuc = sayi1 % 2 == 0 ? "Çift" : "Tek";

            Console.WriteLine("Sonuç :" + sonuc);

            

            //İf-Else Örneği

            if (sayi1 % 2 == 0)
            {
                Console.WriteLine("Sonuç : Çift");
            }
            else
            {
                Console.WriteLine("Sonuç : Tek");
            }

            Console.ReadLine();
        }
        
    }
}

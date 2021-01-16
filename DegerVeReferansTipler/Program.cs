using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            //değer tip = int,double,float,bool,decimal
            //referans tip= class,array(listeler)
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            


            int[] Sayi1 = new int[] {10,12,15 };
            int[] Sayi2 = new int[] { 20, 22, 25 };
            //aşağıdaki kod Sayi2'nin arka plandaki karşısındaki sayıların bir otomatik referans numarası Sayi1'e geçiyor. 
            Sayi1 = Sayi2;
            //Aşağıdaki kod ise Sayi1 ve Sayi2 nin ortak referansı olan sayının [0]'ıncı değerini değiştiriyoruz. 
            Sayi2[0] = 50;
            //değişen referans değerdeki 0'ıncı yeni değeri ekrana yazdırıyoruz.
            Console.WriteLine(Sayi1[0]);
            Console.ReadLine();
        }
    }
}

using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursEgitmen = "Can Gündoğdu";
            kurs3.IzlenmeOrani = 70;


            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.KursEgitmen = "Fatma Gündoğdu";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursEgitmen);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            for (int i = 0; i < kurslar.Length; i++)
            {

                Console.WriteLine(kurslar[i].KursAdi+" : "+kurslar[i].KursEgitmen);

            }

            Console.WriteLine("-----------------------------");
                    
         

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.KursEgitmen);
            }
            Console.ReadLine();
        }
        
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmen{ get; set; }
        public int IzlenmeOrani { get; set; }
    }
}

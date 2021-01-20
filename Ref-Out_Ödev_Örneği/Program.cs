using System;

namespace Ref_Out_Ödev_Örneği
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2=80;
            var result = Topla(ref number1,number2);
            var result2 = Topla2(out number1, number2);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.ReadLine();

        }

        static int Topla2(out int number1, int number2)
        {


           number1 = 50;
            return number1 + number2;
        }

        static int Topla(ref int number1,int number2)
        {


            number1 = 20;
            return number1 + number2;
        }


    }

}  

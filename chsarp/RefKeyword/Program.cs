using System;

namespace RefKeyword
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 10;
            int number3 = 10;

            var carpimsonucu = Add(ref number1, ref number2, ref number3);

            var toplamsonucu = Add3(number1, number2, number3);

            Console.WriteLine(carpimsonucu);
            Console.WriteLine("*********");
            Console.WriteLine(toplamsonucu);
        }
        //değer tiplerinde mevzu tamamen değişkenin değeriyle ilgilidir
        //ref keyword'ü; değer tiplerinin; referans tipi gibi kullanılmasını sağlar
        static int Add(ref int number1, ref int number2, ref int number3)
        {
            number1 = 30;
            number2 = 30; //sonuç = 27000
            number3 = 30;
            return number1 * number2 * number3;
        }
        static int Add3(int number1, int number2, int number3)
        {
           return number1 + number2 + number3;
        }
    }
}

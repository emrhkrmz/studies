using System;

namespace MethodOverloadingMetodlarınAsiriYuklenmesi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2, 5));
            Console.WriteLine(Multiply(2, 5, 10));
            Console.WriteLine(Multiply(2, 5, 10, 10));
            Console.WriteLine(Multiply(2, 5, 10, 10, 10));
            Console.WriteLine(Multiply(2, 5, 10, 10, 10, 10));
            Console.WriteLine(Multiply(2, 5, 10, 10, 10, 10, 10));
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Multiply(int number1, int number2, int number3, int number4)
        {
            return number1 * number2 * number3 * number4;
        }
        static int Multiply(int number1, int number2, int number3, int number4, int number5)
        {
            return number1 * number2 * number3 * number4 * number5;
        }
        static int Multiply(int sayi1, int sayi2, int sayi3, int sayi4, int sayi5, int sayi6)
        {
            return sayi1 * sayi2 * sayi3 * sayi4 * sayi5 * sayi6;
        }
        static int Multiply(int s1, int s2, int s3, int s4, int s5, int s6, int s7)
        {
            return s1 * s2 * s3 * s4 * s5 * s6 * s7;
        }
    }
}

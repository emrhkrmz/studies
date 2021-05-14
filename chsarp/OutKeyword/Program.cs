using System;

namespace OutKeyword
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number1 = 99;
            int number2 = 100;
            var toplagel = Add(out number1, number2);
            Console.WriteLine(toplagel);
            Console.WriteLine("*********");
            var hasbelkader = Add2(300);
            Console.WriteLine(hasbelkader);
        }
        static int Add(out int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Add2(int sayi1, int sayi2=30)
        {
            return sayi1 + sayi2;
        }
    }
}

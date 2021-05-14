using System;

namespace LoopsWhile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = 10;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--; //sayıya müdahale edilmeseydi sonsuz dögüye girerdi. -1 de durur
            }
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}

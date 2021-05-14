using System;

namespace SingleLineIf //tek satır
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var number = 99;
            Console.WriteLine(number == 9 ? "Sayı 9 dur" : "Sayı 9 değildir");
            //if ve else kullanmış olduk
            Console.ReadLine();
        }
    }
}

using System;

namespace SwitchBlogu
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var number =22;
            switch (number)
            {
                case 10:
                    Console.WriteLine("Sayı 10 dur");
                    break;
                case 20:
                    Console.WriteLine("Sayı 20 dir");
                    break;
                case 30:
                    Console.WriteLine("Sayı 30 dur");
                    break;
                default:
                    Console.WriteLine("Sayı sonsuzdur");
                    break;
            }
            Console.ReadLine();
        }
    }
}

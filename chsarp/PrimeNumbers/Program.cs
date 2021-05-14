using System;

namespace PrimeNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if (IsPrimeNumber(1999))
            {
                Console.WriteLine("Asal Sayı");
            }
            else
            {
                Console.WriteLine("Değil Asal Sayı");
            }
        }
        public static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i <= number/2; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    break;
                    //continue;
                    //i = number;
                }
            }
            return result;
        }
    }
}

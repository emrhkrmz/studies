using System;

namespace LoopsDoWhile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //mutlaka yapmak zorunda olduğun bir şey varsa kullanırsın
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number>=0);
        }
    }
}

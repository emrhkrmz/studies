using System;

namespace IciceIfBloklari
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var number = 1000;
            if (number<=99&&number>=50)
            {
                Console.WriteLine("number<=99&&number>=50");
                if (number <= 90 && number >= 80)
                {
                    Console.WriteLine("number <= 90 && number >= 80");

                    if (number <= 79 && number >= 70)
                    {
                        Console.WriteLine(number <= 79 && number >= 70);
                    }
                    else if (number <= 69 && number >= 60)
                    {
                        Console.WriteLine("number <= 79 && number >= 70");
                    }
                    else
                    {
                        Console.WriteLine("Sayı 50 ile 99 arasındadır");

                    }
                }               
            }
            else if (number <= 49 && number >= 0)
              {
                  Console.WriteLine("Sayı 50 den küçük ve 0 dan büyüktür");
              }
            else
            {
                Console.WriteLine("Sayımız sonsuzdur");
            }
        }
    }
}

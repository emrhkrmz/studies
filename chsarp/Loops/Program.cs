using System;

namespace SayisalLoto2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int min = 0;
            int max = 49;
            Random rastgele = new Random();
            int sayimizrastgele = rastgele.Next(min, max);

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine(string.Format("{0}.Kolon",i));
                for (int j = 1; j <= 6; j++)
                {
                    Console.WriteLine(rastgele.Next(min, max));
                }
            }
        }
    }
}

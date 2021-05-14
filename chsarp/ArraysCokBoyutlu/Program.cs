using System;

namespace ArraysCokBoyutlu
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[,] bolgeler = new string[5, 3]
            {
                {"Samsun","Ordu","Rize"},
                {"Kastamonu","Ankara","Antalya"},
                {"Kütahya","Sinop","Alanya"},
                {"Adana","Mersin","Konya"},
                {"Manisa","İzmit","İzmir"},
            };

            for (int i = 0; i <= bolgeler.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= bolgeler.GetUpperBound(1); j++)
                {
                        Console.WriteLine(bolgeler[i, j]);
                }
                Console.WriteLine("*********");
            }

        }
    }
}

using System;

namespace IfBloklari
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var number = 20;
            if (number == 99)
            {
                Console.WriteLine("Sayımız 99 dur");
            }
            else if (number<=10&&number>=1)                                      //esle if ten birden fazla
            {                                                                    //kullandık buna demo çoklu
                Console.WriteLine("Sayımız 1 ile 10 arasındadır. 1-10 dahil");   //şartlarla çalışmak denir
            }
            else if (number<=22&&number>=11)
            {
                Console.WriteLine("Sayımız 11 ile 22 arasındadır. 11-22 dahil");
            }
            else
            {
                Console.WriteLine("Sayımız sonsuzdur");
            }
        }
    }
}

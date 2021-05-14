using System;
using System.Linq;

namespace ChallengeParamsKeyword
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //'params' ile metodumuza aynı tipte istediğimiz kadar parametre gönderebiliriz
            Console.WriteLine(Add(2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2));
            Console.WriteLine(Add3(1000, 2, 2, 2, 2, 2, 2));
        }
        static int Add(params int[] sayilar)
        {
            return sayilar.Sum();
            //Hazır bir metotdur. Dizi de ki tüm sayıları birbiriyle toplu ve sonucu return et demektir.
        }
        //'paramms' mantığa uymalıdır
        static int Add3(int number1, params int[] numbers)
        {
            return numbers.Sum();
            //'int number1' - ilk sayı, verdiğimiz ilk sırada ki değeri aldıktan sonra,
            //'params' devreye girecek ve sayıları toplayacaktır.
            //'params' mantığa uymalıdır.
            // 'int number1' - 'int number2' - 'params'ın sonuna yazamayız;
            //'params' metodun son parametresi olmak zorundadır.
        }
    }
}

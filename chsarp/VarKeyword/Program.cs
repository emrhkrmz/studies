using System;

namespace VarKeyword
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //'var' değişken değildir. Değişken tutmak için kullanılır.
            var number = 203;
            number = 2023; //diyebiliriz
            //number = zeynep; //diyemeyiz. Integer tanımladık, string yazamayız.
            Console.WriteLine(number);
        }
    }
}

using System;

namespace ValueTypesVeriTipleri
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number1 = 2147483647; // 32 bit bellekte
            int number11 = -2147483648;
            long number2 = 230894023872234; // 64 bit bellekte
            long number22 = -239048239402232;
            short number3 = 3833; // 16 bit bellekte
            short number33 = -4345;
            byte number4 = 0; // 8 bit bellekte
            byte number44 = 255; // 0 ile 255 sayıları ararsında ki verileri tutarız
            double number5 = 3884.12345678915;
            double number55 = -2933.12345678915;
            decimal number6 = 234.523434525345235675623675672359m; // decimal ile ondalıklı sayı kullanılırken 'm' harfi kullanılır
            decimal number66 = -235.0245078967459034575658845539m;
            char karakter = 'E'; // 16 bit bellekte + unicode standarltarında karaktlerin karşılığını karşılığını tutar
            // değer atandıktan sonra bir karakteri temsil eder
            // tek bir karakteri hafıza tutmak gerektiğinde kullanılır
            // string işlemlerinde her bir karakterle işlem yapmamız gerektiği durumlarda geçici değişken olarak kullanılır
            // integer veri tipine çevrilebilir

            Console.WriteLine("VALUE TYPES\ninteger:\n{0}\n{1}" +
            "\nlong:\n{2}\n{3}" +
            "\nshort:\n{4}\n{5}"+
            "\nbyte:\n{6}\n{7}"+
            "\ndouble:\n{8}\n{9}"+
            "\ndecimal:\n{10}\n{11}", number1, number11, number2, number22, number3, number33, number4, number44, number5, number55,number6,number66);

            Console.WriteLine("'bool' veri tipi mantıksal bir veri tipidir. Değer tipidir.\n" +
                "Tuttuğu değer 'true' veya 'false' dur. Yani doğru veya yanlış." +
                "\nGenellikle 'if' gibi karşılaştırma bloglarında sıklıkla kullanırız.");

            Console.WriteLine(karakter);

            Console.WriteLine("ASCII : Klavyemizde kullandığımız E nin sayısal karşılığı : {0}",(int)karakter);
            // integer veri tipine çevirdik

            Console.ReadLine();
        }
    }
}

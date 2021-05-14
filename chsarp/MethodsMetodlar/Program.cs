using System;

namespace MethodsMetodlar
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Metodları 'static' içerisinde kullanılırız.
            //Bir daha kullanacağımız veya tekrarlayan işlemlerde biz metod kullanırız.

            //Projlerin isimleri büyük harfle başlayıp küçük harfle devam eder.
            //İkinci kelimenin ilk harfi büyük diğerleri küçük harf olur.
            //Buna Pascal Case denir.

            //'voit' git şunu yap demektir.
            //void yerine ne tipte bir veri döndürmek istiyorsak onu da yazaibiliriz.

            Add();
            Add();
            var hasbelkader = Add2(20, 40);
            var yolumuz = Add2(300, 500);
            var dunya = Add3(1000);

            Console.WriteLine("{0}\n{1}\n{2}",hasbelkader,yolumuz,dunya);
            Console.ReadLine();

            //default parametreli metodlarda default değerler her zaman metodun sonundan başlar
            //yani önce metodun en sonundaki ifadeye değeri veririz
            //sonra sondan birinci
            //bu şekilde devam eder
            //static int Add(int x=76, int y=13, int z) yanlış
            //static int Add(int x, int y=48, int z=75) doğru
        }

        static void Add()
        {
            Console.WriteLine("Emrah Kırmızı");
        }

        static int Add2(int number1, int number2)
        {
            //var result = number1 + number2;
            //return hasbelkader;
            //veya şu şekilde de yazılabilirdi
            return number1 + number2;
        }
        static int Add3(int number1,int number2 = 9)
        {
            //burada 'static void' kullanamazdık.
            //Parantez içerisinde 'int' tanımlayacaktık bu yüzden metod içinde de 'int' kullandık.
            return number1 + number2;
        }
    }
}

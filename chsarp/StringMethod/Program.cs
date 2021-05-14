using System;

namespace StringMethod
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //String : Değer, veri tipi olsa da; aynı zamanda bir char array dir ve bu referans tip olduğu anlamına da gelir.

            string sentence = "XYZ WASD";
            sentence = "ABC DEF WASD CTRL SHIFT";
            var result = sentence.Length; //Cümle kaç karakterden oluşuyor.
            var result2 = sentence.Clone(); //result2 değişmedi, sentence değişti.
            var result3 = sentence.IndexOf(" ");
            var result4 = sentence.LastIndexOf(" ");
            bool result5 = sentence.StartsWith("ABC");
            bool result6 = sentence.EndsWith("SHIFT");
            var result7 = sentence.Insert(3, " Emrah Kırmızı "); //3. karakterden sonra Emrah Kırmızı yazdırdık.
            var result8 = sentence.Substring(3, 14); //3. karakterden sonra 14 karakteri dahil ettik.
            var result9 = sentence.Remove(3); //3. karakteren sonra hepsini uçurduk.
            var result10 = sentence.Remove(3, 4); //3. karakterden sonra 4 tane uçurduk.
            var result11 = sentence.Replace(" ", "?"); //metnin içerisinde belli bir karakteri değiştirmek için kullanırız.
            var result12 = sentence.ToLower(); //tüm karakterleri küçük yaptık.
            var result13 = sentence.ToUpper(); //tüm karakterleri büyük yaptık.

            string city = "Ankara";
            string city2 = "İstanbul";

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}\n{10}\n{11}\n{12}", result, result2, result3, result4, result5, result6, result7, result8, result9, result10, result11, result12, result13);
            Console.WriteLine("");
            Console.WriteLine(String.Format("{0}\n{1}", city, city2));
            Console.WriteLine(String.Format(city+city2));

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            foreach (var item in city2)
            {
                Console.WriteLine(item);
            }
        }
    }
}

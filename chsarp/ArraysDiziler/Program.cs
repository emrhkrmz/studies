using System;

namespace ArraysDiziler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] ogrencilerinYaslari = { 10, 20, 30 }; //array kullanımı
            foreach (var ogrenci in ogrencilerinYaslari)
            {
                Console.WriteLine("\nÖğrencilerin Yaşları:\n{0}",ogrenci);
            }
            Console.WriteLine("\n---------");
            string[] ogrencilerinYasadigiSehirler = { "Gaziantep", "Kahramanmaraş", "Şanlıurfa" };
            foreach(string ogrenci in ogrencilerinYasadigiSehirler)
            {
                Console.WriteLine("\nÖğrencilerin Yaşadığı Şehirler:\n{0}",ogrenci);
            }
            Console.WriteLine("---------");

            string[] bebeler = new string[3]; //array kullanımı
            bebeler[0] = "Engin";
            bebeler[1] = "Derin";
            bebeler[2] = "Emrah";
            foreach (var ogrenci in bebeler)
            {
                Console.WriteLine(ogrenci);
            }
            Console.WriteLine("---------");

            string[] students = new string[3] { "Ebrar", "Zeynep", "Su" }; //array kullanımı
            foreach (var ogrenci in students)
            {
                Console.WriteLine(ogrenci);
            }
        }
    }
}

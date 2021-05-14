using System;

namespace EnumTipDonusumleri
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Friday);
            Console.WriteLine((int)Gunler.Friday);
        }
    }
    enum Gunler
    {
        Monday=5, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}

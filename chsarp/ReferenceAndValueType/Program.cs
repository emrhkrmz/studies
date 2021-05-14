using System;

namespace ReferenceAndValueType
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Değer Tipler : integer : boolean : enum : Atamalar tamamen değeri üzerinden gerçekleşir.
            //Referans Tipler : abstract classes : interface : string : classes : arrays

            int number1 = 10;
            int number2 = 20;

            number2 = number1;//2.sayının değeri eşittir 1.sayının değeridir. Olay tamamen değer üzerinden gider.
            number1 = 30;

            string[] cities1 = new string[]
            {
                "Ankara","Adana","Afyon"
            };

            string[] cities2 = new string[]
            {
                "Bursa","Bolu","Balıkesir"
            };

            cities2 = cities1;//citites2 nini referansı eşittir cities2 nin referansı
            cities1[0] = "İstanbul";

            Console.WriteLine(number2);
            Console.WriteLine(cities2[0]);
            //newlemek bellekteki en pahalı işlerden birisidir
            DataTable dataTable;
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;
        }
    }
}

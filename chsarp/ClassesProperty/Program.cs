using System;

namespace ClassesProperty
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //class lar property dediğimiz nesneleri özellikleri tutabilirler
            Customer customer = new Customer
            {
                Id = 1,
                City = "Kastamonu",
                FirstName = "Emrah", //set bloğu çalıştı
                LastName = "Kırmızı"
            };
            Console.WriteLine("{0}\n{1}",customer.FirstName,customer.LastName); //get bloğu çalıştı
        }
    }
}

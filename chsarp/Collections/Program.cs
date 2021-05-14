using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Demo();
            //Koleksiyon oluşturmak için en temellerinden bir tanesidir; ArrayList.
            //ArrayLists();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");
            //Console.WriteLine(dictionary["table"]); //çalışacaktır
            //Console.WriteLine(dictionary["glass"]); //hata verecektir

            foreach (var item in dictionary)
            {
                //Console.WriteLine(item);
                //Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("! ! ! dictionary.ContainsKey ! ! !");
            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));
            Console.WriteLine("010101010101010101");

            List<string> cities = new List<string>();
            cities.Add("Ankara > > >");
            cities.Add("< < < İstanbul");

            Console.WriteLine(cities.Contains("Ankara > > >"));//Şehirlerin içerisinde yazdığınız değer varsa true döner, yoksa false.

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer 
            //{ 
            //    FirstName= "One",
            //    Id = 1
            //});
            //customers.Add(new Customer
            //{
            //    FirstName = "Two",
            //    Id = 2
            //});

            List<Customer> customers = new List<Customer>
            {
                new Customer {FirstName = "One", Id = 1},
                new Customer {FirstName = "Two",Id = 2}
            };

            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Three"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2] 
            { 
                new Customer {Id = 4, FirstName = "four"},
                new Customer {Id = 5, FirstName = "Five"}
            });

            //Console.WriteLine(customers.Contains(new Customer { Id =1, FirstName ="One" }));//yeni bir referans oluşur new dediğimiz zaman. sonuç : false

            Console.WriteLine(customers.Contains(customer2));//sonuç : true: çünkü gerçekten referanstı tutan birşey gönderdik

            //customers.Clear();//listedeki verileri temizler
            Console.WriteLine("Bölüm : 19: Ders : 85 : Collection Özellik ve Metodlarıyla Çalışmak 2");

            //var index = customers.IndexOf(customer2);
            //Console.WriteLine("Index : {0}",index); //listedeki elemanın kaçıncı sırada olduğunu gösterir, IndexOf

            customers.Add(customer2);//aramaya sondan başladığı için LastIndexOf : 5. sırada olduğunu gösterir
            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("Last Index Of : {0}", index2); //aynı sonucu verecek bu customer den başka olmadığı için.
            //index numarası değişmez, arama yeri değişir; sonuç aynı çıkar.

            customers.Insert(0, customer2);//diğerlerini kaydırır silmez
            //Insert : Değeri listenin başına ekler.

            customers.Remove(customer2);//bulduğu ilk değeri uçurur, bulduğu anda da aramayı keser ve bitirir. bulamadığı zaman hiçbirşey yapmaz.
            customers.Remove(customer2);
            customers.RemoveAll(c => c.FirstName == "Three");//isim bu olanları bul ve sil demektir


            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
                Console.WriteLine(customer.FirstName+"\n"+customer.Id);
            }

            var count = customers.Count;//veri sayısını gösterir
            Console.WriteLine("Count : {0}", count);

        }

        private static void ArrayLists()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("Safranbolu");

            cities.Add("< < < İstanbul > > >");
            cities.Add(1);
            cities.Add('A');

            foreach (var citttyyyyy in cities)
            {
                Console.WriteLine(citttyyyyy);
            }
        }

        private static void Demo()
        {
            string[] cities = new string[2]
                        {
                "Ankara", "İstanbul"
                        };
            //cities[2] = "Adana";
            //cities[2] dediğimiz zaman 3. elemanı demiş olduk
            //string'in default değeri "" budur.
            cities = new string[3];
            Console.WriteLine(cities[0]);
            //bunun yerine koleksiyonlardan yararlanırız
            //günümüz projelerinde neredeyse artık array kullanmıyoruz
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}

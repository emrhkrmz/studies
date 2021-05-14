using System;

namespace ClassesSiniflar
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Bir class oluşturulurken kelimenin ilk harfleri büyük oluşturulur ‘pascal case’.
            //Örneği oluşturulduğunda ise ‘camel case’ e döner yani; kelimelerin ilkinin ilk harfi küçük ama sonraki kelimelerin ilk harfi büyük yazılır.
            //class ı kullanabilmemiz için newlememiz yani örneğini oluşturmamız gerekir.
            CustomerManager customerManager = new CustomerManager(); //cutomerManager yazan kısımda istediğimiz herhangi bir kelime yazabilirdik fakat, kodlarımız anlamlı görünsün diye customerManager kullandık.
            customerManager.Add();
            //customerManager

            ProductManager productManager = new ProductManager();
            productManager.Update();
            Console.WriteLine("         ");

            //class lar ile property dediğimiz nesneleri, özellikleri tutabiliriz.
            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "Çorum";
            customer.FirstName = "Emrah";
            customer.LastName = "Kırmızı";
            Console.WriteLine("{0}\n{1}\n{2}\n{3}",customer.Id,customer.City,customer.FirstName,customer.LastName);
            Console.WriteLine("         ");
            Console.WriteLine(customer.Id + customer.City + customer.FirstName + customer.LastName);
            Console.WriteLine("         ");

            //diğer bir new leme yöntemi
            Customer customer2 = new Customer
            {
                Id = 3,
                City = "Gaziantep",
                FirstName = "Ebrar",
                LastName = "Su"
            };
            Console.WriteLine(customer2.LastName);


        }

        class Customer
        {
            public int Id { get; set; }
            private string _firstName;
            public string FirstName
            {
                get { return "Mr." + _firstName; } //Encapsulation denir.
                set { _firstName = value; } //Değişikliğe ihtiyaç duyduğumuz zaman kullanırız.
            }
            public string LastName { get; set; } //Oto Property
            public string City { get; set; }
        }

        class CustomerManager
        {
            public void Add()
            {
                Console.WriteLine("Customer Added");
            }
            public void Update()
            {
                Console.WriteLine("Customer Updated");
            }
        }
        class ProductManager
        {
            public void Add()
            {
                Console.WriteLine("Product Added");
            }
            public void Update()
            {
                Console.WriteLine("Product Updated");
            }
        }
    }
}

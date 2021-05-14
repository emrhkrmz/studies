using System;

namespace Interfaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Kullanım amacına göre kullanman gereken, çok iyi anlaman gerekn bir konu.
            //Soyut nesneler tek başlarına hiç bir anlam ifade etmezler.
            //Interfaces, yazılırken tamamen metodun imzası kullanılır.
            //Kullanım amacı ise : Temel operasyon, temel nesne oluşuturup; bütün nesneleri ondan implemtent etmektir.
            //Interface ler soyut nesnelerdir. 'I' interface anlamına gelir.
            //Bir nesne de parametre olabilir.
            //Interfaces ve abstract ları tek başlarına new leyemez siniz.
            //IPerson person = new Customer(); şeklinde olabilir ancak...
            //Soyut nesneleri new leyemez siniz.
            //IPerson person =  new IPerson(); //diyemezsiniz fakat;
            //IPerson person = new Customer(); //oluşturabilirsiniz.

            //Interfaces();
            //Interfaces2();

            ICustomerDal[] customerDalss = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };
            foreach (var abcdef in customerDalss)
            {
                abcdef.Add();
                abcdef.Update();
                abcdef.Delete();
            }

        }

        private static void Interfaces2()
        {
            CustomerManager customerManager = new CustomerManager(); //class olduğu için newlemem gerekiyor
            customerManager.AddWeb(new SqlServerCustomerDal());
            customerManager.AddWeb(new OracleCustomerDal());
        }

        private static void Interfaces()
        {
            PersonManager manager = new PersonManager();

            Customer customer = new Customer
            {
                ID = 103,
                Adress = "Mersin",
                FirstName = "FirstName : Limon",
                LastName = "LastName : Mandalina"
            };
            manager.Add(customer);

            manager.Add(new Student { ID = 2, FirstName = "FirstName : Greyfurt", LastName = "LastName : Fındık", Deparmant = "Doğa" });

            manager.Add(new Worker
            {
                ID = 3,
                FirstName = "FirstName : Zeytin",
                LastName = "LastName : Elma",
                Departmant = "Adana"
            });
        }
    }

    interface IPerson //Soyut nesne.
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson //Somut nesne.
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }
    class Student : IPerson //Somut nesne.
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Deparmant { get; set; }
    }
    class Worker : IPerson //somut nesne
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person) //Bir nesne de parametre olabilir.
        {
            Console.WriteLine(person.FirstName+"\n"+person.LastName+"/"+person.ID);
        }
    }

}

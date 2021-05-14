using System;

namespace Constructors
{
    //Not : Interface leri ve abstract classları newleyemeyiz
    class MainClass
    {
        public static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();//()Parantez o sınıfın, parametresiz bir şekilde, constructors(ctor)'ın kullanılmasını sağlar.
            customerManager.Add();
            customerManager.List();

            Product product = new Product { Id = 1, Name = "World Wide Web" };

            Product product2 = new Product(2,"Computer");

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());//constructor injection
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            //static nesne kullanımı
            Teacher.Number = 10;
            Utilities.Validate();
            Manager.DoSomething();//static olanı direkt sınıfın isminden çağırıyoruz
            Manager manager = new Manager();//static olmayanı ise instance üzerinden çağırabiliyoruz
            manager.DoSomething2();

        }
    }
    class CustomerManager
    {
        private int _count=15;//private bir field alt çizgi ile başlatılır : bu isimlendirme standartıdır
        public CustomerManager(int count)//metot halinde ise alt çizgi kullanılmaz
        //ctor yazıp tab tab tuşladık
        {
            _count = count;
        }
        public CustomerManager()//overload
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
    class Product
    {
        //constructor
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id,string name)
        {
            _id = Id;
            _name = Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class EmployeeManager//constructor injection
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)//constructor
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }
    class BaseClass
    {
        protected string _entity;
        public BaseClass(string entity)
        {

        }
        public void Message()
        {
            Console.WriteLine("{0}message",_entity);
        }
    }
    class PersonManager : BaseClass//inheritance
    {
        public PersonManager(string entity):base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }

    //static nesneler onun hiçbir zaman instance'nı oluşturamazsınız : newleyemezsiniz.
    //sattic nesneler ortak nesnelerdir ve herkes onu kullanabilir
    //herkesin ortak kullanacağı yani biri değiştiğinde diğeri içinde değişmesini istediğin bir değer varsa o zaman onu static tanımlayabilirsin.
    //genellikle uzak durmaya çalışır. nadir durumlarda kullanırız.
    static class Teacher
    {
        public static int Number { get; set; }
    }
    static class Utilities
    {
        static Utilities()
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    //classı static yampayıp, özelliklerini static yapabiliriz.
    class Manager//class static olamaz burada. çünkü biz bazı özellikleri static yaptık bazılarını yapmadık aşağıda.
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }
    }
}

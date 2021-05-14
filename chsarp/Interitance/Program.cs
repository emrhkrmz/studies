using System;

namespace Interitance //inheritance :kalıtım : miras
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person[] people = new Person[3]
            {
                new Customer{
                FirstName="Emrah",
                LastName="Kırmızı",
                City="Niğde",
                Id=1 },
                new Student{
                FirstName="Ebrar",
                LastName="Zeynep",
                Departemnt="Sahil Bölgesinden Sorumlu",
                Id=2 },
                new Person{
                FirstName="Su",
                LastName="Toprak",
                Id=3 }
            };

            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }
    class Person //Interfce olmadığı, class olduğu için tek başına da bir anlam ifade eder çünkü somut nesnedir.
    {   public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person //Interface kullanımdaki gibi birden fazla Person yazamayız.
        //Inheritance : Person önce yazılır, varsa daha sonra Interfaces yazılır.
        //Abstract sınıflar Inheritance
        //Interfaces den yürüyün mümkün mertebe
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public String Departemnt { get; set; }
    }
}

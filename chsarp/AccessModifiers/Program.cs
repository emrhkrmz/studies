using System;

namespace AccessModifiers
{
    class MainClass
    {
        public static void Main(string[] args)
        {

        }
    }
    class Customer
    {
        int Id;  //default : private : tanımlandığı blok içerisinde geçerlidir
        public int Id2 { get; set; }
        protected int Id3 { get; set; } //tanımlandığı blok içerisinde her yerde geçerlidir : ayrıcalığı private'tan : Inheritance edildiği sınıflarda kullanılabilirler.

        public void Save()
        {
            Console.WriteLine("saved customer");
        }
        public void Delete()
        {
            Console.WriteLine("deleted customer");
        }
    }
    class Student : Customer //inheritance yaptık
    {
        public void Save2()
        {
            //Id3

        }
    }
    public class Course //bir classın default : internal
    {
        public string Name { get; set; }
        private class NestedClass//sadece bu class içinde kullanılabilir
        {

        }
    }
    //üst seviyeli bir class; private olamaz, protected olamaz
    //üst seviyeli bir class ya internal olur ya da public olur
    //internal aynı proje içerisinde sorunsuz kullanılabilir
}
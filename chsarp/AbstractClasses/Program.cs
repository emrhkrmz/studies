using System;

namespace AbstractClasses //içi dolu olmayan virtual motot dur
//interface ler gibi abstract class ları da new leye meyiz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Database database = new SqlServer();
            database.Add();
            database.Delete();

            Database database2 = new OracleServer();
            database2.Add();
            database2.Delete();
        }
    }
    abstract class Database
    {
        public void Add() //tamamlanmış metot
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete(); //tamamlanmamış metot

    }
    class OracleServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by OracleServer");
        }
    }
    class SqlServer : Database
    {
        public override void  Delete()
        {
            Console.WriteLine("Deleted by SqlServer");
        }
    }
}

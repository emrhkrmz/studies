using System;

namespace VirtualMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();

            MySql mySql = new MySql();
            mySql.Add();

            SqlServer sqlServer2 = new SqlServer();
            sqlServer2.Delete();

            MySql mySql2 = new MySql();
            mySql2.Delete();
        }
    }
    //virtual'u override etmez isek; temek kod çalışır;
    class Database
    {
        public virtual void Add() //virtual
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete() //virtual
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class SqlServer: Database //inheritance
    {
        public override void Add() //override yazıp boşluk bırak seçenekler gelecek...
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add(); //"Added by default" : Database in Add i çalışır.
        }
    }
    class MySql:Database
    {
        public override void Delete() //override yazıp boşluk bırak seçenekler gelecek...
        {
            Console.WriteLine("Deleted by MySql Code");
            //base.Delete(); //"Deleted by default" : Database in Delete i çalışır...
        }
    }
}

using System;
namespace Interfaces
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Delete");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }
    class OracleCustomerDal : ICustomerDal //implemente ettik
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("My Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("My Sql Delete");
        }

        public void Update()
        {
            Console.WriteLine("My Sql Updated");
        }
    }

    class CustomerManager
    {
        public void AddWeb(ICustomerDal customerDal) //Metot parametresi olarak ekledik, daha sonra constrocter kullanacaz.
        {
            customerDal.Add();
        }
    }

}

using System;

namespace RecapDemo2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new SmsLogger();
            customerManager.Add();
        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Added");
        }
    }
    class Logger:ILogger //bir classın mutlaka bir base'i olmalı
    {
        public void Log() //metot
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
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to SMS");
        }
    }
    interface ILogger
    {
        void Log();
    }
}

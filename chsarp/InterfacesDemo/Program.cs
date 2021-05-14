using System;

namespace InterfacesDemo //SOLID : Yazılım geliştirme prensipleri.
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IWorker[] workerss = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var gondergelsin in workerss)
            {
                gondergelsin.Work();

            }

            IEat[] eatss = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var gondergelsin in eatss)
            {
                gondergelsin.Eat();
            }

            ISalary[] salariess = new ISalary[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var gondergelsin in salariess)
            {
                gondergelsin.GetSalary();
            }

        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary //Birden fazla impelente olabilir.
    {
        public void Eat()
        {
            Console.WriteLine("Manager : Yemek Zamanı");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager : Maaş Günü");
        }

        public void Work()
        {
            Console.WriteLine("Manager : Çalışma Zamanı");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker : Yemek Zamanı");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker : Maaş Günü");
        }

        public void Work()
        {
            Console.WriteLine("Worker : Çalışma Zamanı");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot : Çalışma Zamanı");
        }
    }
}

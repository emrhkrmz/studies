using System;

namespace ClassesSiniflar
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //class lar nesnel programlamanın en temel unsurudur
            //calss ı kullanabilmek için örneğini yani referansını oluşturmak zorundasın
            //class oluşturulurken ilk harfleri büyük diğer harfler küçük yazılır buna PascalCase denir
            //örneği referansı oluşturulurken küçük harfle başlar ikinci ve sonraki kelimeleri büyük harfle başlar küçük harfle devam eder buna da camelCase denir
            CustomerManager customerManager = new CustomerManager(); //örneği oluşturduk
            customerManager.Add(); //dilediğimiz gibi çağırdık
            customerManager.Update(); //dilediğimiz gibi çağırdık
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
        }
    }
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated *");
        }
    }
    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added ");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated *");
        }
    }
}

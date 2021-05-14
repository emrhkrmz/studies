using System;
using System.Collections.Generic;

namespace Exceptions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //ExceptionIntro();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(Exception exception)
            {

            }
            //Find();

            //Parantez aç kapa, metoto karşılık gelir.
            HandleExpection(() =>
            {
                Find();
            });
        }

        private static void HandleExpection(Action action)
        //Action : parametresiz method bloğudur : void operasyonlar için kullanılır. Herhangi bir return ifadesi göndermez.
        {
            try
            {
                action.Invoke(); //ben bunu parametre olarak gönderdim ya bunu çalıştır demek
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Engin", "Derin", "Salih" };

            if (!students.Contains("Necati"))//Öğrencilerin içerisinde Necati yoksa : !
            {
                throw new RecordNotFoundException ("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }

        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Engin", "Derin", "Salih" };
                students[3] = "Necati";

            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
    }
}

using System;

namespace LoopsForEach
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //dizi temelli dataların dolaşılması için kullanılır
            //veri tabınında ki datayı gezmek için kullanılır
            string[] students = new string[3] { "Emrah", "Kırmızı", "Red" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}

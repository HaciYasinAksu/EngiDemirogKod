using System;

namespace Donguler // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım gelişltirici kampı";
            string kurs2 = "Programlamaya başlangıç için yeni kurs";
            string kurs3 = "Java";
            //Bu tip verileri arraylerde tutulur
            String[] kurslar = new string[] { "Yazılım gelişltirici kampı" , "Programlamaya başlangıç için yeni kurs", "Java" };
            for (int i =0 ; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
//2.1
//8.3
//3,2
//2,15

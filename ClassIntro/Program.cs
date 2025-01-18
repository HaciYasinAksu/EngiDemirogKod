using System;
using System.Linq;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Course kurs1 = new Course();
            kurs1.Egitmen = "Engin Demirog";
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani =68;

            Course kurs2 = new Course();
            kurs2.Egitmen = "Engin Demirog";
            kurs2.KursAdi = "C#";
            kurs2.IzlenmeOrani = 68;

            Course kurs3 = new Course();
            kurs3.Egitmen = "Engin Demirog";
            kurs3.KursAdi = "C#";
            kurs3.IzlenmeOrani = 68;

            Course[] Kurslar = new Course[] {kurs1,kurs2,kurs3 };
            
            foreach (Course kur in Kurslar)
            {
                Console.WriteLine(kur.KursAdi);
            }

        }
    }


    class Course
    {
        public String KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
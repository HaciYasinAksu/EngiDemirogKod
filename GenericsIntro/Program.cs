using System;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            isimler.Add("Murat");
            isimler.Add("Kerem");
            isimler.Add("Halil");
            isimler.Add("İlker");
            isimler.Add("Mehmet");
            
            //List aslında arka tarafta bir array tutar ve bu arrayi yönetir.
        }
    }
}

using System;
using System.Net.WebSockets;

namespace KampIntro // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String KategoriEtiketi = "Kategori";
            //type safety - Tip güvenliği
            //Do not repeat your self
            int studientnumber = 12;
            double dolarrevenue = 12.3;
            bool insystem = false;
            double dolardun = 34;
            double dolarbugun = 35.4;

            if (insystem == true)
            {
                Console.WriteLine("sisteme giriş yapıldı");
            }
            else
            {
                Console.WriteLine("sisteme giriş yapılmadı");
            }


        }
    }
}
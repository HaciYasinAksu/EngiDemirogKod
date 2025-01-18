using System;

namespace Metots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Aciklama = "Anamur Muzu";
            urun1.Adi = "Muz";
            urun1.Fiyati = 21;

            Urun urun2 = new Urun();
            urun2.Aciklama = "Çardak Elması";
            urun2.Adi = "Elma";
            urun2.Fiyati = 15;

            Urun urun3 = new Urun();
            urun3.Aciklama = "Yalova Armutu";
            urun3.Adi = "Armut";
            urun3.Fiyati = 11;

            Urun[] uruns = new Urun[] { urun1, urun2, urun3 };
            SepetManager sepetManager = new SepetManager();

            foreach (Urun urun in uruns ) {
               // Console.WriteLine(urun.Aciklama +" "+urun.Adi+" "+urun.Fiyati);
                sepetManager.Ekle(urun);
            }

            
           
        }
    }
}
//Do not repeat your self-DRY- Clean Code- Best Practice
//Metot geri kullanılabilirlik katar.

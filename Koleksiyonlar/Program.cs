using System;
using System.Collections.Generic;
using System.Linq;

namespace Koleksiyonlar
{
      internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
           
            // isimler.GroupJoin("İlker"); // This line is incorrect and not needed
           //  isimler = isimler.Append("İlker").ToArray(); // Correct way to append an item to an array
            //Yanlış kullanım : isimler[4] = "İlker"; // This line is incorrect and not needed
            //düzelmek için yapılan lakin referansı sıfırladığı için yeni bir dizi oluşturulur ve eski referansı kaybolur
            //isimler = new string[5]; // This line is incorrect and not needed
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);
            //Stack                          //Heap
            //Stack veriyi tutar 
            //Heap ise referans numaralarını tutar.
            //Listelerde referans numaraları tutulur ve bu referans numaraları heapte tutulur.
            //Classlar yeşil renklidir.
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            
            
        }
    }
}

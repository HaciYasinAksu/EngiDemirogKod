using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Math
{
    internal class MathFonksManager
    {
        public void Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1+sayi2;
            Console.WriteLine(sonuc);
        }
    }
}

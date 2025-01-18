using System;
using System.Collections.Generic;
using System.Text;

namespace Metots
{
    internal class SepetManager
    {
        // Manager Service Dal vb. görürseniz bu bunların bir operasyon tuttuğunun göstergesidir
        //Naming Convention 
        //Syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi."+ urun.Adi);
        }
    }
}

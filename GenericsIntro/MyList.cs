using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsIntro
{
    internal class MyList<T>
    //Ben mylistimde T ile çalışıcam demek ve bu T classlardan değer veri tipine her türlü veriyi ve parametreyi tutabilir.
    {
        T[] items;
        //Neden metodun dışında yazdım çünkü bu classın içindeki tüm metotlar bu arrayi kullanabilir.
        public MyList()
        {
            //constructor oluşturduk ve bu constructor sayesinde classı newlediğimizde otomatik olarak çalışacak.
            items = new T[0];
        }
        
        public void Add(T item)
        {
            int Tlength = items.Length; //Dizinin eleman sayısını tutar.
            T[] tempArray = items; //Geçici dizi oluşturduk ve items dizisini referans ettik.
            items = new T[items.Length + 1]; //Dizinin eleman sayısını bir arttırmak için yeni bir dizi oluşturduk.
            for (int i = 0; i < Tlength; i++)
            {
                items[i] = tempArray[i]; //Geçici dizideki elemanları items dizisine atadık.
            }
            items[items.Length-1] =item; //Yeni elemanı ekledik.
            items.Append(item);
            foreach (var item1 in items)
            {
                Console.WriteLine(item1);
               
            }
        }
    }
}

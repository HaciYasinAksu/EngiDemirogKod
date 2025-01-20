using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Entity - Varlık - Bir şeyi temsil eder. VERİ TABANINDA BİR TABLOYA KARŞILIK GELİR.
                  //CURD operasyonları yapılırken bu class kullanılır.Create Read Update Delete operasyonlarıdır.
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double UnıtPrice { get; set; }
        public int CategoryId { get; set; }
        //Referans alanlarıdır . Bu alanlar birbirine referans verir. 
        public int UnitsInStock { get; set; }
    }
}

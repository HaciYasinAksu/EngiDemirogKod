using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.ProductName = "Masa";
            product1.UnıtPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnıtPrice = 35 };
            //PascalCase   //camelCase
            //Case sensitive - büyük küçük harf duyarlılığı
            //Bunlar birbirinin alternatifi. İkisi de aynı şeyi yapar.Ayrıca bunlar gerçek hayattaki nesneleri temsil etmez.Gerçek hayatta veriler elle girilmez bir veri kaynağından gelir.
            //Angular ile ekrandan kullanıcı bilgileri alınır ve bu bilgileri bir nesneye atarız. Bu nesneyi de bir servise göndeririz. Bu servis de bu nesneyi veri tabanına kaydeder.
            //Bu nesne bir entitydir. Bu entity veri tabanındaki bir tabloya karşılık gelir. Bu entity üzerinde CURD operasyonları yapılır. Create Read Update Delete operasyonlarıdır.
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product1);
            //int double bool ... değer tip - stack - değeri tutar ve işi biter
            //diziler,class,abstract class,interface ... referans tip - heap - adresi tutar ve işi biter
        }
    }
}

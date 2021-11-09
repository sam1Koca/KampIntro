using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args) //Aşağıda iki şekilde özellik tanımlama yaptık.
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Keyboard";
            product1.UnitPrice = 455;
            product1.UnitsInStock = 2;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 11, ProductName = "Monitor", UnitPrice = 600 };

            //PascalCase   //camelCase
            // case sensitive - küçük/büyük harf duyarlı
            ProductManager productManager = new ProductManager(); 
            productManager.Add(product2);
            productManager.Update(product2);

            productManager.Topla2(4, 7);

            int toplamaSonucu = productManager.Topla(3, 6);

            Console.WriteLine(toplamaSonucu*2);
        }
    }
}

//int,double,decimal,bool... değer tip
//diziler,class,absract class,interface.... referans tip

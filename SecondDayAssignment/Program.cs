using System;

namespace SecondDayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Elma";
            product1.ProductStock = 23;
            product1.ProductPrice = 3;

            Product product2 = new Product();
            product2.ProductName = "Kavun";
            product2.ProductStock = 14;
            product2.ProductPrice = 6;

            Product product3 = new Product();
            product3.ProductName = "Karpuz";
            product3.ProductStock = 34;
            product3.ProductPrice = 7;


            Product[] products = new Product[] {product1, product2, product3 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + ": stokta " + products[i].ProductStock +" tane var " + products[i].ProductPrice + " TL");
            }

            Console.WriteLine("***** For loop is over *****\n");

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + " " + product.ProductPrice + " " + product.ProductStock);
            }

            Console.WriteLine("***** Foreach loop is over *****\n");

            int x = 0;
            while (x < products.Length)
            {
                Console.WriteLine(products[x].ProductName + " "+ products[x].ProductPrice + " " + products[x].ProductStock);
                x = x + 1;
            }

            Console.WriteLine("***** While loop is over *****\n");

        }
    }

    class Product
    {
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public int ProductPrice { get; set; }
    }
}

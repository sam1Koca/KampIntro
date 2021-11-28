using System;

namespace Constructors  
{
    class Program
    {
        static void Main(string[] args)
        {// new dedikten sonra bu blok direk çalıştı. Bu tip sınıflarda kolay kullanım için kullanılır.

            Customer customer1 = new Customer { Id = 1, FirstName = "Bill", LastName = "Gates", City = "California" };

            Customer customer3 = new Customer();
            customer3.Id = 1;

            Customer customer2 = new Customer(2,"Mark","Zuckerberg","Ankara"); //2. kullanımı sanki bir fonksiyonmuş gibi *
            // Bu kullanım için aşağıdaki constructor kümesine / metotuna parametreleri vermem gerekir. *Birincisi patlar
            // constructor yazarsak ayrı şekilde defaultu ezmiş oluruz. oyüzden overloading yapabiliriz

            Console.WriteLine(customer2.FirstName);
        }
    }

       
        class Customer
        {
        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, string city)  //ctor Bir metot gibi çalışır. Default Constructor
            {
            // Bu bloğu şuan yazdık veya yazmadık arka planda her türlü çalışır. Varsa yazdığımız yoksa arka planda ki
            FirstName = firstName;
            LastName = lastName;
            City = city;
            }

            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }

        // Bir önceki videoların kodlarına bak

        }
}









// Constructor nedir: Bir classı new lediğimiz anda çalışan bloktur.
// Yani bir class ilk kez oluştuğu zaman birkez çalışır ve birdaha çalışmaz.
// Constructor: Yapıcı Blok
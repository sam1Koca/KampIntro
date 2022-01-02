using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();
            // Demo2();

            ICustomerDal[] customerDals = new ICustomerDal[3] //3 Elemeanlı dizi oluşturdum 
            {   
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            


            Console.ReadLine();
        }

        private static void Demo2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 107,
                FirstName = "Bill",
                LastName = "Gates",
                Address = "Boston"
            };

            Student student = new Student
            {
                Id = 108,
                FirstName = "Mark",
                LastName = "Zuckerberg",
                Departmant = "Software Development / futures CEO"

            };


            manager.Add(customer);
            manager.Add(student);
        }
    }

    interface IPerson
    {
        // Soyut Nesne

         int Id { get; set; }
         string FirstName { get; set; }
         string LastName { get; set; }

    }

    class Customer : IPerson // Sende bir IPerson 'sun
    {
        // Somut Nesne
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

    }

    class Student : IPerson // Sende bir IPerson 'sun
    {
        // Somut Nesne
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson person) //Parametre olarak müşteri nesnesi alacağım - bana müşteri ver.
        {
            // Burada başta customer verdik fakat student gönderemedik / interface'in en iyi kullanım örneği burası - hepsi bir IPerson
            Console.WriteLine(person.FirstName);
        }

    }
}





/* ! NOTES !
 * 
 * İsimlendirme olarak "interface" kullanılır (ex. class vs. yerine)
 
 * Okunuşunun kolaylığı - bulunmasının kolaylığı gibi nedenlerden dolayı Başına " I " koyulur. *Doğru yazılışı - yapılışı
  
 * En büyük kullanım amacı bir temel nesne oluşturup / operasyon oluşturup bütün nesneleri ondan implemente etmektir.
 * 
 * Classlara somut nesne İnterface'lere ise soyut nesne denir. Soyut nesne tek başına hiçbirşey ifade etmez.
 * 
 * İnterface kendi başına new'lenemez. (Abstract vs. gibi soyut nesnelerde dahil)
 */


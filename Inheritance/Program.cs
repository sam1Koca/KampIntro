using System;

namespace Inheritance // Kalıtım - İnterface'lerde inheritance gibi kullanılırlar fakat aynı değillerdir
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Mark" },
                new Student{FirstName = "Mittnick" },
                new Person{FirstName = "Bill"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }


            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Person2
    {
        
    }

    class Customer : Person //Customer'ın ebeveyni Persondur.
    {
        // Bir çocuk ebevninin özellikleri tamıtamına taşıyamaz farklı şeylerde olur:
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Departmant { get; set; }
    }
}

// İnterfaceden farklı olarak 1 nesneyi birkere inherit yapabilirsiniz.
//Kural: Inheritance once sonrasında interfaceler yazılır == a : Person,IEat,ISalary


// Inheritance ve Interface arasında karar vermek:
// * Böyle bir senaryoda Interface kullanmak doğru olur - ınherit yerinede kullanılır çünkü
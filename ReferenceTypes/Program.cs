using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // value types..int,decimal,boolean,float
            int sayi1 = 10; //sayı1'in *değeri =10
            int sayi2 = 20; //sayı2'nin *değeri =20

            sayi1 = sayi2; //sayı1'in *değeri = sayı2'nin *değeri  Buradan sonra sayi2 değişkeni ile bağlantı kalmıyor

            sayi2 = 100;

            //Console.WriteLine("Sayı 1 : " + sayi1);



            //reference Types...arrays, class, interface

            int[] sayilar1 = new int[] { 1, 2, 3 };  //Arrays Oluşturduk  *Biz new dedikten sonra bellekte(heap'ta) yer-adres oluşuyor 
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2; //sayılar1'in /adresi = sayılar2'nin *adresi
            sayilar2[0] = 1000;

            // Console.WriteLine("Sayılar1[0] : " + sayilar1[0]);


            Person person1 = new Person();  
            Person person2 = new Person();
            person1.FirstName = "Steve";

            person1 = person2;  //person2'ninde firstName'i "Steve" dir.
            person1.FirstName = "Bill"; 

            // Console.WriteLine(person2.FirstName); // ikisinin de adresi adresi aynı person1 = person2; 

            Customer customer = new Customer();
            customer.FirstName = "Gates";
            customer.CreditCardNumber = "323232323";

            Employee employee = new Employee();
            employee.FirstName = "Jack";

            Person person3 = customer;  //person3 - customer için hiçbirşey demedi  person3 yine Customerin adrsini tutuyor.
            customer.FirstName = "Zuck"; //Burada aynı adresi değiştirmiş oluyoruz.
            //Person emmploye ve customer'in adresini tutabiliyor.

            // Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);   // istediğimi gönderebilirim. Yazılımda aynı kodu farklı nesneler için çalıştırmamı sağlar

        }
    }

    // person = kişi  -  Customer = müşteri
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //CreditCardNumber var.
        //EmployeeNumber var.
    }

    // Aşağıda yaptığımız işlem " : "  Inheritance işlemidir.  

    //base class : Person  - Temel sınıf

    class Customer:Person //Customer bir Person'dur.  -- Müşteri bir kişidir.
    {
        public string CreditCardNumber { get; set; }
    }


    class Employee:Person // Employee aynı zamanda bir Persondur.   -- Employee bir kişidir.
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

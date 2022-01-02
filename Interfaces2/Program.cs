using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {//interface newlenemez
            IPersonManager customerManager = new CustomerManager(); //Bellekte - Heap kısmında referans değeri oluşur.
            
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);

            projectManager.Add(new InternManager());



            //İnterfaceler onu implemente eden classın referans numarasını tutabilir
        }
    }

    interface IPersonManager
    {
        // Unimplemented Operation -  default olarak public'tir
        void Add(); //İmza
        void Update();
            
    }

    //inherits - class ----------------------- implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // Müşteri ekleme Kodları.
            Console.WriteLine("Müşteri Eklendi...");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi...");
        }
    }

    class EmployeeManager : IPersonManager 
    {
        public void Add()
        {
            // Employee = Personel
            //Employee ekleme kodları..
            Console.WriteLine("Personel Eklendi...");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi...");
        }
    }

    class InternManager : IPersonManager  //Stajer Operasyon sınıfı - Yeni birşey ekledim ve kodum hiç bozulmadı
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi !");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi !");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}

// Yazılım Yaşayan Bir Organizmadır - Kodlarına Yeni birşeyler Eklediğinde birşeyler bozulmasın / bu şekilde yazmaya çalış...
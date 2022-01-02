using System;

namespace InterfacesDemo  //Çoklu implementasyon örneği 
{
    // SOLID - 4. Prensibini Uyguladık - Interface Segregation
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Robot(),
                new Worker()
            };

            foreach (var worker in workers)
            {
                worker.Work(); //Bütün çalışanlara çalış emri..

            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

        }
    }

    interface IWorker
    {
        // Çalışan için temel operasyonlar
        void Work();
    }

    interface IEat
    {
        // Yemek yiyenler için temel operasyonlar
        void Eat();
    }

    interface ISalary
    {
        // Maaş alanlar için temel operasyonlar
        void GetSalary();

    }


    class Manager : IWorker,ISalary,IEat 
    {
        public void Eat()
        {

        }

        public void GetSalary()
        {

        }

        public void Work()
        {

        }
    }

    class Worker : IWorker,IEat,ISalary
    {
        public void Eat()
        {

        }

        public void GetSalary()
        {

        }

        public void Work()
        {

        }
    }

    class Robot : IWorker // !
    {
        public void Work()
        {

        }
    }
}

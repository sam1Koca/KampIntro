using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    //Data Acces Layer - Veritabanı işlemlerini burada yaparız(update,delete vs.)
    public interface ICustomerDal 
    {
        //Burada Polimorfizim(Çok biçimlilik) yaptık. Bir nesneyi farklı amaçlarla implemente ederek kullandık
        void Add();
        void Update();
        void Delete();

        //Senaryo Her veritabanı markası / ürünü için ortak bir operasyon yazmak
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Added");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Deleted");
        }

        public void Update()
        {
            Console.WriteLine("SQL Updated");
        }
    }


    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }


    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySQL Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySQL Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySQL Updated");
        }
    }


    public class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();

        }
    }
}

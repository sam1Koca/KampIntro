using InterfaceAbstractDemo.Abstract;
using System;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer:IEntity //Müşteri
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; } // doğum tarihi
        public long NationalyId { get; set; } //kimlik numarası

    }
}

// Somut sınıflar * yani burası gibi Inherit almıyorsa ilerde mutlaka nesnellik zafiyeti yaşarsın

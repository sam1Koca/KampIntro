using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Hook" && gamer.LastName == "Berg" && gamer.DateOfBirth == new DateTime(1994, 3, 21) 
                && gamer.TcNo == "123456")
            {
                Console.WriteLine("Bilgiler Doğrulandı...............");
                return true;
                
            }

            else
            {
                Console.WriteLine("Bilgiler Karşılaştırılırken Hatayla Karşılaşıldı....................");
                return false;
            }
        }
    }
}

using System;
using GameProjectDemo.Entities;
using GameProjectDemo.Concrete;
using GameProjectDemo.Abstract;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            { 
                FirstName = "Hook",
                LastName = "Berg",
                Id = 1,
                TcNo = "123456",
                DateOfBirth = new DateTime(1994, 3, 21) 
            };

            Gamer gamer2 = new Gamer
            {
                FirstName = "Xenon",
                LastName = "Handler",
                Id = 2,
                TcNo = "6664166",
                DateOfBirth = new DateTime(2001, 8, 13)
            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Update(gamer2);

            Console.WriteLine("Gamer Manager Methods Soon.........................................................\n");

            OrderManager orderManager = new OrderManager();

            orderManager.Order(gamer1, new NewCampaignManager());

            orderManager.Order(gamer2, new UpdateCampaignManager());

            Console.WriteLine("Gamer Manager Methods Soon.........................................................\n");
        }
    }
}

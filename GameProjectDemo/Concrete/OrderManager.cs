using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;
using GameProjectDemo.Abstract;

namespace GameProjectDemo.Concrete
{
    public class OrderManager
    {
        public void Order(Gamer gamer, ICampaignService campaignService)
        {
            campaignService.RunCampaign(); // Kampanya Tanımlama

            Console.WriteLine("To the Player named as " + gamer.FirstName + " " + gamer.LastName + " " + " " + 
                " above campaign action defined succesfully ");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public class NewCampaignManager : ICampaignService
    {
        public void NewCampaign()
        {
            Console.WriteLine("New Campaign Added !");
        }

        public void RemoveCampaign()
        {
            Console.WriteLine("Campaign Successfully Removed !");
        }

        public void RunCampaign()
        {
            Console.WriteLine("New Campaign Defined Succesfully!");
        }

        public void UpdateCampaign()
        {
            Console.WriteLine("Campaign Successfully Updated !");
        }
    }
}

using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class UpdateCampaignManager : ICampaignService
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
            Console.WriteLine("NewCampaign Defined Succesfully!");
        }

        public void UpdateCampaign()
        {
            Console.WriteLine("Campaign Updated Succesfully!");
        }
    }
}

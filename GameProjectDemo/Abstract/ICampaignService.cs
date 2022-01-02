using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ICampaignService // Kampanya İçin interface
    {
        public void RunCampaign(); // Kampanya Girişi
        public void NewCampaign(); // Yeni Kampanya
        public void RemoveCampaign(); //Kampanya Kaldır
        public void UpdateCampaign(); // Kampanya Güncelle
    }

}

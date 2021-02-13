using System;
using System.Collections.Generic;
using System.Text;
using DemoOyun.Abstract;
using DemoOyun.Entities;

namespace DemoOyun.Concrete
{
    public class SalesManager:ISalesService
    {
        public void GameSale(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + "sold to "+gamer.FirstName);
        }

        public void CampaignSale(Game game, Gamer gamer, Campaign campaignKodlama)
        {
            Console.WriteLine(campaignKodlama.CampaignName + " with " +
                              campaignKodlama.CampaignDiscount+ " discount rate "+ 
                              gamer.FirstName+" sold");
        }
    }
}

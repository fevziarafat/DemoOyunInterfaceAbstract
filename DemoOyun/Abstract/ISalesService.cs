using System;
using System.Collections.Generic;
using System.Text;
using DemoOyun.Entities;

namespace DemoOyun.Abstract
{
    public interface ISalesService
    {
        void GameSale(Game game, Gamer gamer);
        void CampaignSale(Game game, Gamer gamer, Campaign campaign);
    }
}

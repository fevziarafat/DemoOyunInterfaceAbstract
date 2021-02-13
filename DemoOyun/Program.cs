using System;
using DemoOyun.Abstract;
using DemoOyun.Adapter;
using DemoOyun.Concrete;
using DemoOyun.Entities;

namespace DemoOyun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FIFA player işlemeleri");
            Gamer fifaGamer = new Gamer()
            {
                FirstName = "fifaGamerManager Gamer FirstName",
                LastName = "fifaGamerManager LastName",
                NationalityId = "01234567890",
                YearOfBirth = new DateTime(2000, 1, 1)
            };
            FifaGamerManager fifaGamerManager = new FifaGamerManager(new GamerCheckManager());
            fifaGamerManager.Add(fifaGamer);
            Console.WriteLine();
            Console.WriteLine("CSGO player işlemeleri");

            Gamer csgoGamer = new Gamer()
            {
                FirstName = "csgoGamerManager Gamer FirstName",
                LastName = "csgoGamerManager LastName",
                NationalityId = "01234567890",
                YearOfBirth = new DateTime(2000, 1, 1)
            };
          
            CSGOGamerManager csgoGamerManager = new CSGOGamerManager(new GamerCheckManager());
            csgoGamerManager.Add(csgoGamer);
            Console.WriteLine();
            Console.WriteLine("Game İşlemleri");
            Game csgGame = new Game() { GameName = "CS Go", GamePrice = 1200 };
            Game fifaGame = new Game() { GameName = "Fifa 2020", GamePrice = 1900 };
            GameDal csgGameDal = new GameDal();
           
            csgGameDal.Add(csgGame);
            GameDal fifaGameDal = new GameDal();
            fifaGameDal.Add(fifaGame);

            Console.WriteLine();
            Console.WriteLine("Campaign İşlemleri");
            Campaign fifaCampaign = new Campaign() {CampaignDiscount = 10, CampaignName = "Covid 2020"};
            Campaign csgoCampaign = new Campaign() {  CampaignDiscount = 19, CampaignName = "Covid 2021 " };
            CampaignDal campaignDal = new CampaignDal();
            campaignDal.Add(fifaCampaign);
            campaignDal.Add(csgoCampaign);

            ISalesService salesService = new SalesManager();
            salesService.CampaignSale(fifaGame, fifaGamer, fifaCampaign);
            salesService.CampaignSale(csgGame, csgoGamer, csgoCampaign);
        }
    }
}

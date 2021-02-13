using System;
using System.Collections.Generic;
using System.Text;
using DemoOyun.Abstract;
using DemoOyun.Entities;

namespace DemoOyun.Concrete
{
    public class FifaGamerManager:BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public FifaGamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfPerson(gamer))
            {
                Console.WriteLine(StatesMessage.GamerIsValid);
                base.Add(gamer);
            }
            else
            {
                throw new Exception(StatesMessage.NotValidGamer);
            }
        }
    }
}

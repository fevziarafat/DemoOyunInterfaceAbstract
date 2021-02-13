using System;
using System.Collections.Generic;
using System.Text;
using DemoOyun.Abstract;
using DemoOyun.Entities;

namespace DemoOyun.Concrete
{
    public class CSGOGamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public CSGOGamerManager(IGamerCheckService gamerCheckService)
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

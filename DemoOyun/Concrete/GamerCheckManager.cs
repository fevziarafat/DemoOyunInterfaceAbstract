using System;
using System.Collections.Generic;
using System.Text;
using DemoOyun.Abstract;
using DemoOyun.Entities;

namespace DemoOyun.Concrete
{
    public class GamerCheckManager:IGamerCheckService
    {
        public bool CheckIfPerson(Gamer gamer)
        {
            return true;
        }
    }
}

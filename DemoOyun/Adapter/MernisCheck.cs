using System;
using System.Collections.Generic;
using System.Text;
using DemoOyun.Abstract;
using DemoOyun.Concrete;
using DemoOyun.Entities;

namespace DemoOyun.Adapter
{
    public class MernisCheck:IGamerCheckService
    {
        public bool CheckIfPerson(Gamer gamer)
      {
          return true;
      }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DemoOyun.Entities;

namespace DemoOyun.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfPerson(Gamer gamer);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DemoOyun.Abstract;
using DemoOyun.Entities;

namespace DemoOyun.Concrete
{
    public class GameDal:IBaseDal<Game>
    {
        public void Add(Game entity)
        {
            Console.WriteLine("Game Added " + entity.GameName);
        }

        public void Update(Game entity)
        {
            Console.WriteLine("Game Updated " + entity.GameName);
        }

        public void Delete(Game entity)
        {
            Console.WriteLine("Game Deleted " + entity.GameName);
        }
    }
}

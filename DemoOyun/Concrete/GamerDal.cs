using System;
using System.Collections.Generic;
using System.Text;
using DemoOyun.Abstract;
using DemoOyun.Entities;

namespace DemoOyun.Concrete
{
    public class GamerDal:IBaseDal<Gamer>
    {
        public void Add(Gamer entity)
        {
            Console.WriteLine("Gamer Added " + entity.FirstName+" "+entity.LastName);
        }

        public void Update(Gamer entity)
        {
            Console.WriteLine("Gamer Updated " + entity.FirstName + " " + entity.LastName);
        }

        public void Delete(Gamer entity)
        {
            Console.WriteLine("Gamer Deleted " + entity.FirstName + " " + entity.LastName);
        }
    }
}

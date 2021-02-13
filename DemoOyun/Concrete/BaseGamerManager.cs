using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using DemoOyun.Abstract;
using DemoOyun.Entities;

namespace DemoOyun.Concrete
{
    public class BaseGamerManager:IBaseDal<Gamer>
    {
        public virtual void Add(Gamer entity)
        {
           Console.WriteLine("Saved to db "+entity.FirstName);
        }

        public void Update(Gamer entity)
        {
            Console.WriteLine("Updated to db " + entity.FirstName);
        }

        public void Delete(Gamer entity)
        {
            Console.WriteLine("Deleted to db " + entity.FirstName);
        }
    }
}

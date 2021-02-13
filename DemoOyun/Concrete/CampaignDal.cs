using System;
using System.Collections.Generic;
using System.Text;
using DemoOyun.Abstract;
using DemoOyun.Entities;

namespace DemoOyun.Concrete
{
    public class CampaignDal:IBaseDal<Campaign>
    {
        public void Add(Campaign entity)
        {
            Console.WriteLine("Campaign Added " + entity.CampaignName);
        }

        public void Update(Campaign entity)
        {
            Console.WriteLine("Campaign Updated " + entity.CampaignName);
        }

        public void Delete(Campaign entity)
        {
            Console.WriteLine("Campaign Deleted " + entity.CampaignName);
        }
    }
}

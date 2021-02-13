using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using DemoOyun.Abstract;

namespace DemoOyun.Entities
{
    public class Campaign:IEntity
    {
        public string CampaignName { get; set; }
        public int CampaignDiscount { get; set; }
    }
}

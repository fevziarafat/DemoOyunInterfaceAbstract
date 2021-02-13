using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using DemoOyun.Abstract;

namespace DemoOyun.Entities
{
    public class Game:IEntity
    {
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}

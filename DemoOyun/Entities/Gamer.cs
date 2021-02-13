using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using DemoOyun.Abstract;

namespace DemoOyun.Entities
{
   public class Gamer:IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime YearOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}

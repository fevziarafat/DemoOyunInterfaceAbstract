using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DemoOyun.Concrete
{
   public static class StatesMessage
    {
        public static string NotValidGamer
        {
            get { return "Not a valid person please check your personality data"; }
        }
        public static string GamerIsValid
        {
            get { return "Gamer is valid person"; }
        }
    }
}

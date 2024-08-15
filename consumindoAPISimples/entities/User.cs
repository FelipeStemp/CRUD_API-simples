using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoAPISimples.entities
{
    internal class User
    {
        public string _id { get; set; }
        public string username { get; set; }

        public string email { get; set; }

        public int idade { get; set; }

        public authentication authentication { get; set; }

        public string password { get; set; }
    }

    public class authentication
    {
        public string password { get; set; }
    }
}
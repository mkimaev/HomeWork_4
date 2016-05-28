using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myhomework_4
{
    class Animal
    {
        public string Name { get; set; }
        [Colorat(MaxiColor.Blue)]
        public string Country { get; set; }
        public Animal(string name, string country)
        {
            Name = name;
            Country = country;
        }
    }
}

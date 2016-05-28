using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myhomework_4
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Colorat : Attribute
    {
        public MaxiColor Name { get; set; }
        public Colorat() { }
        public Colorat(MaxiColor cc)
        {
            Name = cc;
        }
        public void Painted()
        {
            if (Name == MaxiColor.Blue)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (Name == MaxiColor.Yellow)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
    }
}

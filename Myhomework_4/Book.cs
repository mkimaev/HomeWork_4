using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myhomework_4
{
    class Book
    {
        [Colorat(MaxiColor.Yellow)]
        public string Name { get; set; }
        [Colorat(MaxiColor.Yellow)]
        public string Autor { get; set; }
        public Book(string name, string autor)
        {
            Name = name;
            Autor = autor;
        }
    }
}

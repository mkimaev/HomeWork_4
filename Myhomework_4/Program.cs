using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myhomework_4
{
    class Program
    {

        static void Main(string[] args)
        {
            ColorClass cl = new ColorClass();
            Animal krot = new Animal("Krot", "Ukraine");
            Book book = new Book("War and peece", "Lev Tolstoy");
            cl.ColorPrint(krot);
            cl.ColorPrint(book);
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Myhomework_4
{
    class ColorClass
    {
        public void ColorPrint(object obj)
        {
            Type t = obj.GetType();
            foreach (PropertyInfo prop in t.GetProperties())
            {
                object[] attr = prop.GetCustomAttributes(typeof(Colorat), false);
                foreach (Colorat atr in attr)
                {
                    atr.Painted();
                }
                Console.WriteLine(prop.DeclaringType + " " + prop.MemberType + " " + prop.PropertyType + " " + prop.Name + " " + "\"" + prop.GetValue(obj) + "\"");
            }
            Console.ForegroundColor = ConsoleColor.White;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class methods
    {
        // 3.2
       public static bool Objetivo(string[] strings, string objetivo)
        {
            return strings.Contains(objetivo);
        }

        // 3.3
       public static string[] empiezaConJuan(string[] arr)
        {
            string[] res = arr.Where(a => a.Contains("Juan")).ToArray();
            return res;
        }

        // 3.4
        public static string[] Saludar(string[] arr)
        {
            string[] saludo = arr.Select(a => "Hola " + a).ToArray();
            return saludo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>()
            {
                3, 1, 7, 4, 5
            };

            // 2.1 List pares
            List<int> pares = list.FindAll(x => x % 2 == 0);
            
            foreach (int p in pares)
                Console.WriteLine(p);

            // 2.2 Listar impares
            List<int> impares = list.FindAll(x => x % 2 != 0);

            foreach (int p in impares)
                Console.WriteLine(p);

            // 2.3 Listar en orden ascendente
            List<int> listaAsc = list.OrderBy(x => x).ToList();

            foreach (int p in listaAsc)
                Console.WriteLine(p);

            // 2.4 Listar en orden descendente
            List<int> listaDesc = list.OrderByDescending(x => x).ToList();

            foreach (int p in listaDesc)
                Console.WriteLine(p);

            // 2.5 Revisar si numero es multiplo de 3
            Func<int, bool> multiplo = x => x % 3 == 0;

            Console.ReadKey();
        }


    }
}

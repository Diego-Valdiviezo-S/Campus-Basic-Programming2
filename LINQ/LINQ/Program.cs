using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 3.1 Arreglo descendente
             string[] nombres = new string[] { "Juan", "Pablo", "Pedro", "Pepe", "Ana", "Esteban", "Daniel", "Mariano", "Carolina", "Silvia", "Roberto", "Juanito", "Juana" };
            IEnumerable<string> nombresOrdenados = from n in nombres orderby n descending select n;
            
            foreach (string s in nombresOrdenados)
                    Console.WriteLine(s);
            
            // 3.2 Encontrar string objetivo 
            var contiene = methods.Objetivo(nombres, "Pepe");
            
            Console.WriteLine(contiene);
              
            // 3.3 Encontrar si nombre empieza con Juan
            string[] arrJuan = methods.empiezaConJuan(nombres);

             foreach (string str in arrJuan)
                 Console.WriteLine(str);

             // 3.4 Concatenar nombres con hola
            string[] arrSaludar = methods.Saludar(nombres);
           
            foreach (string saludo in arrSaludar)
                Console.WriteLine(saludo);
           


















        }   

    }
}

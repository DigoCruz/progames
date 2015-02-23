using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DataHora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtem a data atual e guarda na variavel
            DateTime Atual_DataHora = DateTime.Now;

            // Exibe a data em diversos formatos            
            Console.WriteLine(Atual_DataHora.ToShortDateString());
            Console.WriteLine(Atual_DataHora.ToShortTimeString());
            Console.WriteLine(Atual_DataHora.ToLongDateString());
            Console.WriteLine(Atual_DataHora.ToLongTimeString());
           
            Console.ReadKey();


        }
    }
}

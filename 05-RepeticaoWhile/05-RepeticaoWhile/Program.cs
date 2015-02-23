using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_RepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * O comando while ira repetir um bloco de comandos enquanto a condicao
             * declarada for satisfeita
             * 
             */
            
            // Declarado a variavel n
            int n = 0;

            /*
             * Laco de repeticao com while
             * contagem de 0 até 10
             * 
             */

            while(n <= 10)
            {
                Console.WriteLine(n);
                n++;               
            }

            // Aguarda uma tecla ser pressionada
            Console.ReadKey();

        }
    }
}

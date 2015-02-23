using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CondicaoIf
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * A seguir será mostrado o uso do comando if (SE), comando usado 
             * para comparar situações e fazer tomada de decisões.
             * 
             */

            // E declarada uma variavel numero do tipo string
            string Numero;

            // É emitida uma mensagem para o usuario e o prompt fica aguarda a entrada de dado
            Console.Write("Digite um número de 0 até 10: ");
            Numero = Console.ReadLine();

            // Aqui é feita a comparação, no que há uma conversão pois o dado de entrada é uma string
            if (Convert.ToDecimal(Numero) > 5)
            {
                Console.Write("Numero maior que 5");
            }
            else if(Convert.ToDecimal(Numero) < 5)
            {
                Console.Write("Numero menor que 5");
            }
            else
            {
                Console.Write("Numero igual a 5");
            }

            Console.ReadKey();
        }
    }
}

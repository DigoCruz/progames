using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepeticaoDo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Mais uma forma de executar um bloco de instruções por n vezes até que a condição
             * encerre sua execução.
             * Diferente do While que verifica a condição no inicio o Do verifica a condição no final
             * portanto ao menos 1 vez o bloco de comandos será executado
             * 
             */

            // Inicia a variavel n
            int n = 10;
                        
            /*
             * O comando do irá executar uma contagem até que n seja < 10 
             * note que o valor exibido será 11 pois o bloco de comando
             * 
             */
            do
            {

                n++;
                Console.WriteLine(n);
               
            } while (n < 10);

            // Aguarda ate que uma tecla seja pressionada
            Console.ReadKey();

        }
    }
}

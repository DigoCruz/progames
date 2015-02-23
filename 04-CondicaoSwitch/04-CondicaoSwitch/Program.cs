using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CondicaoSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Iremos agora ver como fazer N comparações
             * entre um valor
             *  
             */

            // Inicializado uma variavel para coletar o dado passado pelo usuario
            string numero;

            // Exibe mensagem na tela e coleta o dado digitado pelo usuario
            Console.Write("Digite um valor entre 1 ate 3: ");
            numero = Console.ReadLine();

            // O dado da variavel numero e transferida para n e convetida de string para int
            int n = Convert.ToInt32(numero);

            // Com switch e feita as comparacoes dos valores e emitda uma mensagem conforme condicao
            switch(n)
            {
                case 1:
                    Console.Write("n = 1");
                    break;
                case 2:
                    Console.Write("n = 2");
                    break;
                case 3:
                    Console.Write("n = 3");
                    break;
                default:
                    Console.Write("n não é 1, 2 ou 3");
                    break;
            }

            // Aguardando uma tecla ser pressionada para encerrar o programa
            Console.ReadKey();

        }
    }
}

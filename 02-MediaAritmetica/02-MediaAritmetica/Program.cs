using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Inicia duas variáveis para armazenar as notas do tipo float
             */

            float Nota_A;
            float Nota_B;

            /*
             * Exibe uma mensagem na tela e lê a nota digitada
             * ao ler o dado este é convertido para float, 
             * pois toda entrada de dado é considerada uma string
             */
            Console.WriteLine("Infome a nota A: ");
            Nota_A = float.Parse(Console.ReadLine());

            Console.WriteLine("Infome a nota B: ");
            Nota_B = float.Parse(Console.ReadLine());
            
            /*
             * Calcula a média e exibe na tela, convertando o valor para 
             * string já que o mesmo era float
             */

            float Media = ((float)Nota_A + (float)Nota_B) / 2;     

            Console.Write("Sua média é: " + Media.ToString());

            Console.ReadKey();
        }
    }
}

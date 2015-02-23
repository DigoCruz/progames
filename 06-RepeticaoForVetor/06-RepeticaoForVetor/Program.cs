using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepeticaoForVetor
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Contador com comando for
             * ele executará um bloco de comandos enquanto sua contagem não atingir o valor
             * da condicao
             * 
             */

            // Inicializado um vetor de 7 posicoes do tipo string
            string[] semana = new string[7];

            // Dados atribuidos ao vetor
            semana[0] = "domingo";
            semana[1] = "segunda";
            semana[2] = "terca";
            semana[3] = "quarta";
            semana[4] = "quinta";
            semana[5] = "sexta";
            semana[6] = "sabado";

            // Laco for para exibir os valores do vetor
            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine(semana[i]);
            }

            // Aguarda uma tecla ser pressionada
            Console.ReadKey();
            
        }
    }
}

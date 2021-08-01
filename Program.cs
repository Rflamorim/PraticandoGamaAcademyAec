using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPratica
{
    class Program
    {
        static void Main(string[] args)

        /* faca programa leia o nome e o valor de duas notas de aluno depois
         * faca a media das duas notas a media da duas notas ,
         * se media ficou maior 5 aluno aprvado menor que 5 aluno reprovado*/

        /*se a nota for entre 0, você não aprendeu nada
           se a nota for entre 1 a 4 você está reprovado
           se a nota for entre 5 a 7 você passou raspando
           se a nota for 8 ou 9 você mandou bem
           se a nota for 10, parabéns vc é muito inteligente*/

        /*Danilo é um professor de matemática e ele precisa de um programa para calcular a tabuada, 
         * faça um programa que solicite o número da tabuada e mostre na tela o resultado.*/
        {
            Console.WriteLine("DIGITE NOME DO ALUNO");
            String aluno = Console.ReadLine();
            Console.WriteLine("DIGITE NOTA DO ALUNO");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DIGITE NOTA DO ALUNO");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double mediaaluno = (nota1 + nota2) / 2;

            if (mediaaluno >= 5)
            {
                Console.WriteLine($" Aluno {aluno} foi aprovado");

            }
            else

            {
                Console.WriteLine($" Aluno {aluno} foi reprovado");
            }
        }
    }
}

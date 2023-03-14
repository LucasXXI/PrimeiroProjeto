using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Condicionais
    {
        public static void Condicao()
        {
            int a = 10;
            if( a == 1)
            {
                Console.WriteLine("Ola");
            }
            else
            {
                Console.WriteLine("Funcionando");
            }
        }

        public static void Exercicio1() 
        {
            Console.WriteLine("Digite um numero INTEIRO abaixo:");
            int a = int.Parse(Console.ReadLine());

            if( a % 2 == 0) {
                Console.WriteLine($"o valor digitado foi {a}, e este é PAR");
            }
            else{
                Console.WriteLine($"O valor digitado foi {a} e este é IMPAR");
            }


        }

        public static void Exercicio2()
        {
            Console.WriteLine("Digite abaixo o horario atual (somente as horas)");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine($"Bom dia, a hora atual é {hora}hr");
            }
            else if (hora < 18) //aqui a condicao de cima ja foi anulada e ele pulou pra proxima
            {
                Console.WriteLine($"Boa tarde, a hora atual é {hora}hr");
            }
            else
            {
                Console.WriteLine($"Boa noite, a hora é {hora}hr");
            }
              
        }

        public static void Exercicio3()
        {

        }
    }
}

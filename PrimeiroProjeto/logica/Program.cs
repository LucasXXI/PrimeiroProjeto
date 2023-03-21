using PrimeiroProjeto.logica;
using PrimeiroProjeto.poo;
using PrimeiroProjeto.poo.exerciciosClasses;
using PrimeiroProjeto.poo.construtores;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
           Banco b = new Banco();

            Console.WriteLine("-----BANCO----");
            Console.Write("Entre o numero da conta: ");
            b.Numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o Titular da conta: ");
            b.Titular = Console.ReadLine();

            Console.Write("Haverá Deposito inicial? (s/n) ");
            char c = char.Parse(Console.ReadLine());

            while(c != 'S' || c != 's' || c != 'n' || c !=  'N')
            {
                if (c == 's' || c == 'S')
                {
                    Console.Write("Entre o valor do deposito: ");
                    double valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    b.Deposito(valorDep);

                    Console.WriteLine("Dados da conta:");
                    Console.WriteLine(b);

                    Console.WriteLine();
                    Console.WriteLine("Entre um valor para deposito: ");
                    valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    b.Deposito(valorDep);
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.Write(b);

                    Console.WriteLine();
                    Console.Write("Entre um valor para saque: ");
                    double valSaq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    b.Saque(valSaq);
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.Write(b);
                }
                else if (c == 'n' || c == 'N')
                {
                    Console.WriteLine("Dados da conta:");
                    Console.WriteLine(b);

                    Console.WriteLine();
                    Console.WriteLine("Entre um valor para deposito: ");
                    double valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    b.Deposito(valorDep);
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.Write(b);

                    Console.WriteLine();
                    Console.Write("Entre um valor para saque: ");
                    double valSaq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    b.Saque(valSaq);
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.Write(b);
                }
            }
        }
    }
}
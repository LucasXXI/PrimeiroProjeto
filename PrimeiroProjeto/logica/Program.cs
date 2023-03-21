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
            Banco banco;

            Console.WriteLine("-----BANCO----");
            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o Titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá Deposito inicial? (s/n) ");
            char c = char.Parse(Console.ReadLine());

                if (c == 's' || c == 'S')
                {
                    Console.Write("Entre o valor do deposito: ");
                    double valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    banco = new Banco(numero, titular, valorDep);
                    

                    Console.WriteLine("Dados da conta:");
                    Console.WriteLine(banco);

                    Console.WriteLine();
                    Console.WriteLine("Entre um valor para deposito: ");
                    valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    banco.Deposito(valorDep);
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.Write(banco);

                    Console.WriteLine();
                    Console.Write("Entre um valor para saque: ");
                    double valSaq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    banco.Saque(valSaq);
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.Write(banco);
                }
                else if (c == 'n' || c == 'N')
                {
                    banco = new Banco(numero, titular);
                    Console.WriteLine("Dados da conta:");
                    Console.WriteLine(banco);
                    

                    Console.WriteLine();
                    Console.WriteLine("Entre um valor para deposito: ");
                    double valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    banco.Deposito(valorDep);
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.Write(banco);

                    Console.WriteLine();
                    Console.Write("Entre um valor para saque: ");
                    double valSaq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    banco.Saque(valSaq);
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.Write(banco);
                }
            }
        }
    }
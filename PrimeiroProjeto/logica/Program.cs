using PrimeiroProjeto.logica;
using PrimeiroProjeto.poo;
using PrimeiroProjeto.poo.exerciciosClasses;
using PrimeiroProjeto.poo.construtores;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using PrimeiroProjeto.poo.Structs;
using PrimeiroProjeto.vetores;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos produtos voce quer adicionar?: ");
            int n = int.Parse(Console.ReadLine());

            VetoresProdutos[] vect = new VetoresProdutos[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite um nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Digite um preço para o produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new VetoresProdutos { Name = name, Price = price };

            }

            double sum = 0.0;
            for(int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.Write("AVARAGE PRICE': " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
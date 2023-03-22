using PrimeiroProjeto.logica;
using PrimeiroProjeto.poo;
using PrimeiroProjeto.poo.exerciciosClasses;
using PrimeiroProjeto.poo.construtores;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using PrimeiroProjeto.poo.Structs;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas alturas voce quer adicionar?");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite uma Altura: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            foreach(double element in vect)
            {
                Console.WriteLine(element.ToString("F2", CultureInfo.InvariantCulture));
            }

            double avg = vect.Sum() / n;

            Console.Write("AVARAGE HEIGHT: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
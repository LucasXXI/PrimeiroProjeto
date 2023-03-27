using PrimeiroProjeto.logica;
using PrimeiroProjeto.poo;
using PrimeiroProjeto.poo.exerciciosClasses;
using PrimeiroProjeto.poo.construtores;
using System.Globalization;
using PrimeiroProjeto.poo.Structs;
using PrimeiroProjeto.vetores;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            
            int[,] mat = new int[i, i];

            for(int n = 0; n < i; n++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < i; j++)
                {
                    mat[n, j] = int.Parse(values[j]);
                }
            }
            //search for the main diagonal elements of mat
            Console.WriteLine("Diagonal Principal");
            for(int a = 0; a < i; a++)
            {
                Console.WriteLine(mat[a, a] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for(int n = 0; n < i; n++)
            {
                for(int j = 0; j < i; j++)
                {
                    if (mat[n, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative number: " + count);
        }
    }
}

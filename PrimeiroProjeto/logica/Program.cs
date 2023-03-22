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
            Hotel[] reserva = new Hotel[10]; 

            Console.WriteLine("Serão quantas reservas?");
            int r = int.Parse(Console.ReadLine());


            for(int i  = 1; i <= r; i++)
            {
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string cliente = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                reserva[quarto] = new Hotel(cliente, email);
            }


            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");
            for(int i = 0; i < 10;  i++)
            {
                if (reserva[i] != null)
                {
                    Console.WriteLine(i + ": " + reserva[i]);
                }
            }

        }
    }

}

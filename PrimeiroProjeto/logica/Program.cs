using PrimeiroProjeto.logica;
using PrimeiroProjeto.poo;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da cotacao: ");
            double cotacao1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );

            Console.Write("Digite uma quantia: ");
            double quantia1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            double total = Moedas.Cambio(cotacao1, quantia1);
            Console.WriteLine("Valor total do Cambio: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
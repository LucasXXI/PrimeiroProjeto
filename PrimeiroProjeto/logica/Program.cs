using PrimeiroProjeto.logica;
using PrimeiroProjeto.poo;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo(); 
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do Triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(p * (p - y.A) * (p-y.B) * (p-y.C));

            Console.WriteLine("Area do Triangulo X: " + areaX.ToString("F3"));
            Console.WriteLine("Area do Triangulo Y: " + areaY.ToString("F3"));
            
            if(areaX > areaY)
            {
                Console.WriteLine("Area X é MAIOR");

            }else if(areaX == areaY)
            {
                Console.WriteLine("As areas sao IGUAIS");
            }
            else
            {
                Console.WriteLine("Area Y é MAIOR");
            }
        }
    }
}
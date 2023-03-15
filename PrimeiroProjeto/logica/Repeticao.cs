using System.Globalization;

namespace PrimeiroProjeto
{
    class Repeticao
    {
        public static void RepeticaoExercicio1() {

            Console.WriteLine("Digite um numero abaixo:");
            double input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorCalculado = Raiz(input);

            while(valorCalculado >= 0.0) //verificar se essa é a melhor implementacao
            {
                Console.WriteLine(valorCalculado.ToString("F3", CultureInfo.InvariantCulture ));
                Console.WriteLine("Digite um outro numero abaixo:");
                input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                valorCalculado = Raiz(input);
            }

            Console.WriteLine("Valor Negativo!");

            static double Raiz(double valor)
            {
                double raizQuadrada = Math.Sqrt(valor);

                return raizQuadrada;
            }
        }


    }
}

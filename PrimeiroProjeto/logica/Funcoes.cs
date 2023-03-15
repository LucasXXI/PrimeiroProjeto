namespace PrimeiroProjeto
{
    class Funcoes
    {
        public static void Funcao1()
        {
            Console.WriteLine("Digite 3 números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Calc(n1, n2, n3); //recursao?
            Console.WriteLine($"O maior valor é {resultado}");
        }
        static int Calc(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {

                m = b;
            }
            else
            {
                m = c;
            }

            return m;
        }
    }
}

namespace PrimeiroProjeto
{
    class RepeticaoFor
    {
        public static void TestandoFor()
        {
            Console.Write("Quantos numeros inteiros voce vai digitar? ");

            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            for(int i = 1; i <= n; i++)
            {
                Console.Write($"Valor #{i}:  ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma: {0}", soma);
        }
    }
}

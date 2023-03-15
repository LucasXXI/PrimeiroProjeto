namespace PrimeiroProjeto.logica
{
    class ExerciciosFor
    {
        public static void Exercicio1()
        {
            Console.WriteLine("Digite um valor entre 1 e 1000");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if( i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}

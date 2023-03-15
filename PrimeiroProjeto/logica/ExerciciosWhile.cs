namespace PrimeiroProjeto.logica
{
    class ExerciciosWhile
    {
        public static void Exercicio1()
        {
            Console.WriteLine("Digite uma senha");
            int senhaDigitada = int.Parse(Console.ReadLine());
            int senha = senhaDigitada;

            while(senha != 2002)
            {
                Console.WriteLine("Senha Inválida");
                Console.WriteLine("Digite Novamente uma senha:");
                senhaDigitada = int.Parse(Console.ReadLine());
                senha = senhaDigitada;
                

            }
            Console.WriteLine("Acesso Permitido!");
        }

        public static void Exercicio2()
        {
            Console.WriteLine("Digite o valor de duas coordenadas:");
            string[] coords = Console.ReadLine().Split(' ');

            int c1 = int.Parse(coords[0]);
            int c2 = int.Parse(coords[1]);

            while(c1 != 0 && c2 != 0)
            {
                if(c1 > 0 && c2 > 0)
                {
                    Console.WriteLine("PRIMEIRO QUADRANTE");
                }else if(c1 < 0 && c2 > 0)
                {
                    Console.WriteLine("SEGUNDO QUADRANTE");
                }
                else if( c1 < 0 && c2 < 0)
                {
                    Console.WriteLine("TERCEIRO QUADRANTE");
                }
                else
                {
                    Console.WriteLine("QUARTO QUADRANTE");
                }

                coords = Console.ReadLine().Split(' ');
                c1 = int.Parse(coords[0]);
                c2 = int.Parse(coords[1]);
            }

        }

        public static void Exercicio3()
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Digite uma das opções abaixo:");
            Console.WriteLine("1. Alcool, 2. Gasolina, 3. Diesel, 4. Fim");
            int escolha = int.Parse(Console.ReadLine());
            int x = escolha;

            while(x != 4)
            {
                if(x == 1)
                {
                    alcool += 1;
                }else if(x == 2)
                {
                    gasolina += 1;
                }else if(x == 3)
                {
                    diesel += 1;
                }
                else
                {
                    Console.WriteLine("Invalido!");
                }
            Console.WriteLine("1. Alcool, 2. Gasolina, 3. Diesel, 4. Fim");
            escolha = int.Parse(Console.ReadLine());
            x = escolha;
            }
            Console.WriteLine("Muito obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}

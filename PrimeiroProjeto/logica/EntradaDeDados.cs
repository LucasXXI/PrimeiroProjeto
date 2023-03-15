using System.Globalization;

namespace PrimeiroProjeto
{
    class EntradaDeDados
    {   
        public static void InputPt1()
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] aloha = frase.Split(' ');
            string p1 = aloha[0];
            string p2 = aloha[1];
            string p3 = aloha[2];

            Console.WriteLine($"Voce digitou:\n{frase}");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }

        public static void InputPt2A() 
        { 
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Voce digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(d);
        }

        public static void InputPt2B() 
        {
            string[] teste = Console.ReadLine().Split(" ");
            string nome = teste[0];
            char sexo = char.Parse(teste[1]);
            int idade = int.Parse(teste[2]);
            double altura = double.Parse(teste[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void InputFixacao() 
        {
            Console.WriteLine("Entre Com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o Preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade, e altura na mesma linha:");
            string[] linha = Console.ReadLine().Split(" ");
            string linha_nome = linha[0];
            int linha_idade = int.Parse(linha[1]);
            double linha_altura = double.Parse(linha[2], CultureInfo.InvariantCulture);
            Console.WriteLine("______________");


            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("______________");
            Console.WriteLine(linha_nome);
            Console.WriteLine(linha_idade);
            Console.WriteLine(linha_altura.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}

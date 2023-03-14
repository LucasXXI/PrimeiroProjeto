namespace PrimeiroProjeto
{
    class Operadores
    {
        public static void TestandoOp()
        {
            int a = 10;
            Console.WriteLine(a);

            a++;
            Console.WriteLine(a);

            a--;
            Console.WriteLine(a);
            
            a += 3;
            Console.WriteLine(a);

            a -= 3;
            Console.WriteLine(a);

            a *= 2;
            Console.WriteLine(a);

            a /= 2;
           Console.WriteLine(a);

            a %= 3;
            Console.WriteLine(a);

        }
        
        public static void Conversao()
        {
            float x = 4.5f;

            double y = x; //conversao implicita (double > float, logo isso é possivel)

            Console.WriteLine(y);

            double a;
            float b;

            a = 5.1;    
            b = (float)a; //CASTING - deve-se adicionar a conversao explicita passando o tipo da variavel entre parensetes
            Console.WriteLine(b);
        }   

        public static void AritmeticaTeste()
        {
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine(delta);

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a) ;
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}

namespace PrimeiroProjeto
{
    class Logicos
    {
        public static void TesteLogico()
        {
            bool c1 = 2 < 3 && 4 < 5; //true
            bool c2 = 2 > 3 || 4 > 5; //false usando valor logico ou
            bool c3 = 3 > 4 || !(4 < 5); //negando o valor logico da expressao usando !

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
        }
    }
}

namespace PrimeiroProjeto.poo
{
    class Moedas
    {
        public static double Iof = 6.0;

        public static double Cambio(double quantia, double cotacao)
        {
            double total  = quantia*cotacao;
            return total + total * Iof / 100;
        }
    }
}

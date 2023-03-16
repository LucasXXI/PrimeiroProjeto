using System.Globalization;

namespace PrimeiroProjeto.poo
{
    class Produto
    {
        public string NomeProduto;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString() //override para ao chamar a instancia da classe (dentro de uma concatenacao ou usando .ToString()) mostrar essa string abaixo
        {
            return NomeProduto 
                + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

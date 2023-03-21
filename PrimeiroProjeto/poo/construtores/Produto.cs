using System.Globalization;

namespace PrimeiroProjeto.poo.construtores
{
    class Produto
    {
        private string _nomeProduto;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //criando properties, dessa forma pode se acessar o atributo Nome, instanciando a classe e definindo get e set como funcoes para mostrar ou alterear os valores, de forma interna

        public Produto()
        {
        }
       
        public Produto(string nomeProduto, double preco, int quantidade)
        {
           NomeProduto = nomeProduto;
            Preco = preco;
            Quantidade = quantidade;
        }
        public string NomeProduto
        {
            get { return _nomeProduto; }
            set { 
                if(value != null &&  value.Length > 1) {
                _nomeProduto = value;} 
            }
        }

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

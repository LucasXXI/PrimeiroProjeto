using System.Globalization;

namespace PrimeiroProjeto.poo.construtores
{
    class Banco
    {
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public int Numero { get; private set; }

        public Banco(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;

        }

        public Banco(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo = (Saldo - quantia) - 5;
        }

        public override string ToString()
        {
            return
            " Conta "
                + Numero
                + " , "
                + "Titular: "
                + Titular
                + " , "
                + "Saldo: $  "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

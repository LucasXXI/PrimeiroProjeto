using System.Globalization;

namespace PrimeiroProjeto.poo.construtores
{
    class Banco
    {
        private string _titular;
        private double _saldo;
        private int _numero;
        
        public Banco()
        {
            Saldo = 0;
        }
        

        public string Titular
        {
            get { return _titular; }
            set {
                if(value != null && value.Length > 1) {
                    _titular = value;
                }
            }
        }

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }    
        }

        public void Deposito(double quantia)
        {
            _saldo += quantia;
        }

        public void Saque(double quantia)
        {
            _saldo = (Saldo - quantia) - 5;
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

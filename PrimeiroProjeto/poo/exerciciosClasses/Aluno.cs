namespace PrimeiroProjeto.poo.exerciciosClasses
{
    class Aluno
    {
        public double nota1, nota2, nota3;

        public double NotaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public bool Aprovado()
        {
            if(NotaFinal() >= 60.00) {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double QuantoFalta()
        {
            if (Aprovado())
            {
                return 0.0;
            }else{
                return 60.00 - NotaFinal();
            }
        }

    }
}

namespace ProjetoBanco
{
    public class Conta
    {
        public int CodigoDaConta { get; private set; }
        public string TitularDaConta { get; private set; }
        public double SaldoDaConta { get; private set; }

        public void Cadastrar(int codigoDaConta, string titularDaConta, double saldoDaConta)
        {
            this.CodigoDaConta = codigoDaConta;
            this.TitularDaConta = titularDaConta;
            this.SaldoDaConta = saldoDaConta;
        }




    }


}
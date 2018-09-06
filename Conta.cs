using System;

namespace ProjetoBanco
{
    public class Conta
    {
        public int CodigoDaConta { get; private set; }
        public string TitularDaConta { get; private set; }
        public double SaldoDaConta { get; private set; }

        public void Cadastrar(int codigoDaConta, string titularDaConta)
        {
            this.CodigoDaConta = codigoDaConta;
            this.TitularDaConta = titularDaConta;
            //this.SaldoDaConta = saldoDaConta;
        }

        public virtual void Depositar(double valorOperacao)
        {
            this.SaldoDaConta += valorOperacao;
        }

        public virtual bool Sacar(double valorOperacao)
        {
            if (this.SaldoDaConta >= valorOperacao)
            {
                this.SaldoDaConta -= valorOperacao;
                return true;
            }
            return false;
        }

        public virtual void Transferir(double valorOperacaoTransf, Conta destino)
        {
            this.Sacar(valorOperacaoTransf);
            destino.Depositar(valorOperacaoTransf);
        }
    }


}
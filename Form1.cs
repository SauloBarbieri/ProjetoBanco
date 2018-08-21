using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBanco
{
    public partial class Form1 : Form
    {

        Conta[] contas = new Conta[2];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas[0] = new ContaCorrente();
            contas[1] = new ContaPoupanca();
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            contas[0].Cadastrar(Convert.ToInt32(textoCodigo.Text), (textoTitular.Text), Convert.ToDouble(textoSaldo.Text));
            MessageBox.Show("Cadastro Realizado com Sucesso!");

            textoCodigo.Text = "";
            textoTitular.Text = "";
            textoSaldo.Text = "";
                        
        }

        private void botaoExibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Código da Conta: " +contas[0].CodigoDaConta);
            MessageBox.Show("Titular da Conta: " +contas[0].TitularDaConta);
            MessageBox.Show("Saldo da Conta: R$ " +contas[0].SaldoDaConta);
        }
    }
}

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
    public partial class formExtrato : Form
    {
        public formExtrato()
        {
            InitializeComponent();
        }

        private void botaoExtrato_Click(object sender, EventArgs e)
        {
            Form1 formularioPrincipal = new Form1();
            //formDeposito formularioDeposito = new formDeposito();
            FormCadastroConta formularioCadastroConta = new FormCadastroConta();

            for (int i = 0; i < formularioCadastroConta.numeroDeContasCC; i++)
            {
                MessageBox.Show("Código da Conta: " + formularioPrincipal.contasCorrentes[i].CodigoDaConta);
                MessageBox.Show("Titular da Conta: " + formularioPrincipal.contasCorrentes[i].TitularDaConta);
                MessageBox.Show("Saldo da Conta R$: " + formularioPrincipal.contasCorrentes[i].SaldoDaConta);
            }
        }
    }
}

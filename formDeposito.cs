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
    public partial class formDeposito : Form
    {
        Form1 formularioPrincipal = new Form1();

        public formDeposito()
        {
            InitializeComponent();
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            Form1 formularioPadrao = new Form1();
            this.Hide();
            formularioPadrao.ShowDialog();
        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            //eu gostaria de pegar o código da conta pra realizar o depósito, mas não sei fazer isso, então estou pegando o índice da array =/
            int indice = comboContas.SelectedIndex;

            formularioPrincipal.contasCorrentes[indice].Depositar(Convert.ToDouble(textoValor.Text));
            MessageBox.Show("Depósito Realizado Com Sucesso!");

            //textoSaldo.Text = Convert.ToString(contasCorrentes[indice].SaldoDaConta);
        }

        //public void AdicionaIndice(int indiceCombo)
        //{
        //    comboContas.Items.Add(indiceCombo);
        //}
    }
}

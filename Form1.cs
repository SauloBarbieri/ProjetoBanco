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

        Conta[] contasCorrentes = new ContaCorrente[5];
        Conta[] contasPoupancas = new ContaPoupanca[5];

        int numeroDeContas = 0;
        

        public Form1()
        {
            InitializeComponent();            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //contasCorrentes[0] = new ContaCorrente();
            //contasCorrentes[1] = new ContaCorrente();
            //contasCorrentes[2] = new ContaCorrente();
            //contasCorrentes[3] = new ContaCorrente();
            //contasCorrentes[4] = new ContaCorrente();


        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {

            if (numeroDeContas < contasCorrentes.Length)
            {

                contasCorrentes[numeroDeContas] = new ContaCorrente();


                contasCorrentes[numeroDeContas].Cadastrar(Convert.ToInt32(textoCodigo.Text), (textoTitular.Text), Convert.ToDouble(textoSaldo.Text));
                MessageBox.Show("Cadastro Realizado com Sucesso!");


                // limpa as informações no TextBox
                textoCodigo.Clear();
                textoTitular.Clear();
                textoSaldo.Clear();


                // mostrar no ComboBox o índice da Conta na Array
                comboContas.Items.Add(numeroDeContas);

                numeroDeContas++;
            }
            else
            {
                MessageBox.Show("Não é possível cadastrar mais contas!");
            }
            
        }

        private void botaoExibir_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < numeroDeContas; i++)
            {
                MessageBox.Show("Código da Conta: " + contasCorrentes[i].CodigoDaConta);
                MessageBox.Show("Titular da Conta: " + contasCorrentes[i].TitularDaConta);
                MessageBox.Show("Saldo da Conta R$: " + contasCorrentes[i].SaldoDaConta);
            }
                       
        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            //eu gostaria de pegar o código da conta pra realizar o depósito, mas não sei fazer isso, então estou pegando o índice da array =/
            int indice = comboContas.SelectedIndex;
            
            contasCorrentes[indice].Depositar(Convert.ToDouble(textoValor.Text));
            MessageBox.Show("Depósito Realizado Com Sucesso!");

            textoSaldo.Text = Convert.ToString(contasCorrentes[indice].SaldoDaConta);

        }

        private void BotaoSacar_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;

            string mensagem = contasCorrentes[indice].Sacar(Convert.ToDouble(textoValor.Text)) ? "Saque Realizado Com Sucesso!" : "Saldo Insuficiente!";
            MessageBox.Show(mensagem);

        }

        private void BuscaDeConta_Enter(object sender, EventArgs e)
        {
            
            
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {

            //carrega as informações da conta e coloca nos TextBox de acordo com o indice 'lugar na array'

            int indice = comboContas.SelectedIndex;

            textoCodigo.Text = Convert.ToString(contasCorrentes[indice].CodigoDaConta);
            textoTitular.Text = Convert.ToString(contasCorrentes[indice].TitularDaConta);
            textoSaldo.Text = Convert.ToString(contasCorrentes[indice].SaldoDaConta);

        }

        
    }
}

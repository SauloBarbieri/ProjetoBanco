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

    /*
    Itens que devem ser melhorados nesse código:
        1. combobox deve selecionar o código da conta e não o índice do array;
            1.2 após correção desse item, finalizar colocando as transferências entre contas mesmo que seja de CC para CP ou vice-versa;
        2. Utilizar a herança da Conta Poupança;
        3. Totalizador de Conta, somar o saldo de todas as contas;
    */

    public partial class Form1 : Form
    {

       public Conta[] contasCorrentes = new ContaCorrente[5];
        Conta[] contasPoupancas = new ContaPoupanca[5];

        //public int numeroDeContasCC = 0;
        //public int numeroDeContasCP = 0;


        public Form1()
        {
            InitializeComponent();            
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            // this representa a instância de Form1 que está sendo utilizada pelo Windows Form



            FormCadastroConta formularioCadastroConta = new FormCadastroConta();
            this.Hide();
            formularioCadastroConta.ShowDialog();
            
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            formDeposito formularioDeposito = new formDeposito();
            formularioDeposito.ShowDialog();
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

            //if (numeroDeContasCC < contasCorrentes.Length)
            //{

            //    contasCorrentes[numeroDeContasCC] = new ContaCorrente();


            //    contasCorrentes[numeroDeContasCC].Cadastrar(Convert.ToInt32(textoCodigo.Text), (textoTitular.Text), Convert.ToDouble(textoSaldo.Text));
            //    MessageBox.Show("Cadastro Realizado com Sucesso!");


            //    // limpa as informações no TextBox
            //    textoCodigo.Clear();
            //    textoTitular.Clear();
            //    textoSaldo.Clear();

            //    //eu gostaria de carregar as informações do código da conta, mas depois não sei pegar essa informação para realizar transações
            //    // mostrar no ComboBox o índice da Conta na Array
            //    comboContas.Items.Add(numeroDeContasCC);
            //    comboOrigem.Items.Add(numeroDeContasCC);
            //    comboDestino.Items.Add(numeroDeContasCC);

            //    numeroDeContasCC++;
            //}
            //else
            //{
            //    MessageBox.Show("Não é possível cadastrar mais contas!");
            //}

        }

        private void botaoCadastrarCP_Click(object sender, EventArgs e)
        {
            //if (numeroDeContasCP < contasCorrentes.Length)
            //{

            //    contasCorrentes[numeroDeContasCP] = new ContaCorrente();


            //    contasCorrentes[numeroDeContasCP].Cadastrar(Convert.ToInt32(textoCodigo.Text), (textoTitular.Text), Convert.ToDouble(textoSaldo.Text));
            //    MessageBox.Show("Cadastro Realizado com Sucesso!");


            //    // limpa as informações no TextBox
            //    textoCodigo.Clear();
            //    textoTitular.Clear();
            //    textoSaldo.Clear();

            //    //eu gostaria de carregar as informações do código da conta, mas depois não sei pegar essa informação para realizar transações
            //    // mostrar no ComboBox o índice da Conta na Array
            //    comboContas.Items.Add(numeroDeContasCP);
            //    comboOrigem.Items.Add(numeroDeContasCP);
            //    comboDestino.Items.Add(numeroDeContasCP);

            //    numeroDeContasCP++;
            //}
            //else
            //{
            //    MessageBox.Show("Não é possível cadastrar mais contas!");
            //}

        }

        private void botaoExibir_Click(object sender, EventArgs e)
        {

            //for (int i = 0; i < numeroDeContasCC; i++)
            //{
            //    MessageBox.Show("Código da Conta: " + contasCorrentes[i].CodigoDaConta);
            //    MessageBox.Show("Titular da Conta: " + contasCorrentes[i].TitularDaConta);
            //    MessageBox.Show("Saldo da Conta R$: " + contasCorrentes[i].SaldoDaConta);
            //}
            //MessageBox.Show("Tem Algo Errado Aqui");

        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            ////eu gostaria de pegar o código da conta pra realizar o depósito, mas não sei fazer isso, então estou pegando o índice da array =/
            //int indice = comboContas.SelectedIndex;

            //contasCorrentes[indice].Depositar(Convert.ToDouble(textoValor.Text));
            //MessageBox.Show("Depósito Realizado Com Sucesso!");

            //textoSaldo.Text = Convert.ToString(contasCorrentes[indice].SaldoDaConta);

        }

        private void botaoTransferir_Click(object sender, EventArgs e)
        {
            //int indiceOrigem = comboOrigem.SelectedIndex;
            //int indiceDestino = comboDestino.SelectedIndex;

            //contasCorrentes[indiceOrigem].Transferir(Convert.ToDouble(textoValorTransferencia.Text), contasCorrentes[indiceDestino]);

            //labelOrigem.Text = contasCorrentes[indiceOrigem].TitularDaConta;
            //labelDestino.Text = contasCorrentes[indiceDestino].TitularDaConta;
            //labelSaldoOrigem.Text = Convert.ToString(contasCorrentes[indiceOrigem].SaldoDaConta);
            //labelSaldoDestino.Text = Convert.ToString(contasCorrentes[indiceDestino].SaldoDaConta);


            //MessageBox.Show("Transferência Realizada Com Sucesso!");
        }

        private void BotaoSacar_Click(object sender, EventArgs e)
        {
            //int indice = comboContas.SelectedIndex;

            //string mensagem = contasCorrentes[indice].Sacar(Convert.ToDouble(textoValor.Text)) ? "Saque Realizado Com Sucesso!" : "Saldo Insuficiente!";
            //MessageBox.Show(mensagem);

        }



        private void BuscaDeConta_Enter(object sender, EventArgs e)
        {


        }

        public void botaoAutoCadastrar_Click(object sender, EventArgs e)
        {
            //int codigoConta;
            //string titularConta;
            //double saldoConta;


            //for (int indice = 0; numeroDeContasCC < contasCorrentes.Length; indice++)
            //{

            //    contasCorrentes[numeroDeContasCC] = new ContaCorrente();

            //    codigoConta = 10;
            //    titularConta = "Saulo";
            //    saldoConta = 200.0;

            //    if (1 == numeroDeContasCC)
            //    {
            //        codigoConta = 20;
            //        titularConta = "Loreley";
            //        saldoConta = 300.0;
            //    }
            //    else if (2 == numeroDeContasCC)
            //    {
            //        codigoConta = 30;
            //        titularConta = "Sergio";
            //        saldoConta = 300.0;
            //    }
            //    else if (3 == numeroDeContasCC)
            //    {
            //        codigoConta = 40;
            //        titularConta = "Maricy";
            //        saldoConta = 400.0;
            //    }

            //    else if (4 == numeroDeContasCC)
            //    {
            //        codigoConta = 50;
            //        titularConta = "Noemia";
            //        saldoConta = 500.0;
            //    }


            //    contasCorrentes[numeroDeContasCC].Cadastrar(codigoConta, titularConta, saldoConta);

            //    //eu gostaria de carregar as informações do código da conta, mas depois não sei pegar essa informação para realizar transações
            //    // mostrar no ComboBox o índice da Conta na Array
            //    comboContas.Items.Add(numeroDeContasCC);
            //    comboOrigem.Items.Add(numeroDeContasCC);
            //    comboDestino.Items.Add(numeroDeContasCC);

            //    numeroDeContasCC++;
            //}

            //MessageBox.Show("Cadastro Realizado com Sucesso!");

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {

            //carrega as informações da conta e coloca nos TextBox de acordo com o indice 'lugar na array'

            int indice = comboContas.SelectedIndex;

            //textoCodigo.Text = Convert.ToString(contasCorrentes[indice].CodigoDaConta);
            //textoTitular.Text = Convert.ToString(contasCorrentes[indice].TitularDaConta);
            //textoSaldo.Text = Convert.ToString(contasCorrentes[indice].SaldoDaConta);

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void botaoExtrato_Click(object sender, EventArgs e)
        {
            formExtrato formularioExtrato = new formExtrato();
            formularioExtrato.ShowDialog();
        }
    }
}

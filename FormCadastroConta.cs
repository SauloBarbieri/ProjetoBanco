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
    public partial class FormCadastroConta : Form
    {
        //private Form1 formPrincipal;

        public int numeroDeContasCC = 0;

        formDeposito formularioDeposito = new formDeposito();

        Form1 formularioPrincipal = new Form1();

        public FormCadastroConta() 
        {
                                   
            InitializeComponent();
        }


        public void botaoCadastrar_Click(object sender, EventArgs e)
        {
            if (numeroDeContasCC < formularioPrincipal.contasCorrentes.Length)
            {
                formularioPrincipal.contasCorrentes[numeroDeContasCC] = new ContaCorrente();

                formularioPrincipal.contasCorrentes[numeroDeContasCC].Cadastrar(Convert.ToInt32(textoCodigo.Text), (textoTitular.Text));
                MessageBox.Show("Cadastro Realizado Com Sucesso!");

                // limpa as informações no TextBox
                textoCodigo.Clear();
                textoTitular.Clear();

                //formularioDeposito.AdicionaIndice(formPrincipal.numeroDeContasCC);

                formularioDeposito.comboContas.Items.Add(numeroDeContasCC);

                numeroDeContasCC++;
            }


            //if (numeroDeContasCC < contasCorrentes.Length)
            //{

            //    contasCorrentes[numeroDeContasCC] = new ContaCorrente();


            //    //contasCorrentes[numeroDeContasCC].Cadastrar(Convert.ToInt32(textoCodigo.Text), (textoTitular.Text), Convert.ToDouble(textoSaldo.Text));
            //    //MessageBox.Show("Cadastro Realizado com Sucesso!");

            //    //não tem mais o saldo para preencher no cadastro
            //    contasCorrentes[numeroDeContasCC].Cadastrar(Convert.ToInt32(textoCodigo.Text), (textoTitular.Text));
            //    MessageBox.Show("Cadastro Realizado com Sucesso!");


            //    // limpa as informações no TextBox
            //    textoCodigo.Clear();
            //    textoTitular.Clear();
            //    //textoSaldo.Clear();

            //    //eu gostaria de carregar as informações do código da conta, mas depois não sei pegar essa informação para realizar transações
            //    // mostrar no ComboBox o índice da Conta na Array


            //    //comboContas.Items.Add(numeroDeContasCC);
            //    //comboOrigem.Items.Add(numeroDeContasCC);
            //    //comboDestino.Items.Add(numeroDeContasCC);

            //    numeroDeContasCC++;
            //}
            else
            {
                MessageBox.Show("Não é possível cadastrar mais contas!");
            }
        }

        public void botaoVoltar_Click(object sender, EventArgs e)
        {
            //Close();
            Form1 formularioPadrao = new Form1();
            this.Hide();
            formularioPadrao.ShowDialog();

        }
    }
}

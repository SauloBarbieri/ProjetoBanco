namespace ProjetoBanco
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoCadastrarCP = new System.Windows.Forms.Button();
            this.botaoAutoCadastrar = new System.Windows.Forms.Button();
            this.botaoExibir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.botaoDepositar = new System.Windows.Forms.Button();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelSaldoDestino = new System.Windows.Forms.Label();
            this.botaoTransferir = new System.Windows.Forms.Button();
            this.labelSaldoOrigem = new System.Windows.Forms.Label();
            this.labelDestino = new System.Windows.Forms.Label();
            this.textoValorTransferencia = new System.Windows.Forms.TextBox();
            this.labelOrigem = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.comboOrigem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.botaoExtrato = new System.Windows.Forms.Button();
            this.botaoTransferencia = new System.Windows.Forms.Button();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.botaoDeposito = new System.Windows.Forms.Button();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botaoCadastrarCP);
            this.groupBox1.Controls.Add(this.botaoAutoCadastrar);
            this.groupBox1.Controls.Add(this.botaoExibir);
            this.groupBox1.Location = new System.Drawing.Point(471, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // botaoCadastrarCP
            // 
            this.botaoCadastrarCP.Location = new System.Drawing.Point(124, 139);
            this.botaoCadastrarCP.Name = "botaoCadastrarCP";
            this.botaoCadastrarCP.Size = new System.Drawing.Size(126, 23);
            this.botaoCadastrarCP.TabIndex = 9;
            this.botaoCadastrarCP.Text = "Cadastrar CP";
            this.botaoCadastrarCP.UseVisualStyleBackColor = true;
            this.botaoCadastrarCP.Click += new System.EventHandler(this.botaoCadastrarCP_Click);
            // 
            // botaoAutoCadastrar
            // 
            this.botaoAutoCadastrar.Location = new System.Drawing.Point(7, 93);
            this.botaoAutoCadastrar.Name = "botaoAutoCadastrar";
            this.botaoAutoCadastrar.Size = new System.Drawing.Size(92, 23);
            this.botaoAutoCadastrar.TabIndex = 8;
            this.botaoAutoCadastrar.Text = "Auto-Cadastrar";
            this.botaoAutoCadastrar.UseVisualStyleBackColor = true;
            this.botaoAutoCadastrar.Click += new System.EventHandler(this.botaoAutoCadastrar_Click);
            // 
            // botaoExibir
            // 
            this.botaoExibir.Location = new System.Drawing.Point(10, 139);
            this.botaoExibir.Name = "botaoExibir";
            this.botaoExibir.Size = new System.Drawing.Size(75, 23);
            this.botaoExibir.TabIndex = 7;
            this.botaoExibir.Text = "Exibir";
            this.botaoExibir.UseVisualStyleBackColor = true;
            this.botaoExibir.Click += new System.EventHandler(this.botaoExibir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.botaoDepositar);
            this.groupBox2.Controls.Add(this.textoValor);
            this.groupBox2.Location = new System.Drawing.Point(471, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 127);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transações";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sacar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BotaoSacar_Click);
            // 
            // botaoDepositar
            // 
            this.botaoDepositar.Location = new System.Drawing.Point(44, 64);
            this.botaoDepositar.Name = "botaoDepositar";
            this.botaoDepositar.Size = new System.Drawing.Size(75, 23);
            this.botaoDepositar.TabIndex = 1;
            this.botaoDepositar.Text = "Depositar";
            this.botaoDepositar.UseVisualStyleBackColor = true;
            this.botaoDepositar.Click += new System.EventHandler(this.botaoDepositar_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(76, 19);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(122, 20);
            this.textoValor.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selecione a Conta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboContas);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(471, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 94);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busca de Conta";
            this.groupBox3.Enter += new System.EventHandler(this.BuscaDeConta_Enter);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(50, 48);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(199, 21);
            this.comboContas.TabIndex = 4;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelSaldoDestino);
            this.groupBox4.Controls.Add(this.botaoTransferir);
            this.groupBox4.Controls.Add(this.labelSaldoOrigem);
            this.groupBox4.Controls.Add(this.labelDestino);
            this.groupBox4.Controls.Add(this.textoValorTransferencia);
            this.groupBox4.Controls.Add(this.labelOrigem);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.comboDestino);
            this.groupBox4.Controls.Add(this.comboOrigem);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(762, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 366);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transferências Entre Contas";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // labelSaldoDestino
            // 
            this.labelSaldoDestino.AutoSize = true;
            this.labelSaldoDestino.Location = new System.Drawing.Point(122, 322);
            this.labelSaldoDestino.Name = "labelSaldoDestino";
            this.labelSaldoDestino.Size = new System.Drawing.Size(68, 13);
            this.labelSaldoDestino.TabIndex = 10;
            this.labelSaldoDestino.Text = "saldoDestino";
            // 
            // botaoTransferir
            // 
            this.botaoTransferir.Location = new System.Drawing.Point(112, 239);
            this.botaoTransferir.Name = "botaoTransferir";
            this.botaoTransferir.Size = new System.Drawing.Size(75, 23);
            this.botaoTransferir.TabIndex = 6;
            this.botaoTransferir.Text = "Transferir";
            this.botaoTransferir.UseVisualStyleBackColor = true;
            this.botaoTransferir.Click += new System.EventHandler(this.botaoTransferir_Click);
            // 
            // labelSaldoOrigem
            // 
            this.labelSaldoOrigem.AutoSize = true;
            this.labelSaldoOrigem.Location = new System.Drawing.Point(122, 290);
            this.labelSaldoOrigem.Name = "labelSaldoOrigem";
            this.labelSaldoOrigem.Size = new System.Drawing.Size(65, 13);
            this.labelSaldoOrigem.TabIndex = 9;
            this.labelSaldoOrigem.Text = "saldoOrigem";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(52, 322);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(41, 13);
            this.labelDestino.TabIndex = 8;
            this.labelDestino.Text = "destino";
            // 
            // textoValorTransferencia
            // 
            this.textoValorTransferencia.Location = new System.Drawing.Point(32, 211);
            this.textoValorTransferencia.Name = "textoValorTransferencia";
            this.textoValorTransferencia.Size = new System.Drawing.Size(155, 20);
            this.textoValorTransferencia.TabIndex = 5;
            // 
            // labelOrigem
            // 
            this.labelOrigem.AutoSize = true;
            this.labelOrigem.Location = new System.Drawing.Point(55, 290);
            this.labelOrigem.Name = "labelOrigem";
            this.labelOrigem.Size = new System.Drawing.Size(38, 13);
            this.labelOrigem.TabIndex = 7;
            this.labelOrigem.Text = "origem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Valor Transferência";
            // 
            // comboDestino
            // 
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Location = new System.Drawing.Point(32, 142);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(155, 21);
            this.comboDestino.TabIndex = 3;
            // 
            // comboOrigem
            // 
            this.comboOrigem.FormattingEnabled = true;
            this.comboOrigem.Location = new System.Drawing.Point(32, 72);
            this.comboOrigem.Name = "comboOrigem";
            this.comboOrigem.Size = new System.Drawing.Size(155, 21);
            this.comboOrigem.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Conta Destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Conta Origem";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.botaoExtrato);
            this.groupBox5.Controls.Add(this.botaoTransferencia);
            this.groupBox5.Controls.Add(this.botaoSaque);
            this.groupBox5.Controls.Add(this.botaoDeposito);
            this.groupBox5.Controls.Add(this.botaoNovaConta);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(13, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(334, 273);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Seja Bem Vindo";
            // 
            // botaoExtrato
            // 
            this.botaoExtrato.Location = new System.Drawing.Point(86, 154);
            this.botaoExtrato.Name = "botaoExtrato";
            this.botaoExtrato.Size = new System.Drawing.Size(175, 23);
            this.botaoExtrato.TabIndex = 6;
            this.botaoExtrato.Text = "Extrato";
            this.botaoExtrato.UseVisualStyleBackColor = true;
            this.botaoExtrato.Click += new System.EventHandler(this.botaoExtrato_Click);
            // 
            // botaoTransferencia
            // 
            this.botaoTransferencia.Location = new System.Drawing.Point(86, 244);
            this.botaoTransferencia.Name = "botaoTransferencia";
            this.botaoTransferencia.Size = new System.Drawing.Size(175, 23);
            this.botaoTransferencia.TabIndex = 5;
            this.botaoTransferencia.Text = "Transferência";
            this.botaoTransferencia.UseVisualStyleBackColor = true;
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(86, 212);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(175, 23);
            this.botaoSaque.TabIndex = 4;
            this.botaoSaque.Text = "Saque";
            this.botaoSaque.UseVisualStyleBackColor = true;
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.Location = new System.Drawing.Point(86, 183);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(175, 23);
            this.botaoDeposito.TabIndex = 3;
            this.botaoDeposito.Text = "Depósito";
            this.botaoDeposito.UseVisualStyleBackColor = true;
            this.botaoDeposito.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.Location = new System.Drawing.Point(86, 125);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(175, 23);
            this.botaoNovaConta.TabIndex = 2;
            this.botaoNovaConta.Text = "Cadastrar Conta Corrente";
            this.botaoNovaConta.UseVisualStyleBackColor = true;
            this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione uma opção abaixo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barbieri Bank Group";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 316);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button botaoExibir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botaoDepositar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button botaoAutoCadastrar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button botaoTransferir;
        private System.Windows.Forms.TextBox textoValorTransferencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.ComboBox comboOrigem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelOrigem;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label labelSaldoOrigem;
        private System.Windows.Forms.Label labelSaldoDestino;
        private System.Windows.Forms.Button botaoCadastrarCP;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button botaoExtrato;
        private System.Windows.Forms.Button botaoTransferencia;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.Button botaoDeposito;
        private System.Windows.Forms.Button botaoNovaConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


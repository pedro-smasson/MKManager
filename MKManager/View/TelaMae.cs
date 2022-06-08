﻿using MKManager.View.Cadastrar;
using MKManager.Helpers;

namespace MKManager.View
{
    public partial class TelaMae : Form
    {
        public TelaMae() => InitializeComponent();

        private void TelaMae_Load(object sender, EventArgs e) => AdicionarFormAoPanel(Instancias.telaPrincipal);

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnCadastrarClientes.Checked = true;
            AdicionarFormAoPanel(Instancias.cadastrarClientes);
        }
        private void btnCadastrarProdutos_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnCadastrarProdutos.Checked = true;
            AdicionarFormAoPanel(Instancias.cadastrarProdutos);
        }

        private void btnPaginaInicial_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnPaginaInicial.Checked = true;
            AdicionarFormAoPanel(Instancias.telaPrincipal);
        }
        private void btnExibirClientes_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnExibirClientes.Checked = true;
            AdicionarFormAoPanel(Instancias.exibirClientes);
        }
        private void btnExibirProdutos_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnExibirProdutos.Checked = true;
            AdicionarFormAoPanel(Instancias.exibirProdutos);
        }
        private void btnRelatorioClientes_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnRelatorioClientes.Checked = true;
        }

        private void btnRelatorioProdutos_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnRelatorioProdutos.Checked = true;
        }

        private void LimparBotoesAtivos()
        {
            btnPaginaInicial.Checked = false;
            btnCadastrarClientes.Checked = false;
            btnCadastrarProdutos.Checked = false;
            btnExibirClientes.Checked = false;
            btnExibirProdutos.Checked = false;
            btnRelatorioClientes.Checked = false;
            btnRelatorioProdutos.Checked = false;
        }

        private void AdicionarFormAoPanel(Form formAtual) 
        {
            formAtual.TopLevel = false;
            panelForms.Controls.Add(formAtual);
            formAtual.BringToFront();
            formAtual.Show();
        }

    }
}
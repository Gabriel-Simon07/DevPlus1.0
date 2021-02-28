using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevPlus.Models;
using DevPlus.Views;

namespace DevPlus.Views
{
    public partial class telaCadastro : Form
    {
        public telaCadastro()
        {
            InitializeComponent();
            btnCancelar.Click += irTela_menu;
            btnCadastrar.Click += salvarCadastro;
            carregaCadastroSala();
            carreganomeDoLotacaoCafe();
            carregaSalalotacao();
            carregaLotacaoCafeLotacao();
        }
        private void carregaLotacaoCafeLotacao()
        {
            cmbLotacaoLotacaoCafe.DataSource = Program.lotacaoDoLotacaoCafe;
        }
        private void carregaSalalotacao()
        {
            cmblotacaoDaSala.DataSource = Program.lotacaoDaSala;
        }
        private void carreganomeDoLotacaoCafe()
        {
            cmbLotacaoCafeNome.DataSource = Program.nomeDoLotacaoCafe;
        }
        private void carregaCadastroSala()
        {
            cmbSalaNome.DataSource = Program.nomeDaSala;
        }
        private void salvarCadastro(object sender, EventArgs e)
        {
            try
            {
                Cadastro cadastroNome_e_sobrenome = new Cadastro()
                {
                    Nome = txtNome.Text,
                    Sobrenome = txtSobrenome.Text,
                };
                Program.nomeDaSala.Add(cadastroNome_e_sobrenome);
                MessageBox.Show("Salvo com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void irTela_menu(object sender, EventArgs e)
        {
            Visible = false;
            new telaMenu().Show();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void telaCadastro_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = Cadastro.Consultar();//DataGriDView Consulta
        }
        private void PreencherDgv(List<Cadastro> listaInformacoes)
        {
            dgvConsulta.DataSource = new BindingList<Cadastro>(listaInformacoes);
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int contador = int.Parse(cmblotacaoDaSala.Text);
            if (contador != 0)
            {
                Cadastro test = new Cadastro(
                txtNome.Text, txtSobrenome.Text, (cmbSalaNome.Text),
                (cmbLotacaoCafeNome.Text), int.Parse(cmbLotacaoLotacaoCafe.Text), int.Parse(cmblotacaoDaSala.Text));
                test.ToString();
                test.Inserir();
                dgvConsulta.DataSource = "";
                dgvConsulta.DataSource = Cadastro.Consultar();
                contador--;
                MessageBox.Show($"Restam ainda {contador} vagas.");
            }
            else if (contador == 0)
            {
                MessageBox.Show($"Está sala não tem mais vagas.");
            }
        }
        private void label5_Click(object sender, EventArgs e)
        { }
        private void btnConsultar_consulta_Click(object sender, EventArgs e)
        {
            PreencherDgv(Cadastro.Consultar(txtConsultaDados.Text));
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        { }
    }
}

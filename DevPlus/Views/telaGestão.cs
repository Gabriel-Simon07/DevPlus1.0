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
    public partial class telaGestão : Form
    {        
        public telaGestão()
        {
            InitializeComponent();            
            btnCancelar_cadast.Click += cancelarCadastro_admin;
            btnCadastrar_cadastro.Click += cadastro_sala_lotacao;
            btnCadastrar_LotacaoCafe.Click += cadastro_LotacaoCafe_lotacao;
        }        
        private void cadastro_sala_lotacao(object sender, EventArgs e)
        {
            try
            {
                Cadastro nomeDaSala = new Cadastro()
                {
                    NomeSala = txtSala_nome.Text                    
                };
                Program.nomeDaSala.Add(nomeDaSala);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                LotaçãoDaSala lotacao_da_sala = new LotaçãoDaSala()
                {
                    LotacaoDaSala = int.Parse(numbSala.Text),
                };
                Program.lotacaoDaSala.Add(lotacao_da_sala);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                                    
        }
        private void cadastro_LotacaoCafe_lotacao(object sender, EventArgs e)
        {
                try
                {
                    NomeaçãoLotacaoCafe tipoLotacaoCafe = new NomeaçãoLotacaoCafe()
                    {
                        NomeLotacaoCafe = (txtNome_LotacaoCafe.Text),                        
                    };
                    Program.nomeDoLotacaoCafe.Add(tipoLotacaoCafe);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            try
            {
                LotaçãoDoCafé lotacaoDoLotacaoCafe = new LotaçãoDoCafé()
                {
                    LotacaoCafe = int.Parse(numbLotacaoCafe.Text),
                };
                Program.lotacaoDoLotacaoCafe.Add(lotacaoDoLotacaoCafe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cancelarCadastro_admin(object sender, EventArgs e)
        {
            Visible = false;
            new telaMenu().Show();
        }
        private void telaAdministrativo_Load(object sender, EventArgs e)
        { }
        private void label4_Click(object sender, EventArgs e)
        { }
        private void label3_Click(object sender, EventArgs e)
        { }
        private void label5_Click(object sender, EventArgs e)
        { }
        private void txtCadastro_nome_TextChanged(object sender, EventArgs e)
        { }
        private void btnCadastrar_LotacaoCafe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome e lotação do café cadastrado com sucesso!");
        }       
        private void btnCadastrar_cadastro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome e lotação da sala cadastrada com sucesso!");
        }
        private void numbSala_ValueChanged(object sender, EventArgs e)
        { }
        private void btnCancelar_cadast_Click(object sender, EventArgs e)
        { }        
    }
}

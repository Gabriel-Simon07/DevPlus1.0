using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevPlus.Views;

namespace DevPlus
{
    public partial class telaMenu : Form
    {
        public telaMenu()
        {
            InitializeComponent();
            btnTela_cadastrar.Click += telaCadastrar;            
            btnTela_gestao.Click += telaGestao;
        }
        private void telaGestao(object sender, EventArgs e)
        {
            Visible = false;
            new telaGestão().Show();
        }        
        private void telaCadastrar(object sender, EventArgs e)
        {
            Visible = false;
            new telaCadastro().Show();
        }
        private void btnTela_gestao_Click(object sender, EventArgs e)
        { }
        private void btnTela_cadastrar_Click(object sender, EventArgs e)
        { }
    }
}

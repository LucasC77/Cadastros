using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastross
{
    public partial class EntradaIHM : Form
    {
        public EntradaIHM()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProdutos cadastros = new CadastroProdutos();
            cadastros.Show();
        }

        private void cadastroAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAlunos cadastro = new CadastroAlunos();
            cadastro.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void EntradaIHM_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox3.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produtos.setCodigo(textBox1.Text);
            Produtos.setDescricao(textBox2.Text);
            Produtos.setFornecedor(textBox3.Text);
            Produtos.setQtdestoque(textBox4.Text);
            Produtos.setValorunitario(textBox5.Text);
            ProdutosBLL.validaDados();
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                MessageBox.Show("Dados Salvos");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Produtos.getCodigo();
            textBox2.Text = Produtos.getDescricao();
            textBox3.Text = Produtos.getFornecedor();
            textBox4.Text = Produtos.getQtdestoque();
            textBox5.Text = Produtos.getValorunitario();

        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {

        }
    }
    }


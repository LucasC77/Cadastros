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
    public partial class CadastroAlunos : Form
    {
        public CadastroAlunos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno.setNome(textBox1.Text);
            Aluno.setRa(textBox2.Text);
            Aluno.setSexo(comboBox1.Text);
            Aluno.setTelefone(maskedTextBox1.Text);
            AlunoBLL.validaDados();
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                MessageBox.Show("Dados Salvos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.ResetText();
            dateTimePicker1.ResetText();
            maskedTextBox1.Clear();
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Aluno.getNome();
            textBox2.Text = Aluno.getRa();
            comboBox1.Text = Aluno.getSexo();
            maskedTextBox1.Text = Aluno.getTelefone();
        }
    }
}

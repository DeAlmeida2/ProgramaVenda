using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaVenda
{
    public partial class CadCliente : Form
    {
        public CadCliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                Cliente cliente = new Cliente(tbid.Text, tbnome.Text, tbcpf.Text, tbtel.Text, tbemail.Text);
                MessageBox.Show("\nNome do Individuo " + cliente.nome + "\nCPF: " + cliente.cpf + "\nTelefone: " + cliente.telefone + "\nE-mail: " + cliente.email);
                tbid.Text = "";
                tbnome.Text = "";
                tbcpf.Text = "";
                tbtel.Text = "";
                tbemail.Text = "";

                cliente.gravarCliente();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estoqueDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.estoqueDataSet.cliente);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var form = new CadProduto();
            form.ShowDialog();  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btCadProduto_Click(object sender, EventArgs e)
        {
            var Form = new CadProduto();
            Form.ShowDialog();
        }

        private void btVenda_Click(object sender, EventArgs e)
        {
            var Form = new ItemVendaCliente();
            Form.ShowDialog();
        }
    }
}

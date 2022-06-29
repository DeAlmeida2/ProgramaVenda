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
    public partial class CadProduto : Form
    {
        public CadProduto()
        {
            InitializeComponent();
        }

        private void CadProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estoqueDataSet1.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.estoqueDataSet1.produto);
            // TODO: esta linha de código carrega dados na tabela 'estoqueDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.estoqueDataSet.cliente);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btCadProd_Click(object sender, EventArgs e)
        {
            {
                Produto produto = new Produto(int.Parse(tbIdPKproduto.Text), tbNomeProduto.Text, tbPrecoProduto.Text, tbEstoqueProduto.Text);
                MessageBox.Show("\nO Produto cadastrado foi o IDpk: " + produto.Id_pk + "\n:Nome:  " + produto.nome + "\nPreço: " + produto.preco + "\nQuantidade em estoque:  " + produto.estoque);
                tbIdPKproduto.Text = "";
                tbNomeProduto.Text = "";
                tbPrecoProduto.Text = "";
                tbEstoqueProduto.Text = "";

                produto.gravarProduto();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

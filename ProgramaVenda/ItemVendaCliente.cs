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
    public partial class ItemVendaCliente : Form
    {
        public ItemVendaCliente()
        {
            InitializeComponent();
            PopularClientes();
            PopularProdutos();
              
                                   
        }
        

        private void PopularProdutos()
        {
            Banco banco = new Banco();
            var dt = banco.executarConsultaGenerica("Select * from Produto");
            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string novoProduto = "";

                        foreach (DataColumn dc in dt.Columns)

                        {
                            novoProduto += dr[dc].ToString();
                            novoProduto += ";";

                        }

                        var vetor = novoProduto.Split(';');
                        var produto = new Produto(int.Parse(vetor[0]), vetor[1], vetor[2], vetor[3]);

                        ListaProdutos.Add(produto);
                    }

                    
                }

            }
        }

        private void PopularClientes()
        {
    Banco banco = new Banco();
    var dt = banco.executarConsultaGenerica("Select * from cliente");
    if (dt != null)
    {
        if (dt.Rows.Count != 0)
        {
            foreach (DataRow dr in dt.Rows)
            {
                string novoCliente = "";

                foreach (DataColumn dc in dt.Columns)

                {
                    novoCliente += dr[dc].ToString();
                    novoCliente += ";";

                }

                var vetor = novoCliente.Split(';');
                var cliente = new Cliente(vetor[0], vetor[2], vetor[1], vetor[3], vetor[4]);

                ListaClientes.Add(cliente);
            }

            foreach (var clientes in ListaClientes)
            {
                cbNomeVenda.Items.Add(clientes);
            }
                }

            }
        }


        int id_ProdutoSelecionado;
        String NomeProdutoSelecionado;
        float PrecoProdutoSelecionado;

        List<Cliente> ListaClientes = new List<Cliente>();
        List<Produto> ListaProdutos = new List<Produto> ();


        private void Venda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estoqueDataSet2.itemVenda'. Você pode movê-la ou removê-la conforme necessário.
            this.itemVendaTableAdapter.Fill(this.estoqueDataSet2.itemVenda);
            // TODO: esta linha de código carrega dados na tabela 'estoqueDataSet1.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.estoqueDataSet1.produto);

        }
               


        private void cbNomeVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            LbIdCliente.Text = 
            ((Cliente)cbNomeVenda.SelectedItem).Id_cliente;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btRealizarVenda_Click(object sender, EventArgs e)
        {

        }

        private void btAddItemVenda_Click(object sender, EventArgs e)
        {
            var x = dg_Produtos.SelectedRows[0].Cells[0];
            //var Id = (dg_Produtos.SelectedRows.co);
        }

        /*private void btRealizarVenda_Click(object sender, EventArgs e)
        {
            Venda venda = new venda(int.Parse(tbIdPKproduto.Text), tbNomeProduto.Text, tbPrecoProduto.Text, tbEstoqueProduto.Text);
            MessageBox.Show("\nO Produto cadastrado foi o IDpk: " + produto.Id_pk + "\n:Nome:  " + produto.nome + "\nPreço: " + produto.preco + "\nQuantidade em estoque:  " + produto.estoque);
            tbIdPKproduto.Text = "";
            tbNomeProduto.Text = "";
            tbPrecoProduto.Text = "";
            tbEstoqueProduto.Text = "";

            venda.gravarVenda();
        }*/
    }
}

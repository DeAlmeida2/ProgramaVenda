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

            dg_Carrinho.Columns.Add("Id_produto", "Id_produto");
            dg_Carrinho.Columns.Add("nome", "nome");
            dg_Carrinho.Columns.Add("preco", "preco");
            dg_Carrinho.Columns.Add("quantidade", "quantidade");

        }


        private void PopularProdutos()//popular o datagrid e fazer a conexão com o banco
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

        private void PopularClientes()//popular o datagrid clientes e fazer a conexão com o banco
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

        List<Cliente> ListaClientes = new List<Cliente>();//lista de clientes
        List<Produto> ListaProdutos = new List<Produto>();//lista de produtos


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
            ((Cliente)cbNomeVenda.SelectedItem).Id_cliente;//selecionar item no datagrid clientes
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btRealizarVenda_Click(object sender, EventArgs e)//pegar os valores do datagrid, somar a quantidade de itens e valores
        {
            double valorTotal = 0;
            List<double> valores = new List<double>();


            for (int i = 0; i < dg_Carrinho.Rows.Count - 1; i++)
            {

                valores.Add(double.Parse(dg_Carrinho.Rows[i].Cells[2].Value.ToString()));


            }

            valorTotal = valores.Sum();
            int idCliente = int.Parse(LbIdCliente.Text);
            Venda novaVenda = new Venda(9, idCliente, valorTotal.ToString());
            novaVenda.gravarVenda();

            for (int i = 0; i < dg_Carrinho.Rows.Count - 1; i++)
            {
                int id = i;
                int idVendas = novaVenda.Id_vendas;
                int idProduto = int.Parse(dg_Carrinho.Rows[i].Cells[0].Value.ToString());
                string valorIndividual = (double.Parse(dg_Carrinho.Rows[i].Cells[2].Value.ToString()) / double.Parse(dg_Carrinho.Rows[i].Cells[3].Value.ToString())).ToString();
                string valorT = double.Parse(dg_Carrinho.Rows[i].Cells[2].Value.ToString()).ToString();
                string quantidade = double.Parse(dg_Carrinho.Rows[i].Cells[3].Value.ToString()).ToString();

                ItemVenda itemVenda = new ItemVenda(i, novaVenda.Id_vendas, idProduto, valorIndividual, valorT, quantidade);

                itemVenda.gravarItemVenda();

                Banco bd = new Banco();
                var produto = new Produto();
                produto.ConsultaProduto(idProduto);
                var quant = int.Parse(produto.estoque) - int.Parse(quantidade);

                bd.executarConsultaGenerica($"update produto set Estoque='{quant}' where Id_pk ={idProduto}");

            }


            dg_Carrinho.Rows.Clear();
            //dg_Produtos.Rows.Clear();

            PopularProdutos();



            MessageBox.Show("O Cliente " + cbNomeVenda.Text + "Comprou " + tbQuantidadeVendas.Text + "\nA compra deu um valor total de: " + valorTotal);



        }

        private void btAddItemVenda_Click(object sender, EventArgs e)//botao para adicionar o que está em produtos para ir para o carrinho
        {
            var id = int.Parse(dg_Produtos.CurrentRow.Cells[0].Value.ToString());
            bool existe = false;

            if (int.Parse(ListaProdutos.FirstOrDefault(x => x.Id_pk == id).estoque) > int.Parse(tbQuantidadeVendas.Text))//validar se o produto já existe no carrinho
            {
                for (int i = 0; i < dg_Carrinho.Rows.Count; i++)
                {
                    if (dg_Carrinho.Rows[i].Cells[0].Value == id.ToString())
                    {
                        existe = true;
                        MessageBox.Show("Seu produto foi escolhido com sucesso!");

                    }
                }
                if (!existe)
                {
                    Produto p = ListaProdutos.FirstOrDefault(x => x.Id_pk == id);

                    dg_Carrinho.Rows.Add(p.Id_pk, p.nome, (double.Parse(p.preco) * double.Parse(tbQuantidadeVendas.Text)).ToString(), double.Parse(tbQuantidadeVendas.Text));
                }
            }
        }

        private void tbQuantidadeVendas_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

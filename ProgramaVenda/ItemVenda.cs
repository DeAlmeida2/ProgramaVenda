using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProgramaVenda
{
    internal class ItemVenda
    {
        public int Id_pk;
        public int Id_vendas;
        public int Id_produto;
        public string valorUnitario;
        public string quantidade;
        public string valorTotal;


        public ItemVenda(int id_pk, int id_vendas, int id_produto, string valorUnitario, string quantidade, string valorTotal)

        {
            this.Id_pk = id_pk;
            this.Id_vendas = id_vendas;
            this.Id_produto = id_produto;
            this.valorUnitario = valorUnitario;
            this.quantidade = quantidade;
            this.valorTotal = valorTotal;

        }
        public bool gravarItemVenda()
        {

            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            string texto = "insert into produto values (@Id_pk, @Id_vendas, @Id_produto, @valorUnitario, @quantidade, @valorTotal)";

            SqlCommand command = new SqlCommand(texto, cn);
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            //command.CommandText = "insert into produto values (@Id_pk, @Id_vendas, @Id_produto, @valorUnitario, @quantidade, @valorTotal)";

            command.Parameters.AddWithValue("@Id_pk", Id_pk);
            command.Parameters.AddWithValue("@Id_vendas", Id_vendas);
            command.Parameters.AddWithValue("@Id_produto", Id_produto);
            command.Parameters.AddWithValue("@valorUnitario", valorUnitario);
            command.Parameters.AddWithValue("@quantidade", quantidade);
            command.Parameters.AddWithValue("@valorTotal", valorTotal);

            command.Parameters[0].Value = Id_pk;
            command.Parameters[1].Value = Id_vendas;
            command.Parameters[2].Value = Id_produto;
            command.Parameters[3].Value = valorUnitario;
            command.Parameters[4].Value = quantidade;
            command.Parameters[5].Value = valorTotal;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }
    }
}


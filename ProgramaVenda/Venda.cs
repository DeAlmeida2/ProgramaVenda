using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProgramaVenda
{
    internal class Venda
    {
        public int Id_vendas;
        public int codigoCliente;
        public string valorTotal;

        public Venda(int id_vendas, int codigoCliente, string valorTotal)
        {
            Id_vendas = id_vendas;
            this.codigoCliente = codigoCliente;
            this.valorTotal = valorTotal;
        }

        public bool gravarVenda()//gravar a venda
        {

            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            string texto = "insert into vendas (codigoCliente,valorTotal) values (@codigoCliente, @valorTotal)";

            SqlCommand command = new SqlCommand(texto, cn);
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            //command.CommandText = "insert into produto values (@Id_vendas, @codigoCliente, @valorTotal)";


            //command.Parameters.AddWithValue("@Id_vendas", Id_vendas);
            command.Parameters.AddWithValue("@codigoCliente", codigoCliente);
            command.Parameters.AddWithValue("@valorTotal", valorTotal);

            //command.Parameters[0].Value = Id_vendas;
            command.Parameters[0].Value = codigoCliente;
            command.Parameters[1].Value = valorTotal;

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

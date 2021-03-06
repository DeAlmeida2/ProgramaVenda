using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProgramaVenda
{
    internal class Produto
    {
        public int Id_pk;
        public string nome;
        public string preco;
        public string estoque;
        public Produto() { }

        public Produto(int Id_pk, string nome, string preco, string estoque)
        {
            this.Id_pk = Id_pk;
            this.nome = nome;
            this.preco = preco;
            this.estoque = estoque;
        }
        public bool gravarProduto()//gravar o produto
        {

            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            string texto = "insert into produto values (@Id_pk, @nome, @preco, @estoque)";

            SqlCommand command = new SqlCommand(texto, cn);
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            //command.CommandText = "insert into produto values (@Id_PK, @nome, @preco, @estoque)";

            command.Parameters.AddWithValue("@Id_pk", Id_pk);
            
            command.Parameters.AddWithValue("@nome", nome);

            command.Parameters.AddWithValue("@preco", preco);
            command.Parameters.AddWithValue("@estoque", estoque);

            command.Parameters[0].Value = Id_pk;
            command.Parameters[1].Value = nome;
            command.Parameters[2].Value = preco;
            command.Parameters[3].Value = estoque;


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
        public Produto ConsultaProduto (int id)//consultar o produto no banco e debitar os valores que fizemos na venda
        {
            Banco bd = new Banco();
            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand($"select * from Produto where Id_pk = {id}", cn);

                SqlDataReader rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr.GetInt32(0) == id)
                    {
                        Id_pk = rdr.GetInt32(0);
                        nome = rdr.GetString(1);
                        preco = rdr.GetString(2);
                        estoque = rdr.GetString(3);
                        
                        return this;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
    }
}
    


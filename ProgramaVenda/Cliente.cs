using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProgramaVenda
{
    internal class Cliente
    {
        public string Id_cliente;
        public string nome;
        public string cpf;
        public string telefone;
        public string email;
        public Cliente(string Id_cliente, string nome, string cpf, string telefone, string email)
        {
            this.Id_cliente = Id_cliente;
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.email = email; 
        }
        public bool gravarCliente()
        {


            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            string texto = "insert into cliente values (@Id_cliente, @nome, @cpf, @telefone, @email)";

            SqlCommand command = new SqlCommand(texto, cn);
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;



            //command.CommandText = "insert into cliente values (@Id_cliente, @nome, @cpf, @telefone, @email)";

            command.Parameters.AddWithValue("@Id_cliente", Id_cliente);
            command.Parameters.AddWithValue("@nome", nome);

            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);    


            command.Parameters[0].Value = Id_cliente;
            command.Parameters[2].Value = nome;
            command.Parameters[1].Value = cpf;
            command.Parameters[3].Value = telefone;
            command.Parameters[4].Value = email;


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
        public override string ToString()
        {
            return nome;

        }
    }
}
    


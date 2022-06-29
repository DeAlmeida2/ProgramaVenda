using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProgramaVenda
{
    public class Banco
    {
        //string stringConexao = "Data Source=localhost;Initial Catalog=Estoque;TrustServerCertificate=True;Integrated Security=True";
        //private string stringConexao = "Data Source=localhost; Initial Catalog=Estoque; User ID=usuario; password='senha';language=Portuguese";
        //string stringConexao = "Data Source=localhost\\DESKTOP-MDRD3GS\\SQLEXPRESS;Initial Catalog=Estoque;TrustServerCertificate=True;Integrated Security=True";
        //string stringConexao = "Data Source=DESKTOP-MDRD3GS\\SQLEXPRESS;Initial Catalog=Estoque;Integrated Security=True";
        //string stringConexao = "Data Source=localhost\\DESKTOP-MDRD3GS\\SQLEXPRESS;Initial Catalog=Estoque;Integrated Security=True";
        //private string stringConexao = "Data Source=localhost; Initial Catalog=Estoque; User ID=usuario; password='senha';language=Portuguese";
        //private string stringConexao = "Provider=SQLOLEDB.1;Persist Security Info=False;Data Source = Estoque";
        private string stringConexao = "Integrated Security = SSPI; Persist Security Info=False;Initial Catalog = Estoque; Data Source = DESKTOP-MDRD3GS\\SQLEXPRESS";



        private SqlConnection cn;

        private void conexao()//vincular a string com o cn, bm inicia o CN
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                //tentar fazer algo
                conexao();


                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                //faz algo se deu erro
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);//adaptar preenche o datatable com os dados do command

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}  
    


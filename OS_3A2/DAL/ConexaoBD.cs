using MySql.Data.MySqlClient;
using System.Data;
using System;

namespace OS_3A2.DAL
{
    internal class ConexaoBD
    {
        //Lembrete: Alterar o nome do banco de dados=.
        private string string_conexao = "persist security info = false; server=localhost; database=OS_3A2; uid=root; pwd=; SslMode=none";
        private MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch(MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarTabela(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable ConsultarTabelas(string sql)
        {
            try
            {
                Conectar();
                MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
                DataTable dados = new DataTable();
                consulta.Fill(dados);
                return dados;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

using System;
using System.Data;
using OS_3A2.DAL;

namespace OS_3A2.BLL
{
    internal class BLL_Login
    {

        public static string tipo_usuario;
        public static string nome_usuario;
        public static int id_usuario;

        public string Login(string usuario, string senha)
        {
            ConexaoBD bd = new ConexaoBD();
            DataTable dt = new DataTable();

            string sql = string.Format("select * from usuario where email = '{0}' and senha = '{1}'", usuario, senha);
            dt = bd.ConsultarTabelas(sql);

            if(dt.Rows.Count > 0)
            {
                nome_usuario = dt.Rows[0]["nome"].ToString();
                id_usuario = int.Parse(dt.Rows[0]["id"].ToString());
                tipo_usuario = "Usuario";
                return "Usuario";
            }

            sql = String.Format("select * from tecnico where email = '{0}' and senha = '{1}'", usuario, senha);
            dt = bd.ConsultarTabelas(sql);

            if(dt.Rows.Count > 0)
            {
                nome_usuario = dt.Rows[0]["nome"].ToString();
                id_usuario = int.Parse(dt.Rows[0]["id"].ToString());
                tipo_usuario = "Tecnico";
                return "Tecnico";
            }

            return "";
        }

        public string Tipo_Usuario()
        {
            return tipo_usuario;
        }

        public string Nome_Usuario()
        {
            return nome_usuario;
        }

        public int ID_Usuario()
        {
            return id_usuario;
        }
    }
}
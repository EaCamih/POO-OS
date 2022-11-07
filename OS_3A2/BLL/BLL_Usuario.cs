using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OS_3A2.DAL;
using OS_3A2.DTO;
using System.Data;

namespace OS_3A2.BLL
{
    internal class BLL_Usuario
    {

        ConexaoBD bd = new ConexaoBD();

        public void Inserir_Usuario(DTO_Usuario usuario)
        {
            try
            {
                string sql = string.Format("Insert into usuario values(null, '{0}','{1}','{2}','{3}, {4},')", usuario.Nome, usuario.Email, usuario.Senha, usuario.Telefone, usuario.Id_setor);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar_Usuario(DTO_Usuario usuario)
        {
            try
            {
                string sql = string.Format("Update usuario set nome = '{0]', email = '{1}', telefone = '{2}', setor = '{3}', where id = '{4}', senha = '{5}'", usuario.Nome, usuario.Email, usuario.Telefone, usuario.Id_setor, usuario.Id, usuario.Senha);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir_Usuario(DTO_Usuario usuario)
        {
            try
            {
                string sql = string.Format("Delete from usuario where id = '{0}'", usuario.Id);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Consultar_Tabela()
        {
            try
            {
                string sql = string.Format("select * from usuario");
                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

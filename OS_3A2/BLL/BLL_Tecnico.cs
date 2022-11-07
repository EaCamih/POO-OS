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
    internal class BLL_Tecnico
    {
        ConexaoBD bd = new ConexaoBD();

        public void Inserir_Tecnico(DTO_Tecnico tecnico)
        {
            try
            {
                string sql = string.Format("Insert into tecnico values(null, '{1}', '{2}', {3}, {4},)", tecnico.Nome, tecnico.Email, tecnico.Senha, tecnico.Espec_id);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar_Tecnico(DTO_Tecnico tecnico)
        {
            try
            {
                string sql = string.Format("Update tecnico set nome = '{0]', especialidade = '{1}', email = '{2}', senha = '{3}',", tecnico.Nome, tecnico.Espec_id, tecnico.Email, tecnico.Senha);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir_Tecnico(DTO_Tecnico tecnico)
        {
            try
            {
                string sql = string.Format("Delete from tecnico where id = '{0}'", tecnico.Id);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ConsultarTabela()
        {
            try
            {
                string sql = "select * from tecnico";
                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

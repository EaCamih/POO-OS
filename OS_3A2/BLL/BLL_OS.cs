using System;
using System.Data;
using OS_3A2.DAL;
using OS_3A2.DTO;
namespace OS_3A2.BLL

{
    internal class BLL_OS
    {

        ConexaoBD bd = new ConexaoBD();
        string sql;

        public void Criar_OS(DTO_OS os)
        {
            try
            {
                sql = string.Format("inser into os values(null, '{0}', '{1}', '{2}', '{3}')", os.Descricao, os.Status, os.Tecnico, os.Usuario);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar_OS(DTO_OS os)
        {
            try
            {
                sql = string.Format("update os set status = '{0}' where id = '{1}'", os.Status, os.Id);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir_OS(DTO_OS os)
        {
            try
            {
                sql = string.Format("delete from os where id = '{0}'", os.Id);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar_OS()
        {
            try
            {
                sql = string.Format("select * from OS");
                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar_OS_Usuario(DTO_OS os)
        {
            try
            {
                sql = string.Format("select * from os where usuario = '{0}'", os.Usuario);
                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar_OS_Tecnico(DTO_OS os)
        {
            try
            {
                sql = string.Format("select * from os where tecnico = '{0}'", os.Tecnico);
                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

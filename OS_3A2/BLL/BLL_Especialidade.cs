using System;
using OS_3A2.DAL;
using OS_3A2.DTO;
using System.Data;

namespace OS_3A2.BLL
{
    internal class BLL_Especialidade
    {
        ConexaoBD bd = new ConexaoBD();

        public DataTable ConsultarTabela()
        {
            try
            {
                return bd.ConsultarTabelas("Select * from especialidade");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

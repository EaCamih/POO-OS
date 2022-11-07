using System;
using System.Data;
using OS_3A2.DAL;

namespace OS_3A2.BLL
{
    internal class BLL_Setor
    {
        ConexaoBD bd = new ConexaoBD();

        public DataTable Consultar_Tabela()
        {
            try
            {
                return bd.ConsultarTabelas("Select * from setor");
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

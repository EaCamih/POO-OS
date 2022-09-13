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

        public DataTable ConsultarTabela()
        {
            try
            {
                return bd.ConsultarTabelas("Select * from setor");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

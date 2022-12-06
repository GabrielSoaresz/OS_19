using System;
using OS_19.DAL;
using System.Data;

namespace OS_19.BLL
{
    internal class BLL_setor
    {
        ConexaoBD bd = new ConexaoBD();

        public DataTable Consultar_Setor()
        {
            try
            {
                return bd.ConsultarTabelas("select * from setor");
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

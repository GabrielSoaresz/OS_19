using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OS_19.DTO;
using OS_19.DAL;
using System.Data;

namespace OS_19.BLL
{
    internal class BLL_OS
    {
        private ConexaoBD bd = new ConexaoBD();
        private string sql;

        public void Criar_OS(DTO_OS dto_os)
        {
            try
            {
                sql = String.Format("insert into os values(null,'{0}','{1}','{2}','{3}'"
                        ,dto_os.Descricao,dto_os.Status_os,dto_os.Tecnico,dto_os.Usuario);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar_OS(DTO_OS dto_os)
        {
            try
            {
                sql = String.Format("update os set status_os '{0}' where id = '{1}'",
                    dto_os.Status_os, dto_os.Id);
                bd.AlterarTabelas(sql);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void  Excluir_OS(DTO_OS dto_os)
        {
            try
            {
                sql = String.Format("delete from os where id = '(0)'", dto_os.Id);
                bd.AlterarTabelas(sql);
            }catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public DataTable Listar_OS()
        {
            try
            {
                sql = String.Format("select * from os ");
                return bd.ConsultarTabelas(sql);
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar_OS_Usuario(DTO_OS dto_os)
        {
            try
            {
                sql = String.Format("select * from os where tecnico = '{0}'"
                    , dto_os.Tecnico);
                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar_OS_Tecnico(DTO_OS dto_os)
        {
            try
            {
                sql = String.Format("select * from os where tecnico = '{0}'", dto_os.Tecnico);
                return bd.ConsultarTabelas(sql);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

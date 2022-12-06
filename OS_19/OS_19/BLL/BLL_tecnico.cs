using System;
using OS_19.DAL;
using OS_19.DTO;
using System.Data;

namespace OS_19.BLL
{
    internal class BLL_tecnico
    {
        ConexaoBD bd = new ConexaoBD();
        private string sql;

        public void Cadastrar_Tecnico(DTO_tecnicos tecnico)
        {
            try
            {
                sql = string.Format("insert into tecnico values(default,'{0}','{1}','{2}','{3}')", 
                    tecnico.Nome, tecnico.Email,tecnico.Senha, tecnico.Id_espec );
                bd.AlterarTabelas(sql);
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar_Tecnico(DTO_tecnicos tecnico)
        {
            try
            {
                sql = String.Format("update tecnico set nome = '{0}', especialidade = '{1}', email = '{2}', senha='{3}' where id = '{4}'", 
                                tecnico.Nome, tecnico.Id_espec, tecnico.Email, tecnico.Senha, tecnico.Id);
                bd.AlterarTabelas(sql);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir_Tecnico(DTO_tecnicos tecnico)
        {
            try
            {
                sql = string.Format("delete from tecnico where id = '{0}'", tecnico.Id);
                bd.AlterarTabelas(sql);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Consultar_Tabela()
        {
            try
            {
                return bd.ConsultarTabelas("select * from tecnico");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

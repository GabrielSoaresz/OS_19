using System;
using System.Data;
using OS_19.DTO;
using OS_19.DAL;

namespace OS_19.BLL
{
    internal class BLL_usuario
    {
        ConexaoBD bd = new ConexaoBD();
        private string sql;

        public void Cad_Usuario(DTO_usuario usuario)
        {
            try
            {
                this.sql = string.Format("insert into usuario values(null,'{0}','{1}','{2}','{3}','{4}')"
                    , usuario.Nome, usuario.Email, usuario.Telefone, usuario.Senha, usuario.Id_setor);
                bd.AlterarTabelas(sql);

            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar_Usuario(DTO_usuario usuario)
        {
            try
            {
                this.sql = String.Format("update usuario set nome = '{0}', email = '{1}', telefone '{2}', setor = '{3}', senha ='{4}' where id = '{4}'",
                     usuario.Nome, usuario.Email, usuario.Telefone, usuario.Senha, usuario.Id_setor, usuario.Id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public void Excluir_Usuario(DTO_usuario usuario)
        {
            try
            {
                this.sql = String.Format("Delete from usuario where id = '{0}'", usuario.Id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar_Usuario()
        {
            try
            {
                return bd.ConsultarTabelas("select * from usuario");
            }catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

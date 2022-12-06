using System;
using System.Data;
using OS_19.DAL;

namespace OS_19.BLL
{
    internal class BLL_login
    {
        private string tipo_usuario;
        private string nome;
        private int id;

        public string logar(string usuario, string senha)
        {
            ConexaoBD bd = new ConexaoBD();
            string sql;
            DataTable dt;

            sql = string.Format("select * from usuario where email = '{0}' and senha = '{1}'", usuario, senha);
            dt = bd.ConsultarTabelas(sql);
            if(dt.Rows.Count > 0)
            {
                tipo_usuario = "Usuario";
                nome = dt.Rows[0]["nome"].ToString();
                id = int.Parse(dt.Rows[0]["id"].ToString());
                return "Usuario";
            }
            sql = String.Format("select * from tecnico where email = '{0}' and senha = '{1}'",usuario, senha);
            dt = bd.ConsultarTabelas(sql);
            if (dt.Rows.Count > 0)
            {
                tipo_usuario = "Tecnico";
                nome = dt.Rows[0]["nome"].ToString();
                id = int.Parse(dt.Rows[0]["id"].ToString());
                return "Tecnico";
            }

            return "";
        }

        public string Tipo_usuario()
        {
            return tipo_usuario;
        }

        public int ID_Usuario()
        {
            return id;
        }
    }
}

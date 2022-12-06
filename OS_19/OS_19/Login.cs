using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OS_19.BLL;

namespace OS_19
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        BLL_login login = new BLL_login();
        private void button1_Click(object sender, EventArgs e)
        {
            if (login.logar(txt_usuario.Text, txt_senha.Text) == "Usuario")
            {
                FrmOS_usuario usuario = new FrmOS_usuario();
                usuario.ShowDialog();
            }
            else if(login.logar(txt_usuario.Text, txt_senha.Text) == "Tecnico")
            {
                FrmOS_tecnico tecnico = new FrmOS_tecnico();
                tecnico.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario ou sennha Incorreto!!!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

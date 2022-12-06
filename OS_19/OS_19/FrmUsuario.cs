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
using OS_19.DTO;

namespace OS_19
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        BLL_usuario obj_bll_usuario = new BLL_usuario();
        BLL_setor obj_bll_setor = new BLL_setor();
        DTO_usuario obj_dto_usuario = new DTO_usuario();

        public void CarregarGrid()
        {
            try
            {
                cbx_setor.DataSource = obj_bll_setor.Consultar_Setor();
                cbx_setor.DisplayMember = "descricao";
                cbx_setor.ValueMember = "id";

                dgv_registro.DataSource = obj_bll_usuario.Listar_Usuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Limpar()
        {
            txt_id.Clear();
            txt_nome.Clear();
            txt_email.Clear();
            txt_telefone.Clear();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dto_usuario.Nome = txt_nome.Text;
                obj_dto_usuario.Senha = txt_senha.Text;
                obj_dto_usuario.Telefone = txt_telefone.Text;
                obj_dto_usuario.Email = txt_email.Text;
                obj_dto_usuario.Id_setor = int.Parse(cbx_setor.SelectedValue.ToString());
                obj_bll_usuario.Cad_Usuario(obj_dto_usuario);
              
                MessageBox.Show("Cadastro efetuado com sucesso.");

                CarregarGrid();
                Limpar();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dto_usuario.Id = int.Parse(txt_id.Text);
                obj_bll_usuario.Excluir_Usuario(obj_dto_usuario);
                MessageBox.Show("Cadastro excluido com sucesso.");
                CarregarGrid();
                Limpar();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void cbx_setor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
                
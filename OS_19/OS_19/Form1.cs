using System;
using System.Windows.Forms;
using OS_19.BLL;
using OS_19.DTO;

namespace OS_19
{
    public partial class FrmTecnico : Form
    {
        public FrmTecnico()
        {
            InitializeComponent();
        }

        BLL_tecnico obj_bll_tecnico = new BLL_tecnico();
        BLL_especialidade obj_bll_especialidade = new BLL_especialidade();
        DTO_tecnicos obj_dto_tecnico = new DTO_tecnicos();

        public void CarregarGrid()
        {
            try
            {
                cbx_especialidade.DataSource = obj_bll_especialidade.Consultar_Tabela();
                cbx_especialidade.DisplayMember = "descricao";
                cbx_especialidade.ValueMember = "id";

                dgv_registro.DataSource = obj_bll_tecnico.Consultar_Tabela();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Limpar()
        {
            txt_id.Clear();
            txt_nome.Clear();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dto_tecnico.Nome = txt_nome.Text;
                obj_dto_tecnico.Id_espec = int.Parse(cbx_especialidade.SelectedValue.ToString());
                obj_dto_tecnico.Email = txt_email.Text;
                obj_dto_tecnico.Senha = txt_senha.Text;
                obj_bll_tecnico.Cadastrar_Tecnico(obj_dto_tecnico);
                MessageBox.Show("Cadastro de Tecnico realizado com sucesso!");

                CarregarGrid();
                Limpar();
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dto_tecnico.Id = int.Parse(txt_id.Text);
                obj_bll_tecnico.Excluir_Tecnico(obj_dto_tecnico);
                MessageBox.Show("Cadastro excluido com sucesso.");
                CarregarGrid();
                Limpar();
            } catch (Exception ex)
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

        private void FrmTecnico_Load_1(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;
using OS_19.BLL;
using OS_19.DTO;

namespace OS_19
{
    public partial class FrmOS_usuario : Form
    {
        public FrmOS_usuario()
        {
            InitializeComponent();
        }

        DTO_OS dto_os = new DTO_OS();
        BLL_OS bll_os = new BLL_OS();
        BLL_tecnico bll_tecnico = new BLL_tecnico();
        BLL_login bll_login = new BLL_login();

        public void Carregar_GRID()
        {
            try
            {
                dto_os.Usuario = bll_login.ID_Usuario();
                dgv_view.DataSource = bll_os.Listar_OS_Usuario(dto_os);
                cbx_tecnico.DataSource = bll_tecnico.Consultar_Tabela();
                cbx_tecnico.DisplayMember = "nome";
                cbx_tecnico.ValueMember = "id";
                txt_descricao.Clear();
                txt_id.Clear();
                cbx_tecnico.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            try
            {
                dto_os.Descricao = txt_descricao.Text;
                dto_os.Status_os = "EM ABERTO";
                dto_os.Tecnico = int.Parse(cbx_tecnico.SelectedValue.ToString());
                dto_os.Usuario = bll_login.ID_Usuario();
                bll_os.Criar_OS(dto_os);
                MessageBox.Show("Os criada com sucesso.");
                Carregar_GRID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_tecnico_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            FrmOS_tecnico oS_Tecnico = new FrmOS_tecnico();
            oS_Tecnico.ShowDialog();
        }

        private void FrmOS_usuario_Load(object sender, EventArgs e)
        {
            Carregar_GRID();
        }
    }
}

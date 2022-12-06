using System;
using System.Windows.Forms;
using OS_19.BLL;
using OS_19.DTO;

namespace OS_19
{
    public partial class FrmOS_tecnico : Form
    {
        public FrmOS_tecnico()
        {
            InitializeComponent();
        }
        DTO_OS dto_os = new DTO_OS();
        BLL_OS bll_os = new BLL_OS();

        public void CarregarGrid()
        {
            dgv_view.DataSource = bll_os.Listar_OS();
            cbx_status.SelectedIndex = -1;
            txt_id.Clear();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                dto_os.Id = int.Parse(txt_id.Text);
                dto_os.Status_os = cbx_status.Text;
                bll_os.Alterar_OS(dto_os);
                MessageBox.Show("Status alterado com sucesso");
                CarregarGrid();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                dto_os.Id = int.Parse(txt_id.Text);
                bll_os.Excluir_OS(dto_os);
                MessageBox.Show("OS excluida com sucesso.");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmOS_tecnico_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}

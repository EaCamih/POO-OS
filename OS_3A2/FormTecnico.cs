using System;
using OS_3A2.BLL;
using OS_3A2.DTO;
using System.Windows.Forms;

namespace OS_3A2
{
    public partial class FormTecnico : Form
    {
        public FormTecnico()
        {
            InitializeComponent();
        }

        BLL_Especialidade objbll_especialidade = new BLL_Especialidade();
        BLL_Tecnico objbll_tecnico = new BLL_Tecnico();
        DTO_Tecnico objdto_tecnico = new DTO_Tecnico();

        public void CarregarGrid()
        {
            try
            {
                cbxEspecialidade.DataSource = objbll_especialidade.ConsultarTabela();
                cbxEspecialidade.ValueMember = "id";
                cbxEspecialidade.DisplayMember = "descricao";
                dataGridView1.DataSource = objbll_tecnico.ConsultarTabela();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Limpar()
        {
            cbxEspecialidade.SelectedIndex = -1;
            txtID.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }

        private void FormTecnico_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                objdto_tecnico.Nome = txtNome.Text;
                objdto_tecnico.Email = txtEmail.Text;
                objdto_tecnico.Senha = txtSenha.Text;
                objdto_tecnico.Espec_id = int.Parse(cbxEspecialidade.SelectedValue.ToString());
                objbll_tecnico.Inserir_Tecnico(objdto_tecnico);
                MessageBox.Show("Tecnico inserido com sucesso!");
                CarregarGrid();
                Limpar();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                objdto_tecnico.Id = int.Parse(txtID.Text);
                objbll_tecnico.Excluir_Tecnico(objdto_tecnico);
                MessageBox.Show("Tecnico excluido com sucesso!");
                CarregarGrid();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

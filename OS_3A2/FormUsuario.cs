using System;
using System.Data;
using System.Windows.Forms;
using OS_3A2.DAL;
using OS_3A2.BLL;
using OS_3A2.DTO;

namespace OS_3A2
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        BLL_Usuario objbll_usuario = new BLL_Usuario();
        BLL_Setor objbll_setor = new BLL_Setor();
        DTO_Usuario objdto_usuario = new DTO_Usuario();


        public void Limpar()
        {
            txtEmail.Clear();
            txtSenha.Clear();
            txtID.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            cbxSetor.SelectedIndex = -1;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            try
            {
                cbxSetor.DataSource = objbll_setor.Consultar_Tabela();
                cbxSetor.DisplayMember = "descricao";
                cbxSetor.ValueMember = "id";
                dataGridView1.DataSource = objbll_usuario.Consultar_Tabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                objdto_usuario.Nome = txtNome.Text;
                objdto_usuario.Telefone = txtTelefone.Text;
                objdto_usuario.Email = txtEmail.Text;
                objdto_usuario.Id_setor = int.Parse(cbxSetor.SelectedValue.ToString());
                objdto_usuario.Senha = txtSenha.Text;
                objbll_usuario.Inserir_Usuario(objdto_usuario);
                MessageBox.Show("Usario inserido com sucesso");
                Limpar();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                objdto_usuario.Id = int.Parse(txtID.Text);
                objbll_usuario.Excluir_Usuario(objdto_usuario);
                MessageBox.Show("Usuario excluído com sucesso!");
                Limpar();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            CarregarGrid();
        }
    }
}

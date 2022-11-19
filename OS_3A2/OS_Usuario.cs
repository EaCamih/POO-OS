using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using OS_3A2.BLL;
using OS_3A2.DTO;

namespace OS_3A2
{
    public partial class OS_Usuario : Form
    {
        public OS_Usuario()
        {
            InitializeComponent();
        }

        BLL_Tecnico blltecnico = new BLL_Tecnico();
        BLL_Login bll_login = new BLL_Login();
        BLL_OS bll_os = new BLL_OS();
        DTO_OS dto_os = new DTO_OS();

        public void CarregarTecnico()
        {
            try
            {
                cbTecnico.DataSource = blltecnico.ConsultarTabela();
                cbTecnico.DisplayMember = "nome";
                cbTecnico.ValueMember = "id";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo " + bll_login.Nome_Usuario());
            CarregarTecnico();
            Listar_Os();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dto_os.Descricao = txtDesc.Text;
            dto_os.Status = "EM ABERTO";
            dto_os.Tecnico = int.Parse(cbTecnico.SelectedValue.ToString());
            dto_os.Usuario = bll_login.ID_Usuario();
            bll_os.Criar_OS(dto_os);
            MessageBox.Show("OS Criada com sucesso.");
            Listar_Os();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OS_Tecnicos tecnico = new OS_Tecnicos();
                tecnico.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Listar_Os()
        {
            try
            {
                dto_os.Usuario = bll_login.ID_Usuario();
                dataGridView1.DataSource = bll_os.Listar_OS_Usuario(dto_os);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

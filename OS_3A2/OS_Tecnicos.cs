using System;
using System.Windows.Forms;
using System.Data;
using OS_3A2.BLL;
using OS_3A2.DTO;

namespace OS_3A2
{
    public partial class OS_Tecnicos : Form
    {
        public OS_Tecnicos()
        {
            InitializeComponent();
        }

        DTO_OS dto_os = new DTO_OS();
        BLL_OS bll_os = new BLL_OS();

        private void OS_Tecnicos_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dto_os.Id = int.Parse(txtId.Text);
                bll_os.Excluir_OS(dto_os);
                MessageBox.Show("OS Excluída com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dto_os.Id = int.Parse(txtId.Text);
                dto_os.Status = cbxStatus.Text;
                bll_os.Alterar_OS(dto_os);
                MessageBox.Show("Status alterado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

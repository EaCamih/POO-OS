using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        DTO_Usuario objdto_usuario = new DTO_Usuario();


        public void Limpar()
        {
            txtEmail.Clear();
            txtID.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            cbxSetor.SelectedValue = -1;
        }

        public void CarregarGrid()
        {
            try
            {

            }
        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

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
    }
}

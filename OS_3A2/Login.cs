using System;
using System.Windows.Forms;
using OS_3A2.BLL;

namespace OS_3A2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        BLL_Login login = new BLL_Login();

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "admin@admin.com.br" && txtSenha.Text == "admin123")
            {
                Form1 frmPrincipal = new Form1();
                frmPrincipal.ShowDialog();
            }


            if(login.Login(txtEmail.Text, txtSenha.Text) == "")
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }else if(login.Login(txtEmail.Text, txtSenha.Text) == "Usuario")
            {
                OS_Usuario usuario = new OS_Usuario();
                usuario.ShowDialog();
            }
            else if (login.Login(txtEmail.Text, txtSenha.Text) == "Tecnico")
            {
                OS_Tecnicos tecnico = new OS_Tecnicos();
                tecnico.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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

        BLL_Tecnico objbll_tecnico = new BLL_Tecnico();
        BLL_Especialidade objbll_especialidade = new BLL_Especialidade();
        DTO_Tecnico objdto_tecnico = new DTO_Tecnico();

        private void OS_Tecnicos_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

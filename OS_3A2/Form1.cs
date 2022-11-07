using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_3A2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario usuario = new FormUsuario();
            usuario.ShowDialog();
        }

        private void técnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tecnico tecnico = new Tecnico();
            tecnico.ShowDialog();
        }
    }
}

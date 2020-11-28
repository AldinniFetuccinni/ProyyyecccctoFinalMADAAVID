using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPPRRROYYECCCTTTOFinalMadAavid
{
    public partial class EditarSeleccionDepartamento : Form
    {
        public EditarSeleccionDepartamento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form editar = new Editar();
            editar.FormClosed += (s, args) => this.Close();
            editar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form editarDep = new EditarDepartamento();
            editarDep.FormClosed += (s, args) => this.Close();
            editarDep.Show();
        }
    }
}

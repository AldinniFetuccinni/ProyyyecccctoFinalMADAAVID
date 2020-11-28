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
    public partial class EditarSeleccionEmpleado : Form
    {
        public EditarSeleccionEmpleado()
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
            Form editarEmp = new EditarEmpleado();
            editarEmp.FormClosed += (s, args) => this.Close();
            editarEmp.Show();
        }
    }
}

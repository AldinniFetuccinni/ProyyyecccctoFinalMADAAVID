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
    public partial class EditarSeleccionNomina : Form
    {
        public EditarSeleccionNomina()
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
            Form editarNom = new EditarNomina();
            editarNom.FormClosed += (s, args) => this.Close();
            editarNom.Show();
        }
    }
}

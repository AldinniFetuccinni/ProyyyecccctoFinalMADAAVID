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
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ESEmp = new EditarSeleccionEmpresa();
            ESEmp.FormClosed += (s, args) => this.Close();
            ESEmp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ESEmp = new EditarSeleccionEmpleado();
            ESEmp.FormClosed += (s, args) => this.Close();
            ESEmp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ESDep = new EditarSeleccionDepartamento();
            ESDep.FormClosed += (s, args) => this.Close();
            ESDep.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ESPue = new EditarSeleccionPuesto();
            ESPue.FormClosed += (s, args) => this.Close();
            ESPue.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ESNom = new EditarSeleccionNomina();
            ESNom.FormClosed += (s, args) => this.Close();
            ESNom.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form PPrin = new PantallaPrincipal();
            PPrin.FormClosed += (s, args) => this.Close();
            PPrin.Show();
        }
    }
}

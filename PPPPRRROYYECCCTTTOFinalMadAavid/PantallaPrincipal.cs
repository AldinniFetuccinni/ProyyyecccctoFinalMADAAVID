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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registrar = new Registrar();
            registrar.FormClosed += (s, args) => this.Close();
            registrar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form solicitar = new Solicitar();
            solicitar.FormClosed += (s, args) => this.Close();
            solicitar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form actualizar = new Actualizar();
            actualizar.FormClosed += (s, args) => this.Close();
            actualizar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form genReport = new GenerarReporte();
            genReport.FormClosed += (s, args) => this.Close();
            genReport.Show();
        }
    }
}

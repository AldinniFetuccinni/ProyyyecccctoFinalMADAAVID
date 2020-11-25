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
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form actPue = new ActualizarPuestoEmpleado();
            actPue.FormClosed += (s, args) => this.Close();
            actPue.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form actDep = new ActualizarDepartamentoEmpleado();
            actDep.FormClosed += (s, args) => this.Close();
            actDep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form PPrin = new PantallaPrincipal();
            PPrin.FormClosed += (s, args) => this.Close();
            PPrin.Show();
        }
    }
}

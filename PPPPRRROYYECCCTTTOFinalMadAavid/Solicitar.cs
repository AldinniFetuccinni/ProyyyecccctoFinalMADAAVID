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
    public partial class Solicitar : Form
    {
        public Solicitar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form solRec = new SolicitarReciboNomina();
            solRec.FormClosed += (s, args) => this.Close();
            solRec.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form solVac = new SolicitarVacaciones();
            solVac.FormClosed += (s, args) => this.Close();
            solVac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form solPerm = new SolicitarPermisoEspecial();
            solPerm.FormClosed += (s, args) => this.Close();
            solPerm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form PPrin = new PantallaPrincipal();
            PPrin.FormClosed += (s, args) => this.Close();
            PPrin.Show();
        }
    }
}

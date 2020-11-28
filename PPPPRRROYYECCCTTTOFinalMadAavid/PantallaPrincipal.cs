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
            Form CCReg = new ContrasennaRegistrar();
            CCReg.FormClosed += (s, args) => this.Close();
            CCReg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CCSol = new ContrasennaSolicitar();
            CCSol.FormClosed += (s, args) => this.Close();
            CCSol.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CCAct = new ContrasennaActualizar();
            CCAct.FormClosed += (s, args) => this.Close();
            CCAct.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form genReport = new GenerarReporte();
            genReport.FormClosed += (s, args) => this.Close();
            genReport.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CCEdi = new ContrasennaEditar();
            CCEdi.FormClosed += (s, args) => this.Close();
            CCEdi.Show();
        }
    }
}

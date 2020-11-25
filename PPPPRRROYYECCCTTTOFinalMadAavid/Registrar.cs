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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form regEmp = new RegistrarEmpresa();
            regEmp.FormClosed += (s, args) => this.Close();
            regEmp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form regEmpl = new RegistrarEmpleado();
            regEmpl.FormClosed += (s, args) => this.Close();
            regEmpl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form regDep = new RegistrarDepartamento();
            regDep.FormClosed += (s, args) => this.Close();
            regDep.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form regPue = new RegistrarPuesto();
            regPue.FormClosed += (s, args) => this.Close();
            regPue.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form regNom = new RegistrarNomina();
            regNom.FormClosed += (s, args) => this.Close();
            regNom.Show();
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

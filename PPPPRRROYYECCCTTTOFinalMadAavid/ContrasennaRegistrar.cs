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
    public partial class ContrasennaRegistrar : Form
    {
        public ContrasennaRegistrar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hi;
            hi = textBox1.Text;
            MessageBox.Show(textBox1.Text, "Mensaje de prueba");
            this.Hide();
            Form registrar = new Registrar();
            registrar.FormClosed += (s, args) => this.Close();
            registrar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form PPrin = new PantallaPrincipal();
            PPrin.FormClosed += (s, args) => this.Close();
            PPrin.Show();
        }
    }
}

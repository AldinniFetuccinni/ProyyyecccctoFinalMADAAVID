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
    public partial class SolicitarPermisoEspecial : Form
    {
        public SolicitarPermisoEspecial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SolicitarPermisoEspecial_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form SSolic = new Solicitar();
            SSolic.FormClosed += (s, args) => this.Close();
            SSolic.Show();
        }
    }
}

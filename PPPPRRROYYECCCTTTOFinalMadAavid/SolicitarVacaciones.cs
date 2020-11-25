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
    public partial class SolicitarVacaciones : Form
    {
        public SolicitarVacaciones()
        {
            InitializeComponent();
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

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
    public partial class RegistrarPuesto : Form
    {
        public RegistrarPuesto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form RRegis = new Registrar();
            RRegis.FormClosed += (s, args) => this.Close();
            RRegis.Show();
        }
    }
}

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
    public partial class ActualizarDepartamentoEmpleado : Form
    {
        public ActualizarDepartamentoEmpleado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AActu = new Actualizar();
            AActu.FormClosed += (s, args) => this.Close();
            AActu.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAltavista
{
    public partial class MRegistrarCita : Form
    {
        public MRegistrarCita()
        {
            InitializeComponent();
        }

        private void btnCancelarRegistrarCita_Click(object sender, EventArgs e)
        {
            MCita mantCita = new MCita();
            mantCita.Show();
            this.Close();
        }
    }
}

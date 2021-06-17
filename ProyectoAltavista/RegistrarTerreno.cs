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
    public partial class RegistrarTerreno : Form
    {
        MantenedorDeInmueble inmueble;
        public RegistrarTerreno(MantenedorDeInmueble inm)
        {
            InitializeComponent();
            inmueble = inm;
        }

        private void RegresarTerreno_Click(object sender, EventArgs e)
        {
            this.Hide();
            inmueble.Show();
        }
    }
}

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
    public partial class RegistrarCiudad : Form
    {
        public RegistrarCiudad()
        {
            InitializeComponent();
        }

        private void lbRegistrarCiudad_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MantenedorCiudad mantCiudad = new MantenedorCiudad();
            mantCiudad.Show();
            this.Close();
        }
    }
}

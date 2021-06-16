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
    public partial class MantenedorCiudad : Form
    {
        public MantenedorCiudad()
        {
            InitializeComponent();
        }

        private void btRegistrarCiudad_Click(object sender, EventArgs e)
        {
            RegistrarCiudad registroCiudad = new RegistrarCiudad();
            registroCiudad.Show();
            this.Close();
        }


        private void btRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincio = new MenuPrincipal();
            menuPrincio.Show();
            this.Close();
        }
    }
}

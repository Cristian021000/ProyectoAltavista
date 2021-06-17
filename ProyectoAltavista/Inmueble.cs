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
    public partial class Inmueble : Form
    {
        MenuPrincipal menu;
        public Inmueble(MenuPrincipal me)
        {
            InitializeComponent();
            menu = me;
        }

        private void btRegistrarInmueble_Click(object sender, EventArgs e)
        {
            MantenedorDeInmueble mantenedor = new MantenedorDeInmueble();
            this.Close();
            mantenedor.Show();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
    }
}

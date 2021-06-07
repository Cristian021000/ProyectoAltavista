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
    public partial class MantenedorAgente : Form
    {
        public MantenedorAgente()
        {
            InitializeComponent();
        }



        private void MantenedorAgente_Load(object sender, EventArgs e)
        {

        }

        private void btRegistrarAgente_Click(object sender, EventArgs e)
        {
            RegistrarAgente RegistrarAge = new RegistrarAgente();
            RegistrarAge.Show();
            this.Close();
        }

        private void btModificarAgente_Click(object sender, EventArgs e)
        {
            ModificarAgente ModificarAge = new ModificarAgente();
            ModificarAge.Show();
            this.Close();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal MenuPri = new MenuPrincipal();
            MenuPri.Show();
            this.Close();
        }
    }
}

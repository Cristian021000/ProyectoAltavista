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
    public partial class MantenedorCliPropietario : Form
    {
        public MantenedorCliPropietario()
        {
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarCliPropietario registroCliPropietario = new RegistrarCliPropietario();
            registroCliPropietario.Show();
            this.Close();
        }

        private void btLista_Click(object sender, EventArgs e)
        {
            ConsultarCliPropietario consultaCliPropietario = new ConsultarCliPropietario();
            consultaCliPropietario.Show();
            this.Close();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menPrincipal = new MenuPrincipal();
            menPrincipal.Show();
            this.Close();
        }
    }
}

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
    public partial class MantenedorSector : Form
    {
        MenuPrincipal principal;
        InmuebleSetorRegistro registroSector;
       InmuebleMostrarSector mossector;
        public MantenedorSector(MenuPrincipal menu)
        {
            InitializeComponent();
            principal = menu;
        }

        private void lbRegistrar_Click(object sender, EventArgs e)
        {
            if (registroSector == null)
            {
               registroSector = new InmuebleSetorRegistro(this);
            }
            
            registroSector.Show();
            this.Hide();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (mossector == null)
            {
               mossector = new InmuebleMostrarSector(this);
            }
            
            mossector.Show();
            this.Hide();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Hide();
        }
    }
}

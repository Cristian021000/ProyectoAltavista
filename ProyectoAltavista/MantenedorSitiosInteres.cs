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
    public partial class MantenedorSitiosInteres : Form
    {
        MenuPrincipal principal;
        MRegistrarSitioInteres RegistrarSI;
        ConsultarSitiosInteres consultaSI;
        public MantenedorSitiosInteres(MenuPrincipal menu)
        {
            InitializeComponent();
            principal = menu;
        }

        private void btRegistrarSitio_Click(object sender, EventArgs e)
        {
            if (RegistrarSI == null)
            {
                 RegistrarSI = new MRegistrarSitioInteres(this);
            }
            
            RegistrarSI.Show();
            this.Hide();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {   
            principal.Show();
            this.Hide();
        }

        private void btnListarSI_Click(object sender, EventArgs e)
        {
            if (consultaSI == null)
            {
               consultaSI = new ConsultarSitiosInteres(this);
            }
            consultaSI.listarSitioInteres();
            consultaSI.Show();
            this.Hide();
        }

        private void btnregistrarSitioInmueble_Click(object sender, EventArgs e)
        {

        }
    }
}

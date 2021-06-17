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
        public MantenedorSitiosInteres()
        {
            InitializeComponent();
        }

        private void btRegistrarSitio_Click(object sender, EventArgs e)
        {
            MRegistrarSitioInteres RegistrarSI = new MRegistrarSitioInteres();
            RegistrarSI.Show();
            this.Close();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal MenuPri = new MenuPrincipal();
            MenuPri.Show();
            this.Close();
        }

        private void btnListarSI_Click(object sender, EventArgs e)
        {
            ConsultarSitiosInteres consultaSI = new ConsultarSitiosInteres();
            consultaSI.Show();
            this.Close();
        }
    }
}

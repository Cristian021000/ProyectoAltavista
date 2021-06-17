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
    public partial class MantenedorDeInmueble : Form
    {
        Inmueble inmueble;
        public MantenedorDeInmueble(Inmueble menuIn)
        {
            InitializeComponent();
            cboxInmuebles.SelectedIndex = 0;
            inmueble = menuIn;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btRegresarInmueble_Click(object sender, EventArgs e)
        {
            inmueble.Show();
            this.Close();
        }

        private void AceptarRegisInmueble_Click(object sender, EventArgs e)
        {
            int inmueble;
            inmueble = cboxInmuebles.SelectedIndex + 1;
            
            switch (inmueble)
            {
                case 1:
                    InmuebleMantenedorCasa casa = new InmuebleMantenedorCasa(this);
                    this.Hide();
                    casa.Show();
                    break;
                case 2:
                    RegistarDepartamento departamento = new RegistarDepartamento(this);
                    this.Hide();
                    departamento.Show();
                    break;
                case 3:
                    RegistrarTerreno terreno = new RegistrarTerreno(this);
                    this.Hide();
                    terreno.Show();
                    break;

            }
        }

        private void cboxInmuebles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

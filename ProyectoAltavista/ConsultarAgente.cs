using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace ProyectoAltavista
{
    public partial class ConsultarAgente : Form
    {
        public ConsultarAgente()
        {
            InitializeComponent();
            ListarAgente();
        }

        public void ListarAgente()
        {
            dgvConsultaAgente.DataSource = logAgente.Instancia.ListarAgentes();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            //ModificarAgente mod = new ModificarAgente();

        }
    }
}

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarLogin_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = new DataTable();
                entAgente agente = new entAgente();
                agente.correo = txtNombreDeUsuario.Text;
                agente.contraseña = txtContraseña.Text;
                dt = logAgente.Instancia.IngresarAgente(agente);
                if (dt.Rows.Count >= 1)
                {
                    agente = Agente(dt);   
                    this.Hide();
                    MenuPrincipal menuPrin = new MenuPrincipal();
                    menuPrin.Show();
                }
                else
                {
                    MessageBox.Show("Usuario incorrecto");
                }
                             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }


        }

        public entAgente Agente(DataTable dt)
        {
            entAgente Agente = new entAgente();
            Agente.id = (int)dt.Rows[0]["id"];
            Agente.dni = (int)dt.Rows[0]["dni"];
            Agente.nombre = (string)dt.Rows[0]["nombre"];
            Agente.apellido = (string)dt.Rows[0]["apellido"];
            Agente.edad = (int)dt.Rows[0]["edad"];
            Agente.celular = (int)dt.Rows[0]["celular"];
            Agente.correo = (string)dt.Rows[0]["correo"];
            Agente.contraseña = (string)dt.Rows[0]["contraseña"];
            return Agente;
        }
    }
}

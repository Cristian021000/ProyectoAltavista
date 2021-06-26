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
    public partial class RegistrarVentaPropios : Form
    {
        MenuVentas menVentas;
        //int auxID=0;
        public RegistrarVentaPropios(MenuVentas menu)
        {
            InitializeComponent();
            menVentas = menu;
            ListarBancos();
            ListarCitas();
            
        }
        /*public void ListarIDCita()
        {
            auxID = Convert.ToInt32(comboBoxCita.SelectedValue);
        }*/
        public void ListarBancos()
        {
            comboBoxBanco.DataSource = logBanco.Instancia.ListarBancos();
            comboBoxBanco.DisplayMember = "Nombre";
            comboBoxBanco.ValueMember = "BancoID";
        }
        public void ListarCitas()
        {
            comboBoxCita.DataSource = logCita.Instancia.ListarCita();
            comboBoxCita.DisplayMember = "CitaID";
            comboBoxCita.ValueMember = "CitaID";
        }
        /*public void contenerCita()
        {
            auxID = Convert.ToInt32(comboBoxCita.SelectedValue);
        }*/
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                entVenta venta = new entVenta();
                venta.Fechaventa = DateTime.Parse(dtpFecha.Text.Trim());
                venta.BancoID = Convert.ToInt32(comboBoxBanco.SelectedValue);
                venta.CitaID = Convert.ToInt32(comboBoxCita.SelectedValue);
                venta.Escriturapublica = Convert.ToInt32(txtEscrituraPublica.Text.Trim());
                venta.Precio = (float)Convert.ToDouble(txtPrecio.Text.Trim());
                venta.ContratoID = 3;
                if (!logVenta.Instancia.ExisteNEscritura(venta.Escriturapublica))
                {
                    logVenta.Instancia.RegistrarVenta(venta);
                    MessageBox.Show("La venta se a registrado correctamente");
                    menVentas.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El número de escritura pública ya ha sido registrada en otra venta.");
                }
                ListarBancos();
                ListarCitas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error.." + ex);
            }
            }

        private void comboBoxCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*try
            {
                entCita cita = new entCita();
                auxID = cita.CitaID;
                cita = logCita.Instancia.DatosCita(auxID);
                txtIDAgente.Text = cita.AgenteID.ToString();
                txtIDCliente.Text = cita.ClienteID.ToString();
                txtIDInmueble.Text = cita.InmuebleID.ToString();
            }
            catch(Exception ex)
            {

                MessageBox.Show("Error...." + ex);
            }*/
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            menVentas.Show();
            this.Hide();
            ListarBancos();
            ListarCitas();
        }
    }
        
    }

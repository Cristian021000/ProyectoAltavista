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
    public partial class RegistarDepartamento : Form
    {
        MantenedorDeInmueble inmuebles;
        public RegistarDepartamento(MantenedorDeInmueble inm)
        {
            InitializeComponent();
            inmuebles = inm;
            ListarSector();
            ListarPropietario();
        }
        public void limpiarVariableInterfazReg()
        {
            textBox1CantBañosD.Clear();
            textBox1CantHabitacionesD.Clear();
            textBox1MetrosCuadradosD.Clear();
            textBox1PrecioD.Clear();
            textBox1NumRegistPublicosD.Clear();
            textBox1PrecionMinD.Clear();
            textBox1UbicacionPisosD.Clear();
            txtDireccionD.Clear();
            dateTimePicker1.Text = "";
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            ListarSector();
            ListarPropietario();
            limpiarVariableInterfazReg();
            this.Hide();
            inmuebles.Show();
        }
        public void ListarSector()
        {
            comboBoxSector.DataSource = logSector.Instancia.ListarSector();
            comboBoxSector.DisplayMember = "Nombresector";
            comboBoxSector.ValueMember = "SectorID";
        }
        public void ListarPropietario()
        {
            comboBoxPropietario.DataSource = logPropietario.Instancia.ListarPropietario();
            comboBoxPropietario.DisplayMember = "Nombre";
            comboBoxPropietario.ValueMember = "PropietarioID";
        }
        private void AceptarRegisDepartamento_Click(object sender, EventArgs e)
        {
            try
            {
                entInmueble inmueble = new entInmueble();
                entDepartamento departamento = new entDepartamento();
                inmueble.SectorID = Convert.ToInt32(comboBoxSector.SelectedValue);
                inmueble.idPropietario = Convert.ToInt32(comboBoxPropietario.SelectedValue);
                inmueble.direccion = txtDireccionD.Text.Trim();
                inmueble.precio = int.Parse(textBox1PrecioD.Text.Trim());
                inmueble.precioMinimo = int.Parse(textBox1PrecionMinD.Text.Trim());
                inmueble.nRegistroPublico = int.Parse(textBox1NumRegistPublicosD.Text.Trim());
                inmueble.vendido = false;
                inmueble.habilitado = true;
                departamento.CantHabitacinoes = int.Parse(textBox1CantHabitacionesD.Text.Trim());
                departamento.CantBao = int.Parse(textBox1CantBañosD.Text.Trim());
                departamento.Ubipisos = int.Parse(textBox1UbicacionPisosD.Text.Trim());
                departamento.Aream2 = (float)Convert.ToDouble(textBox1MetrosCuadradosD.Text.Trim());
                departamento.Fechaconstruccion = dateTimePicker1.Value;
                if (!logInmueble.Instancia.ExisteNRegistros(inmueble.nRegistroPublico))
                {
                    logInmueble.Instancia.RegistrarInmueble(inmueble);
                    departamento.InmuebleID2 = logInmueble.Instancia.BuscarNRegistroPublico(inmueble.nRegistroPublico).InmuebleID;
                    logDepartamento.Instancia.RegistrarInmuebleDepartamento(departamento);
                    MessageBox.Show("Se registró correctamente el departamento.");
                    limpiarVariableInterfazReg();
                    this.Hide();
                    inmuebles.Show();
                }
                else
                {
                    MessageBox.Show("El número de registro público ya se encuentra registrado en otro inmueble.");
                }
                ListarSector();
                ListarPropietario();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

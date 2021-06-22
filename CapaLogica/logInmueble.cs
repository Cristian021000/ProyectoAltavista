using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaLogica
{
    public class logInmueble
    {
        #region singleton
        private static readonly logInmueble _instancia = new logInmueble();
        public static logInmueble Instancia
        {
            get { return logInmueble._instancia; }
        }
        #endregion singleton

        public void RegistrarInmueble(entInmueble inmueble)
        {
            datInmueble.Instancia.registrarInmueble(inmueble);
        }

        public void ModificarInmueble(entInmueble inmueble)
        {
            datInmueble.Instancia.modificarInmueble(inmueble);
        }
        public Boolean BuscarInmuebleCasa(entInmueble inmueble)
        {
            return datInmueble.Instancia.BuscarInmuebleCasa(inmueble);
        }
        public void DeshabilitarInmueble(int idInmueble)
        {
            datInmueble.Instancia.InhabilitarInmueble(idInmueble);
        }
        public List<entInmueble> ListarInmuebleCasa()
        {
            return datInmueble.Instancia.ListarInmuebleCasa();
        }

        public entInmueble BuscarNRegistroPublico(int nRegistro)
        {
            return datInmueble.Instancia.BuscarNRegistroPublico(nRegistro);
        }

        public void VenderInmueble(int idInmueble)
        {
            datInmueble.Instancia.VenderInmueble(idInmueble);
        }
        public entInmueble DatosInmueble(int idInmueble)
        {
            return datInmueble.Instancia.DatosInmueble(idInmueble);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class datCita
    {
        #region singleton
        private static datCita _instancia = new datCita();
        public static datCita Instancia
        {
            get { return datCita._instancia; }
        }
        #endregion singleton
    }
}

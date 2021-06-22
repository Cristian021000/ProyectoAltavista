using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datDepartamento
    {
        #region singleton
        private static datDepartamento _instancia = new datDepartamento();
        public static datDepartamento Instancia
        {
            get { return datDepartamento._instancia; }
        }
        #endregion singleton
    }
}

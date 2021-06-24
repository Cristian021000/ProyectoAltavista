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
    public class logCita
    {
        #region singleton
        private static readonly logCita _instancia = new logCita();
        public static logCita Instancia
        {
            get { return logCita._instancia; }
        }
        #endregion singleton

    }
}

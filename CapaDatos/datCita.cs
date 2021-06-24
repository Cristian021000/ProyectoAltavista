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
        public Boolean RegistrarCita(entCita cita)
        {
            Boolean registrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarCita", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", cita.Fechacita);
                cmd.Parameters.AddWithValue("@id_Inmueble8", cita.InmuebleID);
                cmd.Parameters.AddWithValue("@ClienteID", cita.ClienteID);
                cmd.Parameters.AddWithValue("@AgenteID", cita.AgenteID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    registrar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return registrar;
        }
        public List<entCita> ListarCita()
        {
            List<entCita> lista = new List<entCita>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCita", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCita cita = new entCita();
                    cita.Estadocita = Convert.ToBoolean(dr["Estadocita"]);
                    if (cita.Estadocita)
                    {
                        cita.CitaID = Convert.ToInt32(dr["CitaID"]);
                        cita.AgenteID = Convert.ToInt32(dr["AgenteID"]);
                        cita.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                        cita.InmuebleID = Convert.ToInt32(dr["InmuebleID"]);
                        cita.Fechacita = Convert.ToDateTime(dr["Fechacita"]);
                        cita.Realizado = Convert.ToBoolean(dr["Realizado"]);
                        lista.Add(cita);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
    }
}

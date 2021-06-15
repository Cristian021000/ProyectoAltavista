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
    public class datSitioInteres
    {
        #region singleton
        private static datSitioInteres _instancia = new datSitioInteres();

        public static datSitioInteres Instancia
        {
            get { return datSitioInteres._instancia; }
        }
        #endregion singleton

        public List<entSitioInteres> ListarSitioInteres()
        {
            SqlCommand cmd = null;
            List<entSitioInteres> lista = new List<entSitioInteres>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaSI", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entSitioInteres Sitio = new entSitioInteres();
                    Sitio.codSitioInteres = Convert.ToInt32(dr["codSitioInteres"]);
                    Sitio.NombreSI = dr["NombreSI"].ToString();
                    Sitio.DireccionSI = dr["DireccionSI"].ToString();
                    Sitio.estadoSI = Convert.ToBoolean(dr["EstadoSI"]);
                    lista.Add(Sitio);
                }

            }

            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;

        }
        //INSERTAR
        public Boolean IngresoSitioInteres(entSitioInteres Sitio)
        {
            Boolean registrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spIngresarSI", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreSI", Sitio.NombreSI);
                cmd.Parameters.AddWithValue("@DireccionSI", Sitio.DireccionSI);
                cmd.Parameters.AddWithValue("@estadoSI", Sitio.estadoSI);
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

        //EDITAR
        public Boolean EditarSitioInteres(entSitioInteres Sitio)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaSI", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreSI", Sitio.NombreSI);
                cmd.Parameters.AddWithValue("@DireccionSI", Sitio.DireccionSI);
                cmd.Parameters.AddWithValue("@estadoSI", Sitio.estadoSI);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        public Boolean BuscarSitioInteres(entSitioInteres Sitio)
        {
            Boolean encontrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SpBuscarSI", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codSitioInteres", Sitio.codSitioInteres);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    encontrar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return encontrar;
        }
        public entSitioInteres DatosSitioInteres(int codSitioInteres)
        {
            entSitioInteres Sitio = new entSitioInteres();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDatosSI", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codSitioInteres", codSitioInteres);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Sitio.codSitioInteres = Convert.ToInt32(dr["codSitioInteres"]);
                    Sitio.NombreSI = dr["NombreSI"].ToString();
                    Sitio.DireccionSI = dr["DireccionSI"].ToString();
                    Sitio.estadoSI = Convert.ToBoolean(dr["estadoSI"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Sitio;
        }
        public Boolean DeshabilitarSitioInteres(entSitioInteres Sitio)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarSI", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codSitioInteres", Sitio.codSitioInteres);
                cmd.Parameters.AddWithValue("@estadoSI", Sitio.estadoSI);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilitar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return deshabilitar;
        }

    }
}

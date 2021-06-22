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
    public class datCasa
    {
        #region singleton
        private static datCasa _instancia = new datCasa();
        public static datCasa Instancia
        {
            get { return datCasa._instancia; }
        }
        #endregion singleton

        public Boolean RegistrarCasa(entCasa casa)
        {
            Boolean registrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarInmuebleCasa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID1", casa.InmuebleID1);
                cmd.Parameters.AddWithValue("@cantPisos", casa.cantPisos);
                cmd.Parameters.AddWithValue("@cantBao", casa.cantBaños);
                cmd.Parameters.AddWithValue("@cantHabitaciones", casa.cantHabitaciones);
                cmd.Parameters.AddWithValue("@piscina", casa.piscina);
                cmd.Parameters.AddWithValue("@jardine", casa.jardin);
                cmd.Parameters.AddWithValue("@areaM2", casa.areaM2);
                cmd.Parameters.AddWithValue("@fechaConstruccion", casa.fechaConstruccion);
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

        public List<entCasa> ListarInmuebleCasas()
        {
            List<entCasa> lista = new List<entCasa>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ListarCasa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCasa casa = new entCasa();
                    casa.InmuebleID1 = Convert.ToInt32(dr["InmuebleID1"]);
                    casa.cantPisos = Convert.ToInt32(dr["cantPisos"]);
                    casa.cantBaños = Convert.ToInt32(dr["cantBao"]);
                    casa.cantHabitaciones = Convert.ToInt32(dr["cantHabitaciones"]);
                    casa.piscina = Convert.ToBoolean(dr["piscina"]);
                    casa.jardin = Convert.ToBoolean(dr["jardine"]);
                    casa.areaM2 = (float)Convert.ToDouble(dr["areaM2"]);
                    casa.fechaConstruccion = Convert.ToDateTime(dr["fechaConstruccion"]);
                    
                    lista.Add(casa);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public entCasa DatosCasa(int idCasa)
        {
            entCasa casa = new entCasa();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDatosCasa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InmuebleID1", idCasa);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    casa.InmuebleID1 = Convert.ToInt32(dr["InmuebleID1"]);
                    casa.cantPisos = Convert.ToInt32(dr["cantPisos"]);
                    casa.cantBaños = Convert.ToInt32(dr["cantBao"]);
                    casa.cantHabitaciones = Convert.ToInt32(dr["cantHabitaciones"]);
                    casa.piscina = Convert.ToBoolean(dr["piscina"]);
                    casa.jardin = Convert.ToBoolean(dr["jardin"]);
                    casa.areaM2 = (float)Convert.ToDouble(dr["areM2"]);
                    casa.fechaConstruccion = Convert.ToDateTime(dr["fechaConstruccion"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return casa;
        }

    }
}

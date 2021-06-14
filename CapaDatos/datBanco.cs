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
    public class datBanco
    {
        #region singleton
        private static datBanco _instancia = new datBanco();

        public static datBanco Instancia
        {
            get { return datBanco._instancia; }
        }
        #endregion singleton

        public Boolean RegistrarBanco(entBanco banco)
        {
            Boolean registro = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("RegistroBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", banco.Nombre);
                cmd.Parameters.AddWithValue("@idbanco", banco.idbanco);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    registro = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return registro;
        }

        public List<entBanco> ListarBancos()
        {
            SqlCommand cmd = null;
            List<entBanco> lista = new List<entBanco>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entBanco banco = new entBanco();
                    banco.Nombre = dr["Nombre"].ToString();
                    banco.idbanco = Convert.ToInt32(dr["idbanco"]);
                    lista.Add(banco);
                }
            }
            catch (Exception e)
            {
                throw e;

            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean EditarBanco(entBanco banco)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", banco.Nombre);
                cmd.Parameters.AddWithValue("@idbanco", banco.idbanco);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    modificar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return modificar;
        }

        public Boolean BuscarBanco(entBanco banco)
        {
            Boolean encontrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("BuscarBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idbanco", banco.idbanco);
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

        public entBanco DatosBanco(int idbanco)
        {
            entBanco banco = new entBanco();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DatosBanco", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idbanco", idbanco);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    banco.Nombre = dr["Nombre"].ToString();
                    banco.idbanco = Convert.ToInt32(dr["idbanco"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return banco;
        }
    }
}
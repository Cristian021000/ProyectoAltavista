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
    public class datInmueble
    {
        #region singleton
        private static datInmueble _instancia = new datInmueble();
        public static datInmueble Instancia
        {
            get { return datInmueble._instancia; }
        }
        #endregion singleton

        public Boolean registrarInmueble(entInmueble inm)
        {

            SqlCommand cmd = null;
            Boolean registrar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_RegistrarInmueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSector", inm.idSector);
                cmd.Parameters.AddWithValue("@idPropietario", inm.idPropietario);
                cmd.Parameters.AddWithValue("@direccion", inm.direccion);
                cmd.Parameters.AddWithValue("@precio", inm.precio);
                cmd.Parameters.AddWithValue("@precioMinimo", inm.precioMinimo);
                cmd.Parameters.AddWithValue("@nRegistrosPublicos", inm.nRegistroPublico);
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

        public Boolean modificarInmueble(entInmueble inm)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_EditarInmueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdInmueble", inm.idInmueble);
                cmd.Parameters.AddWithValue("@Precio", inm.precio);
                cmd.Parameters.AddWithValue("@PrecioMinimo", inm.precio);
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

        public Boolean VenderInmueble(int idInm)
        {
            SqlCommand cmd = null;
            Boolean vendido = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_VenderInmueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdInmueble", idInm);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    vendido = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return vendido;

        }
        public Boolean InhabilitarInmueble(int idInm)
        {
            SqlCommand cmd = null;
            Boolean inhabilitado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_InhabilitarInmueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdInmueble", idInm);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inhabilitado = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inhabilitado;
        }

        public List<entInmueble> ListarInmuebleCasa()
        {
            SqlCommand cmd = null;
            List<entInmueble> lista = new List<entInmueble>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarinmuebleCasa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entInmueble inmueble = new entInmueble();
                    inmueble.idInmueble = Convert.ToInt32(dr["idInmueble"]);
                    inmueble.idSector = Convert.ToInt32(dr["idSector"]);
                    inmueble.idPropietario = Convert.ToInt32(dr["idPropietario"]);
                    inmueble.direccion = dr["direccion"].ToString();
                    inmueble.precio = Convert.ToInt32(dr["precio"]);
                    inmueble.precioMinimo = Convert.ToInt32(dr["precioMinimo"]);
                    inmueble.nRegistroPublico = Convert.ToInt32(dr["nRegistrosPublicos"]);
                    inmueble.vendido = Convert.ToBoolean(dr["vendido"]);
                    inmueble.habilitado = Convert.ToBoolean(dr["habilitado"]);
                    lista.Add(inmueble);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean BuscarInmuebleCasa(entInmueble inmueble)
        {
            SqlCommand cmd = null;
            Boolean encontrado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarInmuebleCasa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idInmueble", inmueble.idInmueble);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    encontrado = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return encontrado;
        }

        public entInmueble BuscarNRegistroPublico(int nRegistro)
        {
            entInmueble inmueble = new entInmueble();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarInmuebleNRegistro", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nRegistrosPublicos", nRegistro);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    inmueble.idInmueble = Convert.ToInt32(dr["idInmueble"]);
                    inmueble.idPropietario = Convert.ToInt32(dr["idPropietario"]);
                    inmueble.idSector = Convert.ToInt32(dr["idSector"]);
                    inmueble.direccion = dr["direccion"].ToString();
                    inmueble.precio = Convert.ToInt32(dr["precio"]);
                    inmueble.precioMinimo = Convert.ToInt32(dr["precioMinimo"]);
                    inmueble.nRegistroPublico = Convert.ToInt32(dr["nRegistrosPublicos"]);
                    inmueble.vendido = Convert.ToBoolean(dr["vendido"]);
                    inmueble.habilitado = Convert.ToBoolean(dr["Habilitado"]);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inmueble;
        }

        public entInmueble DatosInmueble(int idInmueble)
        {
            entInmueble inmueble = new entInmueble();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteNRegistroPublico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nDatosInmueble", idInmueble);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    inmueble.idInmueble = Convert.ToInt32(dr["idInmueble"]);
                    inmueble.idPropietario = Convert.ToInt32(dr["idPropietario"]);
                    inmueble.idSector = Convert.ToInt32(dr["idSector"]);
                    inmueble.direccion = dr["direccion"].ToString();
                    inmueble.precio = Convert.ToInt32(dr["precio"]);
                    inmueble.precioMinimo = Convert.ToInt32(dr["precioMinimo"]);
                    inmueble.nRegistroPublico = Convert.ToInt32(dr["nRegistrosPublicos"]);
                    inmueble.vendido = Convert.ToBoolean(dr["vendido"]);
                    inmueble.habilitado = Convert.ToBoolean(dr["Habilitado"]);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inmueble;
        }
    }
}

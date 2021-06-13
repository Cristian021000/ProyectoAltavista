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
    public class datAgente
    {
        #region singleton
        private static datAgente _instancia = new datAgente();

        public static datAgente Instancia
        {
            get { return datAgente._instancia; }
        }
        #endregion singleton
        public DataTable IngresoAgente(entAgente Agente)
        {
            SqlCommand cmd = null;   
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spIngresarAgente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@correo", Agente.correo);
                cmd.Parameters.AddWithValue("@contraseña", Agente.contraseña);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            
        }
        public Boolean RegistrarAgente(entAgente Agente)
        {
            Boolean registrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarAgente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@nombre", Agente.nombre);
                cmd.Parameters.AddWithValue("@apellido", Agente.apellido);
                cmd.Parameters.AddWithValue("@edad", Agente.edad);
                cmd.Parameters.AddWithValue("@celular", Agente.celular);
                cmd.Parameters.AddWithValue("@correo", Agente.correo);
                cmd.Parameters.AddWithValue("@contraseña", Agente.contraseña);
                cmd.Parameters.AddWithValue("@estado", Agente.estado);
                cmd.Parameters.AddWithValue("@dni", Agente.dni);
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
        public Boolean ExisteDatosAgente(entAgente Agente)
        {
            Boolean existe = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteDatosAgente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@correo", Agente.correo);
                cmd.Parameters.AddWithValue("@celular", Agente.celular);
                cmd.Parameters.AddWithValue("@dni", Agente.dni);
                cn.Open();
             
                SqlDataReader dr = cmd.ExecuteReader();
               
                if (dr.Read())
                {
                    existe = true;                
                }
               
                /*
                  

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    existe = true;
                }*/
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            
            
            return existe;
        }  

        public List<entAgente> ListarAgentes()
        {
            SqlCommand cmd = null;
            List<entAgente> lista = new List<entAgente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarAgentes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                { 
                    entAgente Age = new entAgente();
                    Age.estado = Convert.ToBoolean(dr["estado"]);
                    if (Age.estado)
                    {
                        Age.id = Convert.ToInt32(dr["id"]);
                        Age.dni = Convert.ToInt32(dr["dni"]);
                        Age.nombre = dr["nombre"].ToString();
                        Age.apellido = dr["apellido"].ToString();
                        Age.edad = Convert.ToInt32(dr["edad"]);
                        Age.celular = Convert.ToInt32(dr["celular"]);
                        Age.correo = dr["correo"].ToString();
                        Age.contraseña = dr["contraseña"].ToString();
                        lista.Add(Age);
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

        public Boolean ModificarAgente(entAgente Agente)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarAgente");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Agente.id);
                cmd.Parameters.AddWithValue("@dni", Agente.dni);
                cmd.Parameters.AddWithValue("@nombre", Agente.nombre);
                cmd.Parameters.AddWithValue("@apellido", Agente.apellido);
                cmd.Parameters.AddWithValue("@edad", Agente.edad);
                cmd.Parameters.AddWithValue("@celular", Agente.celular);
                cmd.Parameters.AddWithValue("@correo", Agente.correo);
                cmd.Parameters.AddWithValue("@contraseña", Agente.contraseña);
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
    }
}

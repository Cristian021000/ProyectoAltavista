﻿using System;
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
    }
}

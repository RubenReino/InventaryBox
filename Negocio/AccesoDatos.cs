using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector {
            get {return lector;}
        }
        //constructor
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            comando = new SqlCommand();
        }
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        //datareader establecer conexion
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {

            conexion.Open();
            lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void setearParametros(string parametro,object valor)
        {
            comando.Parameters.AddWithValue(parametro, valor);
        }
        public void ejecutarConsulta()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //cerrar
        public void cerrarConexion()
        {

            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }
    }
}

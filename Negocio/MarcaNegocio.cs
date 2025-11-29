using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listarMarca()
        {
            AccesoDatos data = new AccesoDatos();
            List<Marca> lista = new List<Marca>();

            try
            {
                data.setearConsulta("select id, descripcion from MARCAS");
                data.ejecutarLectura();
                while (data.Lector.Read()) { 
                Marca aux = new Marca();
                    aux.Id = (int)data.Lector["id"];
                    aux.Descripcion = data.Lector["descripcion"].ToString();
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }

        }
        public void AgregarMarca(Marca marca)
        {
            AccesoDatos data = new AccesoDatos();
            try
            {
                data.setearConsulta("insert into MARCAS (Descripcion) values (@marca)");
                data.setearParametros("@marca",marca.Descripcion);
                data.ejecutarConsulta();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }
 
    }
}

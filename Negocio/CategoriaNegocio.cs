using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listarCategoria()
        {
            AccesoDatos data = new AccesoDatos();
            List<Categoria> lista = new List<Categoria>();

            try
            {
                data.setearConsulta("select id, descripcion from CATEGORIAS");
                data.ejecutarLectura();
                while (data.Lector.Read())
                {
                    Categoria aux = new Categoria();
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
    }
}

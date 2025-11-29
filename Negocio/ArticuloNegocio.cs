using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        //Lectura a la base de datos para enlistar articulos
        public List<Articulo> listaArticulo()
        {
            List<Articulo>list = new List<Articulo>();
            AccesoDatos lectura = new AccesoDatos();
            try
            {
                lectura.setearConsulta("select Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, M.id as idmarca, C.Descripcion as Categoria, C.id as idcategoria, ImagenUrl,Precio , A.Id from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id");
                lectura.ejecutarLectura();

                while (lectura.Lector.Read())
                {

                    Articulo aux = new Articulo();
                    aux.Id = (int)lectura.Lector["Id"];
                    aux.CodigoArticulo = lectura.Lector["Codigo"].ToString();
                    aux.Nombre = lectura.Lector["Nombre"].ToString();
                    aux.Descripcion = lectura.Lector["Descripcion"].ToString();
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)lectura.Lector["idmarca"];
                    aux.Marca.Descripcion = lectura.Lector["Marca"].ToString();
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lectura.Lector["idcategoria"];
                    aux.Categoria.Descripcion = lectura.Lector["Categoria"].ToString();
                    aux.UrlImagen = lectura.Lector["ImagenUrl"].ToString();
                    aux.Precio = (decimal)lectura.Lector["Precio"];

                    list.Add(aux);
                }
                

                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                lectura.cerrarConexion();
            }
        }
        //sobrecarga del metodo listaArticulo para filtrar
        public List<Articulo> listaArticulo(string filtrarPor,string criterio, string buscar)
        {
            List<Articulo>list = new List<Articulo>();
            AccesoDatos lectura = new AccesoDatos();
            try
            {
                string consulta = "select Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, M.id as idmarca, C.Descripcion as Categoria, C.id as idcategoria, ImagenUrl,Precio , A.Id from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id and ";
                switch (filtrarPor)
                {
                    case "Código":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += $"Codigo LIKE '{buscar}%'";
                                break;
                            case "Termina con":
                                consulta += $"Codigo LIKE '%{buscar}'";
                                break;
                            default:
                                consulta += $"Codigo LIKE '%{buscar}%'";
                                break;
                        }
                        break;
                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += $"Nombre LIKE '{buscar}%'";
                                break;
                            case "Termina con":
                                consulta += $"Nombre LIKE '%{buscar}'";
                                break;
                            default:
                                consulta += $"Nombre LIKE '%{buscar}%'";
                                break;
                        }
                        break;
                    case "Marca":
                        consulta += $"M.Descripcion like '%{criterio}%'";
                        break;
                    case "Categoria":
                        consulta += $"C.Descripcion like '%{criterio}%'";
                        break;
                    default:
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += $"Precio >= {buscar}";
                                break;
                            case "Menor a":
                                consulta += $"Precio <= {buscar}";
                                break;
                            default:
                                consulta += $"Precio = {buscar}";
                                break;
                        }
                        break;
                }
                lectura.setearConsulta(consulta);
                lectura.ejecutarLectura();


                while (lectura.Lector.Read())
                {

                    Articulo aux = new Articulo();
                    aux.Id = (int)lectura.Lector["Id"];
                    aux.CodigoArticulo = lectura.Lector["Codigo"].ToString();
                    aux.Nombre = lectura.Lector["Nombre"].ToString();
                    aux.Descripcion = lectura.Lector["Descripcion"].ToString();
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)lectura.Lector["idmarca"];
                    aux.Marca.Descripcion = lectura.Lector["Marca"].ToString();
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lectura.Lector["idcategoria"];
                    aux.Categoria.Descripcion = lectura.Lector["Categoria"].ToString();
                    aux.UrlImagen = lectura.Lector["ImagenUrl"].ToString();
                    aux.Precio = (decimal)lectura.Lector["Precio"];

                    list.Add(aux);
                }
                

                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                lectura.cerrarConexion();
            }
        }

        //metodo eliminar de la base de datos
        public void eliminarAriculo(Articulo eliminar)
        {
            AccesoDatos data = new AccesoDatos();
            try
            {
                data.setearConsulta("delete from ARTICULOS where Codigo = @codigo");
                data.setearParametros("@codigo",eliminar.CodigoArticulo);
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
        //agregar articulo a la base de datos
        public void agregarArticulo(Articulo agregar)
        {
            AccesoDatos data = new AccesoDatos();
            try
            {
                data.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria,ImagenUrl,Precio) values (@codigo,@nombre,@descripcion,@idmarca,@idcategoria,@imagenurl,@precio)");
                data.setearParametros("@codigo",agregar.CodigoArticulo);
                data.setearParametros("@nombre",agregar.Nombre);
                data.setearParametros("@descripcion",agregar.Descripcion);
                data.setearParametros("@idmarca",agregar.Marca.Id);
                data.setearParametros("@idcategoria",agregar.Categoria.Id);
                data.setearParametros("@imagenurl",agregar.UrlImagen);
                data.setearParametros("@precio",agregar.Precio);
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
        public void modoficarArticulo(Articulo modificar)
        {
            AccesoDatos data = new AccesoDatos();
            try
            {
                data.setearConsulta("update ARTICULOS set codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idmarca, IdCategoria = @idcategoria, ImagenUrl = @urlimagen, Precio = @precio where id = @id");
                data.setearParametros("@codigo",modificar.CodigoArticulo);
                data.setearParametros("@nombre",modificar.Nombre);
                data.setearParametros("@descripcion",modificar.Descripcion);
                data.setearParametros("@idmarca",modificar.Marca.Id);
                data.setearParametros("@idcategoria",modificar.Categoria.Id);
                data.setearParametros("@urlimagen",modificar.UrlImagen);
                data.setearParametros("@precio",modificar.Precio);
                data.setearParametros("@id",modificar.Id);
                data.ejecutarLectura();
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

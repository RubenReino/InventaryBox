using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VentanaAgregar : Form
    {
        private Articulo articuloA=null;
        public Helper1 help = new Helper1();
        public VentanaAgregar()
        {
            InitializeComponent();
        }
        public VentanaAgregar(Articulo seleccion)
        {
            InitializeComponent();
            this.articuloA = seleccion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentanaAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            try
            {

                    cboMarca.DataSource = marca.listarMarca();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                    cboCategoria.DataSource = categoria.listarCategoria();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                if (articuloA != null)
                {
                    lblAgregarA.Text = "Modificar Articulo";
                    btnAgregar.Text = "Modificar";
                    txtCodigoArticulo.Text = articuloA.CodigoArticulo;
                    txtNombre.Text = articuloA.Nombre;
                    txtDescripcion.Text = articuloA.Descripcion;
                    cboMarca.SelectedValue = articuloA.Marca.Id;
                    cboCategoria.SelectedValue = articuloA.Categoria.Id;
                    txtUrlImagen.Text = articuloA.UrlImagen;
                    help.cargarImagen(pboUrlImagen2,txtUrlImagen.Text);
                    txtPrecio.Text = articuloA.Precio.ToString(".00");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio nuevo = new ArticuloNegocio();
            DialogResult ok;
            try
            {
                if (articuloA == null)
                {
                    articuloA = new Articulo();
                }
                articuloA.CodigoArticulo = txtCodigoArticulo.Text;
                articuloA.Nombre = txtNombre.Text;
                articuloA.Descripcion = txtDescripcion.Text;
                articuloA.Marca = (Marca)cboMarca.SelectedItem;
                articuloA.Categoria = (Categoria)cboCategoria.SelectedItem;
                articuloA.UrlImagen = txtUrlImagen.Text;
                if (!(help.validarNumero(txtPrecio.Text)))
                {
                    MessageBox.Show("Por favor solo ingrese numeros en el precio");
                    help.validarF(lblOblig3, true);
                }
                else
                {
                            articuloA.Precio = decimal.Parse(txtPrecio.Text);
                        if (txtCodigoArticulo.Text != "" && txtNombre.Text != "")
                        {
                            help.validarF(lblOblig1,lblOblig2,lblOblig3);
                            if (articuloA.Id != 0)
                            {
                               ok= MessageBox.Show($"Estas seguro que deseas modificar el articulo {txtNombre.Text}","Modificando...",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                                if (ok == DialogResult.OK) 
                                { 
                            nuevo.modoficarArticulo(articuloA);
                            MessageBox.Show("Articulo Modificado exitosamente!");
                                }
                            }
                            else
                            {
                               ok= MessageBox.Show($"Estas seguro que deseas Agregar el articulo {txtNombre.Text}","Agregando...",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                                if (ok == DialogResult.OK)
                                {
                                    nuevo.agregarArticulo(articuloA);
                                    MessageBox.Show("Articulo agregado exitosamente!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor llene los espacios obligatorios (*)");
                            help.validarF(lblOblig1,lblOblig2,true);
                        }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            help.cargarImagen(pboUrlImagen2, txtUrlImagen.Text);

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            string direccion = @"C:\articulo-app";
            archivo.Filter = "JPG|*.jpg|PNG|*.png|PNG|*.jpg|JFIF|*.jfif";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                //validar si existe la carpeta, si no se crea, por el momento en C:\
                if (!Directory.Exists(direccion))
                {
                    Directory.CreateDirectory(direccion);
                }
                txtUrlImagen.Text = archivo.FileName;
                help.cargarImagen(pboUrlImagen2,txtUrlImagen.Text);
                File.Copy(archivo.FileName,ConfigurationManager.AppSettings["images-folder"]+archivo.SafeFileName);
            }
        }
    }
}

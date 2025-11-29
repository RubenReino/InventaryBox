using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VentanaDetalles : Form
    {
        private Articulo seleccionado;
        private Helper1 help = new Helper1();
        public VentanaDetalles()
        {
            InitializeComponent();
        }
        public VentanaDetalles(Articulo Seleccionado)
        {
            InitializeComponent();
            this.seleccionado = Seleccionado;
        }

        private void VentanaDetalles_Load(object sender, EventArgs e)
        {
            string imagen = seleccionado.UrlImagen;
            help.cargarImagen(pboDetallesA,imagen);
            lblCodigoAr.Text = seleccionado.CodigoArticulo;
            lblNombreA.Text = seleccionado.Nombre;
            lblDescripcionA.Text = seleccionado.Descripcion;
            lblMarcaA.Text = seleccionado.Marca.ToString();
            lblCategoriaA.Text = seleccionado.Categoria.ToString();
            lblPrecioA.Text = seleccionado.Precio.ToString(".0");


        }

    }
}

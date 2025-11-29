using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class VentanaPrincipal : Form
    {
        private List<Articulo> listaArticulos;
        private Articulo articuloA = null;
        private Helper1 help = new Helper1();
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            SplashInicial nuevo = new SplashInicial();
            nuevo.ShowDialog();
            cargarVentanaP();
            cboFiltrarPor.Items.Add("Código");
            cboFiltrarPor.Items.Add("Nombre");
            cboFiltrarPor.Items.Add("Marca");
            cboFiltrarPor.Items.Add("Categoria");
            cboFiltrarPor.Items.Add("Precio");
        }
        // Carga los artículos desde la capa de negocio y los muestra en el DataGridView
        private void cargarVentanaP()
        {
            ArticuloNegocio Listar = new ArticuloNegocio();
            listaArticulos = Listar.listaArticulo();
            try
            {
            dgvArticulos.DataSource = listaArticulos;
                    help.ocultarColumnas(dgvArticulos);
                pboUrlImagen.Visible = false;
                if (dgvArticulos.SelectedRows.Count >0)
                {
                    pboUrlImagen.Visible = true;
                    help.cargarImagen(pboUrlImagen,listaArticulos[0].UrlImagen);
                }
                    btnDetalles.Text = "\u2630 Ver detalles";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        //articulo seleccionado
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                panelDetalle.Visible = false;
                btnBack.Visible = false;
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            articuloA = seleccionado;
            help.cargarImagen(pboUrlImagen,seleccionado.UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        //Agregar articulo
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            VentanaAgregar agregar = new VentanaAgregar();
            agregar.ShowDialog();
            cargarVentanaP();
        }
        //Modificar o cambiar articulo
        private void btnModificar_Click(object sender, EventArgs e)
        {
            VentanaAgregar agregar = new VentanaAgregar(articuloA);
            agregar.ShowDialog();
            cargarVentanaP();
        }
        //eliminar articulo
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio eliminar = new ArticuloNegocio();
            DialogResult resultado;
            try
            {
                    resultado = MessageBox.Show($"Estas seguro de eliminar el articulo {articuloA.Nombre}?", "Eliminando", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {

                        eliminar.eliminarAriculo(articuloA);
                        MessageBox.Show("Eliminado exitosamente!");
                        cargarVentanaP();
                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        //Filtro Rapido
        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrados;
            string filtro = txtFiltroRapido.Text;
            try
            {
                if (filtro != "")
                {
                    listaFiltrados = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper())|| x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                }
                else
                {
                    listaFiltrados = listaArticulos;
                }
                dgvArticulos.DataSource = listaFiltrados;
                help.ocultarColumnas(dgvArticulos);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        //cargar comboBox Criterio
        private void cboFiltrarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            string seleccionado = cboFiltrarPor.SelectedItem.ToString();
            help.validarF(lblObligatorio1,lblObligatorio2,lblObligatorio3);

                cboCriterio.DataSource = null;
                cboCriterio.Items.Clear();
            if (seleccionado == "Código" || seleccionado == "Nombre")
            {
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }else if (seleccionado == "Marca")
            {
                    cboCriterio.DataSource = marca.listarMarca();

            }else if (seleccionado == "Categoria")
            {
                    cboCriterio.DataSource = categoria.listarCategoria();

            }else
            {
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }

        }
        //filtro avanzado logica y validaciones
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio filtrar = new ArticuloNegocio();

            try
            {

                if (cboFiltrarPor.SelectedIndex < 0 && cboCriterio.SelectedIndex < 0)
                {
                    MessageBox.Show("Por davor seleccione el campo a filtrar y un criterio");
                    help.validarF(lblObligatorio1, lblObligatorio2, true);
                }
                else if (cboCriterio.SelectedIndex < 0)
                {
                    help.validarF(lblObligatorio1);
                    help.validarF(lblObligatorio2, true);
                    MessageBox.Show("Por favor seleccione un criterio para filtrar");
                }
                else if (!txtFiltroAvanzado.Visible || txtFiltroAvanzado.Text != "")
                {
                        if (cboFiltrarPor.SelectedIndex == 4 && !(help.validarNumero(txtFiltroAvanzado.Text)))
                        {
                            MessageBox.Show("Por favor solo ingrese numeros para filtar por precio");
                            help.validarF(lblObligatorio3,true);
                        }
                    else
                    {

                        help.validarF(lblObligatorio1, lblObligatorio2, lblObligatorio3);
                    txtFiltroAvanzado.BackColor = Color.White;
                string filtrarPor = cboFiltrarPor.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string buscar = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = filtrar.listaArticulo(filtrarPor, criterio, buscar);
                help.ocultarColumnas(dgvArticulos);
                    }
                }
                else
                {
                    help.validarF(lblObligatorio3, true);
                    txtFiltroAvanzado.BackColor = Color.LavenderBlush;
                    MessageBox.Show("Por favor ingrese un Dato a filtrar");
                    help.validarF(lblObligatorio1, lblObligatorio2, lblObligatorio3);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        //limpiar filtro
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = listaArticulos;
            txtFiltroAvanzado.Clear();
            panelDetalle.Visible = false;
        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            help.validarF(lblObligatorio1, lblObligatorio2, lblObligatorio3);
            if (cboFiltrarPor.SelectedItem != null)
            {
                if (cboFiltrarPor.SelectedItem.ToString() == "Marca" || cboFiltrarPor.SelectedItem.ToString() == "Categoria")
                {
                    txtFiltroAvanzado.Visible = false;
                }
                else
                {
                    txtFiltroAvanzado.Visible = true;
                }
            }
        }
        //Deshabilitar botones cuando la lista esté vacia
        private void dgvArticulos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            btnModificar.Enabled = dgvArticulos.Rows.Count > 0;
            btnEliminar.Enabled = dgvArticulos.Rows.Count > 0;
            btnDetalles.Enabled = dgvArticulos.Rows.Count > 0;
        }
        //Metodo para ingresar form detalles al panel
        private void cargarDetalles(Form detalle)
        {
            panelDetalle.Controls.Clear();
            detalle.TopLevel = false;
            detalle.Dock = DockStyle.Fill;
            panelDetalle.Controls.Add(detalle);
            detalle.Show();
        }
        //Mostrar detalles del articulo
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            VentanaDetalles detalles = new VentanaDetalles(articuloA);
            cargarDetalles(detalles);
            btnDetalles.SendToBack();
            pboUrlImagen.SendToBack();
            btnBack.Visible = true;
            panelDetalle.Visible = true;

        }
        //Salir de detalles
        private void btnBack_Click(object sender, EventArgs e)
        {
            panelDetalle.Visible = false;
            btnBack.Visible = false;
        }

        private void marcaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AgregarMarca marca = new AgregarMarca();
            marca.ShowDialog();
            cargarVentanaP();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si presentas algun inconveniente, por favor contacte al desarrollador: \n ramdonsrein@gmail.com");
        }
    }
}

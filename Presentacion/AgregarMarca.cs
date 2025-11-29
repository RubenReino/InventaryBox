using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class AgregarMarca : Form
    {
        public AgregarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio listarMarca = new MarcaNegocio(); 

            try
            {
                cboMarcas.DataSource = listarMarca.listarMarca();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio agregar = new MarcaNegocio();

            try
            {
                if (!(string.IsNullOrWhiteSpace(txtMarca.Text)))
                {
                    txtMarca.BackColor = Color.White;
                    lblObligMarca.Visible = false;
                marca.Descripcion = txtMarca.Text;
                    agregar.AgregarMarca(marca);
                    MessageBox.Show($"Se agregó la marca {txtMarca.Text}");
                }
                else
                {
                    txtMarca.BackColor = Color.LavenderBlush;
                    lblObligMarca.Visible = true;
                    MessageBox.Show("Por favor ingrese una marca para agregar!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}

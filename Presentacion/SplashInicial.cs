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
    public partial class SplashInicial : Form
    {
        private Timer tiempo;
        private int contador = 0;
        public SplashInicial()
        {
            InitializeComponent();

        }

        private void SplashInicial_Load(object sender, EventArgs e)
        {
            tiempo = new Timer();
            tiempo.Interval = 20;
            tiempo.Tick += tiempo_Tick;
            tiempo.Start();
        }
        private void tiempo_Tick(object sender, EventArgs e) {


            if (this.Opacity > 0)
            {
                if (contador > 170)
                {
                this.Opacity -= 0.03;

                }
                else
                {
                    contador++;
                }

            }
            else { 
            tiempo.Stop();
            this.Close();
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocio;

namespace SourvenirAppMathiasMelo
{
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        public void Eliminar()
        {
            int id = Int32.Parse(txtIDBaja.Text);
            ControladorBaja.baja(id);

        }

        public void menuAlta()
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnAltaBaja_Click(object sender, EventArgs e)
        {

        }
    }
}

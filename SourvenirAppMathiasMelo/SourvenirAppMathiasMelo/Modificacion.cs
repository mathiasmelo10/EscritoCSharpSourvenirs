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
    public partial class Modificacion : Form
    {
        public Modificacion()
        {
            InitializeComponent();
        }

        public void actualizarNombre()
        {
            int id = Int32.Parse(txtIDModificar.Text);
            string nombre = txtNombreModificar.Text;
            ControladorModificacion.modificarNombre(id, nombre);
              
        }

        public void actualizarDescripcion()
        {
            int id = Int32.Parse(txtIDModificar.Text);
            string descripcion = txtDescripcionModificar.Text;
            ControladorModificacion.modificarDescripcion(id, descripcion);
        }

        public void actualizarStock()
        {
            int id = Int32.Parse(txtIDModificar.Text);
            int stock = Int32.Parse(txtStockModificar.Text);
            ControladorModificacion.modificarStock(id, stock);
        }

        public void actualizarPrecio()
        {
            int id = Int32.Parse(txtIDModificar.Text);
            decimal precio = Decimal.Parse(txtPrecioModificar.Text);
            ControladorModificacion.modificarPrecio(id, precio);
        }

        public void actualizarFechaAlta()
        {
            int id = Int32.Parse(txtIDModificar.Text);
            DateTime fecha = dtpFechaModificar.Value;
            ControladorModificacion.modificarFechaAlta(id, fecha);
        }

        private void btnActualizarNombre_Click(object sender, EventArgs e)
        {
            actualizarNombre();
        }

        private void btnActualizarDesc_Click(object sender, EventArgs e)
        {
            actualizarDescripcion();
        }

        private void btnActualizarStock_Click(object sender, EventArgs e)
        {
            actualizarStock();
        }

        private void btnActualizarPrecio_Click(object sender, EventArgs e)
        {
            actualizarPrecio();
        }

        private void btnActualizarFecha_Click(object sender, EventArgs e)
        {
            actualizarFechaAlta();
        }
    }
}

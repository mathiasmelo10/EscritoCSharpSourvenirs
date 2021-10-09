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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
            
        }

        

        public void Ingresar()
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            int stock = Int32.Parse(txtStockAlta.Text);
            decimal precio = Decimal.Parse(txtPrecio.Text);
            DateTime fecha = dtpFecha.Value;
            ControladorAlta.alta(nombre, descripcion, stock, precio, fecha);
        }

        public void menuBaja()
        {
            Baja formBaja = new Baja();
            formBaja.Show();
        }

        public void menuModificacion()
        {
            Modificacion formMod = new Modificacion();
            formMod.Show();
        }

        public void menuListado()
        {
            Listado formListado = new Listado();
            formListado.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            menuBaja();
        }

        private void btnModifacion_Click(object sender, EventArgs e)
        {
            menuModificacion();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            menuListado();
        }
    }
}

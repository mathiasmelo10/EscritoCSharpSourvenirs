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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }
    }
}

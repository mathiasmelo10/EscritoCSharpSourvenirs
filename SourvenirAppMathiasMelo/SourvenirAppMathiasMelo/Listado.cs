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
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }

        public void Listar()
        {

            dGVListado.DataSource = ControladorListado.listarSouvenirs();


        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
            
        }
    }
}

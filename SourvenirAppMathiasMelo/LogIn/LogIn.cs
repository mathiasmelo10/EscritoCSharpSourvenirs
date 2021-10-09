using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SourvenirAppMathiasMelo;



namespace LogIn
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        public void ingresar()
        {
            Alta form = new Alta();
            form.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresar();
        }
    }
}

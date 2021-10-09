using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaDeNegocio
{
   public static class ControladorBaja
    {
        public static void baja(int souvenirID)
        {
            ModeloSouvenirs bajaSouvenir = new ModeloSouvenirs();
            bajaSouvenir.souvenirID = (souvenirID);
            bajaSouvenir.bajaSouvenir(souvenirID);
            
        }
    }
}

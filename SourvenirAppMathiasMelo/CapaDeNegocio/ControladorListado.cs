using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;

namespace CapaDeNegocio
{
    public static class ControladorListado
    {
        public static DataTable listarSouvenirs()
        {
            ModeloSouvenirs souvenirsListados = new ModeloSouvenirs();
            return souvenirsListados.listadoSouvenirs();
        }
    }
}

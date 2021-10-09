using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;





namespace CapaDeNegocio 
{
    public static class ControladorAlta 
    {
        public static void alta(string nombre, string descripcion, int stock , decimal precio, DateTime fecha_alta) 
        {
            ModeloSouvenirs altaSouvenir = new ModeloSouvenirs();
            altaSouvenir.nombre = nombre;
            altaSouvenir.descripcion = descripcion;
            altaSouvenir.stock = stock;
            altaSouvenir.precio = precio;
            altaSouvenir.fecha_alta = fecha_alta;
            altaSouvenir.altaSouvenir(nombre, descripcion, stock, precio, fecha_alta);
        }
    }
}

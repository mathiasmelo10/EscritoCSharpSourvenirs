using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaDeNegocio
{
    public static class ControladorModificacion
    {
        public static void modificarNombre (int souvenirID, string nombre)
        {
            ModeloSouvenirs modificarNombre = new ModeloSouvenirs();
            modificarNombre.souvenirID = souvenirID;
            modificarNombre.nombre = nombre;
            modificarNombre.modificarNombreSouvenir(souvenirID, nombre);
        }

        public static void modificarDescripcion (int souvenirID, string descripcion)
        {
            ModeloSouvenirs modificarDescripcion = new ModeloSouvenirs();
            modificarDescripcion.souvenirID = souvenirID;
            modificarDescripcion.descripcion = descripcion;
            modificarDescripcion.modificarDescripcionSouvenir(souvenirID, descripcion);
        }

        public static void modificarStock (int souvenirID, int stock)
        {
            ModeloSouvenirs modificarStock = new ModeloSouvenirs();
            modificarStock.souvenirID = souvenirID;
            modificarStock.stock = stock;
            modificarStock.modificarStockSouvenir(souvenirID, stock);
        }

        public static void modificarPrecio (int souvenirID,decimal precio)
        {
            ModeloSouvenirs modificarPrecio = new ModeloSouvenirs();
            modificarPrecio.souvenirID = souvenirID;
            modificarPrecio.precio = precio;
            modificarPrecio.modificarPrecioSouvenir(souvenirID, precio);

        }

        public static void modificarFechaAlta (int souvenirID, DateTime fecha_alta)
        {
            ModeloSouvenirs modificarFechaAlta = new ModeloSouvenirs();
            modificarFechaAlta.souvenirID = souvenirID;
            modificarFechaAlta.fecha_alta = fecha_alta;
            modificarFechaAlta.modificarFechaAltaSouvenir(souvenirID, fecha_alta);
        }

    }
}

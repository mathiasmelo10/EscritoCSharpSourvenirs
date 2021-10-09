using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace CapaDeDatos
{
   public class ModeloSouvenirs : ModeloConexion
    {
        public int souvenirID { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public decimal precio { get; set; }
        public DateTime fecha_alta { get; set; }

        public void altaSouvenir(string nombre, string descripcion, int stock, decimal precio, DateTime fecha_alta )
        {
            string comandoString;
            comandoString =
                "INSERT INTO souvenirs" +
                "(nombre, descripcion, stock, precio, fecha_de_alta)" +
                "VALUES(@nombre, @descripcion, @stock, @precio, @fecha_de_alta);";
            comando.CommandText = comandoString;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@fecha_de_alta", fecha_alta);
            abrirConexion();
            comando.Prepare();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            cerrarConexion();
        }

        public void bajaSouvenir(int souvenirID)
        {
            string comandoString;
            comandoString =
                "DELETE FROM souvenirs" +
                "WHERE id_souvenir=@souvenirID;";
            comando.CommandText = comandoString;
            comando.Parameters.AddWithValue("@souvenirID", souvenirID);
            abrirConexion();
            comando.Prepare();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            cerrarConexion();

        }

        public void modificarNombreSouvenir(int souvenirID, string nombre)
        {
            string comandoString;
            comandoString =
                "UPDATE souvenirs" +
                "SET nombre = @nombre" +
                "WHERE id_souvenir = @id_souvenir;";
            this.comando.CommandText = comandoString;
            this.comando.Parameters.AddWithValue("@id_souvenir", souvenirID);
            this.comando.Parameters.AddWithValue("@nombre", nombre);
            this.abrirConexion();
            this.comando.Prepare();
            this.comando.ExecuteNonQuery();
            this.comando.Parameters.Clear();
            this.cerrarConexion();
        }

        public void modificarDescripcionSouvenir(int souvenirID, string descripcion)
        {
            string comandoString;
            comandoString =
                "UPDATE souvenirs" +
                "SET descripcion = @descripcion" +
                "WHERE id_souvenir = @id_souvenir;";
            this.comando.CommandText = comandoString;
            this.comando.Parameters.AddWithValue("@id_souvenir", souvenirID);
            this.comando.Parameters.AddWithValue("@descripcion", descripcion);
            this.abrirConexion();
            this.comando.Prepare();
            this.comando.ExecuteNonQuery();
            this.comando.Parameters.Clear();
            this.cerrarConexion();
        }

        public void modificarStockSouvenir(int souvenirID, int stock)
        {
            string comandoString;
            comandoString =
                "UPDATE souvenirs" +
                "SET stock = @stock" +
                "WHERE id_souvenir = @id_souvenir;";
            this.comando.CommandText = comandoString;
            this.comando.Parameters.AddWithValue("@id_souvenir", souvenirID);
            this.comando.Parameters.AddWithValue("@stock", stock);
            this.abrirConexion();
            this.comando.Prepare();
            this.comando.ExecuteNonQuery();
            this.comando.Parameters.Clear();
            this.cerrarConexion();
        }

        public void modificarPrecioSouvenir(int souvenirID, decimal precio)
        {
            string comandoString;
            comandoString =
                "UPDATE souvenirs" +
                "SET precio = @precio" +
                "WHERE id_souvenir = @id_souvenir;";
            this.comando.CommandText = comandoString;
            this.comando.Parameters.AddWithValue("@id_souvenir", souvenirID);
            this.comando.Parameters.AddWithValue("@precio", precio);
            this.abrirConexion();
            this.comando.Prepare();
            this.comando.ExecuteNonQuery();
            this.comando.Parameters.Clear();
            this.cerrarConexion();
        }

        public void modificarFechaAltaSouvenir(int souvenirID, DateTime fecha_alta)
        {
            string comandoString;
            comandoString =
                "UPDATE souvenirs" +
                "SET fecha_alta = @fecha_alta" +
                "WHERE id_souvenir = @id_souvenir;";
            this.comando.CommandText = comandoString;
            this.comando.Parameters.AddWithValue("@id_souvenir", souvenirID);
            this.comando.Parameters.AddWithValue("@fecha_alta", fecha_alta);
            this.abrirConexion();
            this.comando.Prepare();
            this.comando.ExecuteNonQuery();
            this.comando.Parameters.Clear();
            this.cerrarConexion();
        }


        public DataTable listadoSouvenirs()
        {
            DataTable listado = new DataTable();
            string comandoString;
            comandoString =
                "SELECT nombre ,descripcion, stock , precio ,fecha_alta" +
                "VALUES(@nombre, @descripcion, @stock, @precio, @fecha_alta)" +
                "FROM souvenirs" +
                "WHERE id_souvenir = @id_souvenir;";
            comando.CommandText = comandoString;
            comando.Parameters.AddWithValue("@id_souvenir", souvenirID);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@fecha_alta", fecha_alta);
            ejecutarYLeer();
            conexion.Close();
            return leerTabla();
        }

        
    }
}

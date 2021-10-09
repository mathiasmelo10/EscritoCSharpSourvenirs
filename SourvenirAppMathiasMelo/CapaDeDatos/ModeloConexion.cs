using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace CapaDeDatos
{
    public class ModeloConexion
    {
        public string nombreDB { get; set; }
        public string usuarioDB { get; set; }
        public string passwordDB { get; set; }
        public string puertoDB { get; set; }
        public string servidorDB { get; set; }
        public MySqlCommand comando { get; set; }
        public MySqlDataReader lector { get; set; }
        public MySqlConnection conexion { get; set; }

        private SouvenirsDB confDeConexion = new SouvenirsDB();

        public ModeloConexion()
        {
            comando = new MySqlCommand();
            conexion = new MySqlConnection();
            nombreDB = confDeConexion.nombreDB;
            usuarioDB = confDeConexion.usuarioDB;
            passwordDB = confDeConexion.passwordDB;
            puertoDB = confDeConexion.puertoDB;
            servidorDB = confDeConexion.servidorDB;

        }

      

        public void abrirConexion()
        {
            comando.Connection = conexion;
            conexion.ConnectionString =
                "servidor" + servidorDB + ";" +
                "puerto" + puertoDB + ";" +
                "usuario" + usuarioDB + ";" +
                "password" + passwordDB + ";" +
                "database" + nombreDB + ";";

            try
            {
                conexion.Open();
                Console.WriteLine("Conexion Abierta");
            }
            catch (MySqlException excepcion)
            {
                Console.WriteLine("" + excepcion);
            }
        }

        public void cerrarConexion()
        {
            conexion.Close();
            Console.WriteLine("Conexion Cerrada");
        }

        public void ejecutarYLeer()
        {
            try
            {
                comando.Prepare();
                if (lector != null)
                    lector.Close();
                lector = comando.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                comando.Parameters.Clear();
            }
        }

        public DataTable leerTabla()
        {
            DataTable resultado = new DataTable();
            try
            {
                if (lector.HasRows)
                {
                    resultado.Load(lector);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                comando.Parameters.Clear();
            }
            return resultado;
        }

    }

}

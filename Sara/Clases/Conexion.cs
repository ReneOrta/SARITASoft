using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sara.Clases
{
    class Conexion
    {
        MySqlConnection conn = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "sarita";
        static string usuario = "root";
        static string password = "1234";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario
           + ";" + "password=" + password + ";" + "database=" + bd + ";";



        public MySqlConnection conectar()
        {
            try
            {
                conn.ConnectionString = cadenaConexion;
                conn.Open();
                // MessageBox.Show("Se logró conectarse a la base de datos");
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No se puede conectar a la base de datos, error:" + e.ToString());
            }

            return conn;

        }

        public void desconectar()
        {
            conn.Close();

        }
    }
}

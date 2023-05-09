using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sara.Clases
{
    class CPedido
    {
        public void mostrarPedidos(DataGridView tabla_Ped)
        {
            try
            {
                Conexion conn = new Conexion();// Objeto de conexión a la base de datos
                tabla_Ped.DataSource = null;//Se incializa la funte de los datos en null
                String consulta = "select * from pedido";
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conn.conectar());//Se hace la consulta a la base de datos
                DataTable dt = new DataTable(); // Objeto de tipo tabla de datos donde se mostrara el contenido de la consulta
                adapter.Fill(dt);
                tabla_Ped.DataSource = dt;
                conn.desconectar();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());

            }

        }

        public void agregarPedidos(NumericUpDown id_ped, TextBox total, DateTimePicker fecha_pedido)
        {
            try
            {

                Conexion conn = new Conexion();// Objeto de conexión a la base de datos

                //Guardar la consulta para hacer el insert
                String consulta = "insert into pedido(id_ped, total, fecha_pedido) values" +
                    "(" + ((int)id_ped.Value) + "," + total.Text + ",'" + fecha_pedido.Text + "');";

                MySqlCommand comando = new MySqlCommand(consulta, conn.conectar());

                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Producto guardado correctamente");

                /*
                while (reader.Read()) { 
                
                }*/

                conn.desconectar();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los registros, error: " + ex.ToString());

            }

        }

        public void seleccionarPedidos(DataGridView tabla, ComboBox estadopedido, TextBox total,
            DateTimePicker fecha_pedido, DateTimePicker fecha_entrega, TextBox id)
        {
            try
            {

                estadopedido.Text = tabla.CurrentRow.Cells[1].Value.ToString();
                total.Text = tabla.CurrentRow.Cells[2].Value.ToString();
                fecha_pedido.Text = tabla.CurrentRow.Cells[3].Value.ToString();
                fecha_entrega.Text = tabla.CurrentRow.Cells[4].Value.ToString();
                id.Text = tabla.CurrentRow.Cells[0].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lograron seleccionar los datos, error: " + ex.ToString());
            }
        }

        public void eliminarPedidos(TextBox id_ped)
        {
            try
            {
                Conexion conn = new Conexion();// Objeto de conexión a la base de datos

                //Guardar la consulta para hacer el insert
                String consulta = "delete from pedido where id_ped=" + id_ped.Text + ";";

                MySqlCommand comando = new MySqlCommand(consulta, conn.conectar());

                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Pedido eliminado correctamente");

                /*
                while (reader.Read()) { 
                
                }*/

                conn.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto ingresado no existe, error: " + ex.ToString());
            }
        }
        public void ComboBoxPedidos(ComboBox combobox)
        {

            Conexion con = new Conexion();


            try
            {
                // Abrir la conexión


                // Crear el comando SQL para obtener los valores
                string query = "SELECT nom_prod FROM producto";
                MySqlCommand command = new MySqlCommand(query, con.conectar());

                // Crear el adaptador de datos y llenar un DataSet
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                // Obtener la tabla con los datos
                DataTable dataTable = dataSet.Tables[0];

                // Agregar los valores al ComboBox
                foreach (DataRow row in dataTable.Rows)
                {
                    combobox.Items.Add(row["nom_prod"].ToString());
                }
            }

            catch (Exception ex)
            {
                // Manejar cualquier error de conexión o consulta
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                con.desconectar();
            }
        }

        public decimal ObtenerPrecioDesdeBaseDeDatos()
        {

            string servidor = "localhost";
            string bd = "sarita";
            string usuario = "root";
            string password = "1234";
            string puerto = "3306";

            string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario
               + ";" + "password=" + password + ";" + "database=" + bd + ";";

            decimal precio = 0;
            Conexion con = new Conexion();

            using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
            {
                string query = "SELECT pre_prod  FROM producto";
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    precio = Convert.ToDecimal(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de registro");
                }


                return precio;
            }
                
}

    }
}

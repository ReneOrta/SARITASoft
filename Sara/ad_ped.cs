using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Sara
{
    public partial class ad_ped : Form
    {
        List<Dictionary<string, object>> datos = new List<Dictionary<string, object>>();
        public ad_ped()
        {
            InitializeComponent();
            Clases.CPedido ped = new Clases.CPedido();
            ped.ComboBoxPedidos(comboBox1);
            datos = ped.ObtenerTodo();
            List<string> columnNames = new List<string>();
            if (datos.Count > 0)
            {
                foreach (string columnName in datos[0].Keys)
                {
                    columnNames.Add(columnName);
                }
            }

            // Imprimir los encabezados de las columnas
            foreach (string columnName in columnNames)
            {
                Console.Write("{0,-15}", columnName);
            }
            Console.WriteLine();

            // Imprimir los datos de las filas
            foreach (Dictionary<string, object> fila in datos)
            {
                foreach (string columnName in columnNames)
                {
                    object columnValue;
                    if (fila.TryGetValue(columnName, out columnValue))
                    {
                        Console.Write("{0,-15}", columnValue);
                    }
                    else
                    {
                        Console.Write("{0,-15}", string.Empty);
                    }
                }
                Console.WriteLine();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                Clases.Conexion conecta = new Clases.Conexion();
                Clases.CPedido con = new Clases.CPedido();

                conecta.conectar();

                // Obtener el valor del NumericUpDown
                decimal cantidad = numericUpDown2.Value;

                // Obtener el precio desde la base de datos (aquí debes implementar tu lógica para obtener el precio)
                decimal precio = con.ObtenerPrecioDesdeBaseDeDatos();

                // Calcular el costo
                decimal costo = cantidad * precio;

                // Obtener el valor seleccionado del ComboBox
                string valorSeleccionado = comboBox1.SelectedItem.ToString();

                // Verificar si el producto ya existe en el DataGridView
                bool productoYaExiste = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string productoExistenteEnFila = Convert.ToString(row.Cells["prod"].Value);

                    if (productoExistenteEnFila == valorSeleccionado)
                    {
                    productoYaExiste = true;
                        break;
                    }
                }

                if (productoYaExiste)
                {
                    MessageBox.Show("El producto ya existe en el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Agregar la nueva fila al DataGridView
                    dataGridView1.Rows.Add(valorSeleccionado, cantidad, costo);

                    decimal total = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        total += Convert.ToDecimal(row.Cells["price"].Value);
                    }

                    // Mostrar el resultado en el TextBox
                    textBox1.Text = total.ToString();
                
            }

            /* Clases.Conexion conecta = new Clases.Conexion();
             Clases.CPedido con = new Clases.CPedido();

             conecta.conectar();

             // Obtener el valor del NumericUpDown
             decimal cantidad = numericUpDown2.Value;

             // Obtener el precio desde la base de datos (aquí debes implementar tu lógica para obtener el precio)
             decimal precio = con.ObtenerPrecioDesdeBaseDeDatos();

             // Calcular el costo
             decimal costo = cantidad * precio;

             string valorSeleccionado = comboBox1.SelectedItem.ToString();
             int numeroSeleccionado = (int)numericUpDown2.Value;

             dataGridView1.Rows.Add(valorSeleccionado, numeroSeleccionado, costo);

             decimal total = 0;
             foreach (DataGridViewRow row in dataGridView1.Rows)
             {
                 total += Convert.ToDecimal(row.Cells["price"].Value);
             }

             // Mostrar el resultado en el TextBox
             textBox1.Text = total.ToString();*/


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string total = textBox1.Text;
            int id_ped = (int)numericUpDown1.Value;
            DateTime fecha_pedido = fecha_cad.Value;

            // Obtener los datos del DataGridView
            List<int> cantidades = new List<int>();
            List<decimal> costes = new List<decimal>();
            List<string> nombres = new List<string>();
            List<int> ids = new List<int>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["prod"].Value != null)
                {
                    nombres.Add((string)row.Cells["prod"].Value);
                }

                if (row.Cells["cant"].Value != null && int.TryParse(row.Cells["cant"].Value.ToString(), out int cantidad))
                {
                    cantidades.Add(cantidad);
                }
                if (row.Cells["price"].Value != null)
                {
                    costes.Add((decimal)row.Cells["price"].Value);
                }

            }

            foreach (string nombreBuscado in nombres)
            {
                int idProducto = -1; // Valor por defecto si no se encuentra el nombre

                for (int i = 0; i < nombres.Count; i++)
                {
                    if (nombres[i].ToString() == nombreBuscado)
                    {
                        idProducto = Convert.ToInt32(datos[i]["id_prod"]);

                        break;
                    }

                }
                ids.Add(idProducto);

            }


            foreach (int id in ids)
            {
                Console.Write("{0,-15}", "ID:" + id);


                string servidor = "localhost";
                string bd = "sarita";
                string usuario = "root";
                string password = "rootsql";
                string puerto = "3306";

                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario
                   + ";" + "password=" + password + ";" + "database=" + bd + ";";

                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    try
                    {
                        connection.Open();

                        // Guardar en la tabla "Pedido"
                        string queryPedido = "INSERT INTO pedido (id_ped,total,fecha_pedido ) VALUES (@idPed,@total, @fechaPedido)";
                        MySqlCommand commandPedido = new MySqlCommand(queryPedido, connection);
                        commandPedido.Parameters.AddWithValue("@total", total);
                        commandPedido.Parameters.AddWithValue("@fechaPedido", fecha_pedido);
                        commandPedido.Parameters.AddWithValue("@idPed", id_ped);
                        commandPedido.ExecuteNonQuery();

                        // Obtener el último ID insertado en la tabla "Pedido"
                        long pedidoId = commandPedido.LastInsertedId;


                        // Guardar en la tabla "cantidad_pedido"
                        string queryCantidadPedido = "INSERT INTO cantidad_pedido (pedido_cp,producto_cp,cantidad,coste) VALUES (@pedidoCP,@productoCP,@cantidad,@coste)";
                        MySqlCommand commandCantidadPedido = new MySqlCommand(queryCantidadPedido, connection);

                        for (int i = 0; i < cantidades.Count; i++)
                        {
                            commandCantidadPedido.Parameters.Clear();
                            commandCantidadPedido.Parameters.AddWithValue("@pedidoCP", pedidoId);
                            commandCantidadPedido.Parameters.AddWithValue("@productoCP", ids[i]);
                            commandCantidadPedido.Parameters.AddWithValue("@cantidad", cantidades[i]);
                            commandCantidadPedido.Parameters.AddWithValue("@coste", costes[i]);
                            commandCantidadPedido.ExecuteNonQuery();
                        }

                        MessageBox.Show("Pedido ingresado exitosamente");
                    }
                    catch (Exception ex)
                    {
                      MessageBox.Show("Error al ingresar pedido");
                    }
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void CargarProductos()
        {
            string servidor = "localhost";
            string bd = "sarita";
            string usuario = "root";
            string password = "1234";
            string puerto = "3306";

            string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario
               + ";" + "password=" + password + ";" + "database=" + bd + ";";

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                string consulta = "SELECT nom_prod , cantidad FROM producto"; // Reemplaza 'Nombre', 'Cantidad' y 'Producto' con tus nombres reales

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    conexion.Open();
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        string nombreProducto = reader["nom_prod"].ToString();
                        int cantidadProducto = Convert.ToInt32(reader["cantidad"]);

                       // comboBox1.Items.Add(nombreProducto); // Agregar el nombre del producto al ComboBox
                        comboBox1.Tag = cantidadProducto; // Guardar la cantidad en la propiedad Tag del ComboBox
                    }

                    reader.Close();
                }
            }
        }
        private void ad_ped_Load(object sender, EventArgs e)
        {
            CargarProductos();
            string servidor = "localhost";
           string bd = "sarita";
           string usuario = "root";
           string password = "1234";
           string puerto = "3306";

           string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario
              + ";" + "password=" + password + ";" + "database=" + bd + ";";

            string query = "SELECT MAX(id_ped) FROM pedido";

            using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);
                int maxId = (int)command.ExecuteScalar();

                // Actualiza el rango del control NumericupDown
                numericUpDown1.Minimum = maxId + 1;
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantidadProducto = (int)comboBox1.Tag; // Obtener la cantidad del producto desde la propiedad Tag del ComboBox

            numericUpDown2.Maximum = cantidadProducto; // Establecer el valor máximo del NumericUpDown

            // Si el valor actual del NumericUpDown es mayor que la nueva cantidad, ajustar el valor
            if (numericUpDown2.Value > cantidadProducto)
            {
                numericUpDown2.Value = cantidadProducto;
            }
        }
    }
}
    
    


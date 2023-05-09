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
        public ad_ped()
        {
            InitializeComponent();
            Clases.CPedido combobox = new Clases.CPedido();
            combobox.ComboBoxPedidos(comboBox1);
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

            string valorSeleccionado = comboBox1.SelectedItem.ToString();
            int numeroSeleccionado = (int)numericUpDown2.Value;

            dataGridView1.Rows.Add(valorSeleccionado, numeroSeleccionado, costo);

            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDecimal(row.Cells["price"].Value);
            }

            // Mostrar el resultado en el TextBox
            textBox1.Text = total.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string total = textBox1.Text;
            int id = (int)numericUpDown2.Value;

            // Obtener los datos del DataGridView
            List<string> productos = new List<string>();
            List<int> cantidades = new List<int>();
            List<decimal> costes = new List<decimal>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                productos.Add(row.Cells["prod"].Value.ToString());
                cantidades.Add((int)row.Cells["cant"].Value);
                costes.Add((decimal)row.Cells["price"].Value);
            }

            string servidor = "localhost";
            string bd = "sarita";
            string usuario = "root";
            string password = "1234";
            string puerto = "3306";

            string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario
               + ";" + "password=" + password + ";" + "database=" + bd + ";";

            using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    // Guardar en la tabla "Pedido"
                    string queryPedido = "INSERT INTO pedido (id_ped,total, fecha_pedido) VALUES (@idPed,@total, @fechaPedido)";
                    MySqlCommand commandPedido = new MySqlCommand(queryPedido, connection);
                    commandPedido.Parameters.AddWithValue("@total", total);
                    commandPedido.Parameters.AddWithValue("@fechaPedido", fecha_cad);
                    commandPedido.Parameters.AddWithValue("@idPed", numericUpDown1);
                    commandPedido.ExecuteNonQuery();

                    // Obtener el último ID insertado en la tabla "Pedido"
                    long pedidoId = commandPedido.LastInsertedId;

                    // Guardar en la tabla "cantidad_pedido"
                    string queryCantidadPedido = "INSERT INTO cantidad_pedido (cantidad, coste, pedido_cp) VALUES (@cantidad, @coste, @pedidocp)";
                    MySqlCommand commandCantidadPedido = new MySqlCommand(queryCantidadPedido, connection);

                    for (int i = 0; i < cantidades.Count; i++)
                    {
                        commandCantidadPedido.Parameters.Clear();
                        commandCantidadPedido.Parameters.AddWithValue("@cantidad", cantidades[i]);
                        commandCantidadPedido.Parameters.AddWithValue("@coste", costes[i]);
                        commandCantidadPedido.Parameters.AddWithValue("@pedidoCP", pedidoId);
                        commandCantidadPedido.ExecuteNonQuery();
                    }

                    MessageBox.Show("Jalo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Jalo");
                }
            }
        }


        }
    }
}

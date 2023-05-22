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
    class CProducto
    {
        public void mostrarProductos(DataGridView tabla_Prod)
        {
            try
            {
                Conexion conn = new Conexion();// Objeto de conexión a la base de datos
                tabla_Prod.DataSource = null;//Se incializa la funte de los datos en null
                String consulta = "select * from producto";
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conn.conectar());//Se hace la consulta a la base de datos
                DataTable dt = new DataTable(); // Objeto de tipo tabla de datos donde se mostrara el contenido de la consulta
                adapter.Fill(dt);
                tabla_Prod.DataSource = dt;
                conn.desconectar();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());

            }

        }

        public void agregarProductos(TextBox nombre, TextBox precio, DateTimePicker fecha_cad, NumericUpDown cantidad)
        {
            try
            {

                Conexion conn = new Conexion();// Objeto de conexión a la base de datos

                //Guardar la consulta para hacer el insert
                String consulta = "insert into producto(nom_prod,pre_prod,fecha_cad,cantidad) values" +
                    "('" + nombre.Text + "'," + precio.Text + ",'" + fecha_cad.Text + "'," + ((int)cantidad.Value) + ");";

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
        public void seleccionarProductos(DataGridView tabla, TextBox nombre, TextBox precio,
            DateTimePicker fecha_cad, NumericUpDown cantidad, TextBox id)
        {
            try
            {

                nombre.Text = tabla.CurrentRow.Cells[1].Value.ToString();
                precio.Text = tabla.CurrentRow.Cells[2].Value.ToString();
                fecha_cad.Text = tabla.CurrentRow.Cells[3].Value.ToString();
                cantidad.Value = (int)(tabla.CurrentRow.Cells[4].Value);
                id.Text = tabla.CurrentRow.Cells[0].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lograron seleccionar los datos, error: " + ex.ToString());
            }
        }
        public void modificarProductos(TextBox nombre, TextBox precio, DateTimePicker fecha_cad,
            NumericUpDown cantidad, TextBox id)
        {
            try
            {
                Conexion conn = new Conexion();// Objeto de conexión a la base de datos

                //Guardar la consulta para hacer el insert
                String consulta = "update producto set nom_prod='" + nombre.Text + "',pre_prod=" + precio.Text +
                    ",fecha_cad='" + fecha_cad.Text + "',cantidad=" + ((int)cantidad.Value) +
                    " where id_prod=" + id.Text + ";";

                MySqlCommand comando = new MySqlCommand(consulta, conn.conectar());

                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Producto modificado Correctamente");

                /*
                while (reader.Read()) { 
                
                }*/

                conn.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro modificar los datos, error: " + ex.ToString());
            }
        }
        public void eliminarProductos(TextBox nombre)
        {
            try
            {
                Conexion conn = new Conexion();// Objeto de conexión a la base de datos

                //Guardar la consulta para hacer el insert
                String consulta = "delete from producto where id_prod='" + nombre.Text + "';";

                MySqlCommand comando = new MySqlCommand(consulta, conn.conectar());

                MySqlDataReader reader = comando.ExecuteReader();

                MessageBox.Show("Producto eliminado correctamente");

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
    }
}

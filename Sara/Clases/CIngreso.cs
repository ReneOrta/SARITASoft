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
    class CIngreso
    {
        public void mostrarIngresos(DataGridView tabla_Ing)
        {
            try
            {
                Conexion conn = new Conexion();// Objeto de conexión a la base de datos
                tabla_Ing.DataSource = null;//Se incializa la funte de los datos en null
                String consulta = "select * from ingresos_pedido";
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conn.conectar());//Se hace la consulta a la base de datos
                DataTable dt = new DataTable(); // Objeto de tipo tabla de datos donde se mostrara el contenido de la consulta
                adapter.Fill(dt);
                tabla_Ing.DataSource = dt;
                conn.desconectar();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());

            }

        }

        public void mostrarIngresosAnio(DataGridView tabla_Ing, TextBox anio)
        {
            try
            {
                Conexion conn = new Conexion();// Objeto de conexión a la base de datos
                tabla_Ing.DataSource = null;//Se incializa la funte de los datos en null
                String consulta = "select ingresos_pedido.id_ip as Id, ingresos_pedido.saldo, ingresos.fecha_consulta as Fecha " +
                    "from ingresos inner join ingresos_pedido on ingresos.id_ing = ingresos_pedido.ingresos_ip where year (ingresos.fecha_consulta) = " + anio.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conn.conectar());//Se hace la consulta a la base de datos
                DataTable dt = new DataTable(); // Objeto de tipo tabla de datos donde se mostrara el contenido de la consulta
                adapter.Fill(dt);
                tabla_Ing.DataSource = dt;
                conn.desconectar();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());

            }

        }

        public void mostrarIngresosMes(DataGridView tabla_Ing, String mes)
        {
            try
            {
                Conexion conn = new Conexion();// Objeto de conexión a la base de datos
                tabla_Ing.DataSource = null;//Se incializa la funte de los datos en null
                String consulta = "select ingresos_pedido.id_ip as Id, ingresos_pedido.saldo, ingresos.fecha_consulta as Fecha " +
                    "from ingresos inner join ingresos_pedido on ingresos.id_ing = ingresos_pedido.ingresos_ip where month (ingresos.fecha_consulta) = " + mes;
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conn.conectar());//Se hace la consulta a la base de datos
                DataTable dt = new DataTable(); // Objeto de tipo tabla de datos donde se mostrara el contenido de la consulta
                adapter.Fill(dt);
                tabla_Ing.DataSource = dt;
                conn.desconectar();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());

            }
        }

        public void mostrarIngresosDia(DataGridView tabla_Ing, TextBox anio, String mes, String dia)
        {
            try
            {
                Conexion conn = new Conexion();// Objeto de conexión a la base de datos
                tabla_Ing.DataSource = null;//Se incializa la funte de los datos en null
                String consulta = "select ingresos_pedido.id_ip as Id, ingresos_pedido.saldo, ingresos.fecha_consulta as Fecha " +
                    "from ingresos inner join ingresos_pedido on ingresos.id_ing = ingresos_pedido.ingresos_ip where ingresos.fecha_consulta = " + anio.Text + "-" + mes + "-" + dia;
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conn.conectar());//Se hace la consulta a la base de datos
                DataTable dt = new DataTable(); // Objeto de tipo tabla de datos donde se mostrara el contenido de la consulta
                adapter.Fill(dt);
                tabla_Ing.DataSource = dt;
                conn.desconectar();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());

            }

        }
    }
}

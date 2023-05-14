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
    public partial class JefeGenerarReporte : Form
    {
        public JefeGenerarReporte()
        {
            InitializeComponent();
        }
        private void grButton_Click(object sender, EventArgs e)
        {
            Clases.CProducto producto = new Clases.CProducto();
            producto.mostrarProductos(dataGridView1);
        }

        private void grButton_Click_1(object sender, EventArgs e)
        {
            Clases.CProducto producto = new Clases.CProducto();
            producto.mostrarProductos(dataGridView1);
        }
    }
}

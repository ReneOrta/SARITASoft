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
    public partial class reporte_productos : Form
    {
        public reporte_productos()
        {
            InitializeComponent();
            Clases.CProducto prod = new Clases.CProducto();
            prod.mostrarProductos(dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ad_producto : Form
    {
        public ad_producto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.CProducto producto = new Clases.CProducto();
            producto.agregarProductos(nom_text, precio_text, fecha_cad, cantidad);
            nom_text.ResetText();
            precio_text.ResetText();
            fecha_cad.ResetText();
            cantidad.ResetText();
        }
    }
}

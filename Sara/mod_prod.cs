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
    public partial class mod_prod : Form
    {
        public mod_prod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.CProducto producto = new Clases.CProducto();
            producto.modificarProductos(nom_text, precio_text, fecha_cad, cantidad, id_text);
            id_text.ResetText();
            nom_text.ResetText();
            precio_text.ResetText();
            fecha_cad.ResetText();
            cantidad.ResetText();
        }
    }
}

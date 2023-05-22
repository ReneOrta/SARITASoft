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
    public partial class del_producto : Form
    {
        public del_producto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(name_text.Text) )
            {
                Clases.CProducto prod = new Clases.CProducto();
                prod.eliminarProductos(name_text);
            }

        }

        private void name_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private void name_text_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_text.Text))
            {
                button1.Enabled = false; // Deshabilitar el botón si el TextBox está vacío
            }
            else
            {
                button1.Enabled = true; // Habilitar el botón si el TextBox contiene texto
            }
        }
    }
}

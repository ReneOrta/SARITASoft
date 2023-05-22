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
            if (!string.IsNullOrWhiteSpace(nom_text.Text) && !string.IsNullOrWhiteSpace(precio_text.Text))
            {
                // Realizar la acción deseada solo si ambos TextBox tienen contenido
                // ...
            
            Clases.CProducto producto = new Clases.CProducto();
            producto.agregarProductos(nom_text, precio_text, fecha_cad, cantidad);
            nom_text.ResetText();
            precio_text.ResetText();
            fecha_cad.ResetText();
            cantidad.ResetText();
            }
        }

        private void nom_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private void precio_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private void nom_text_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nom_text.Text))
            {
                button1.Enabled = false; // Deshabilitar el botón si el TextBox está vacío
            }
            else
            {
                button1.Enabled = true; // Habilitar el botón si el TextBox contiene texto
            }
        }

        private void precio_text_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(precio_text.Text))
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

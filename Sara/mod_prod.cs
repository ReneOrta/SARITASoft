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
            if (!string.IsNullOrWhiteSpace(id_text.Text) && !string.IsNullOrWhiteSpace(nom_text.Text) && !string.IsNullOrWhiteSpace(precio_text.Text))
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

        private void id_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private void id_text_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_text.Text))
            {
                button1.Enabled = false; // Deshabilitar el botón si el TextBox está vacío
            }
            else
            {
                button1.Enabled = true; // Habilitar el botón si el TextBox contiene texto
            }
        }

        private void nom_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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

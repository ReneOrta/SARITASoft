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
    public partial class RIxAnio : Form
    {
        public RIxAnio()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Clases.CIngreso ingresos = new Clases.CIngreso();
            ingresos.mostrarIngresosAnio(dataGridView1, tbAnio);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clases.CIngreso ingresos = new Clases.CIngreso();
            ingresos.mostrarIngresosAnio(dataGridView1, tbAnio);
        }

        private void tbAnio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}

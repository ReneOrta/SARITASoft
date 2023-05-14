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
    public partial class RIxDia : Form
    {
        public RIxDia()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            object d = cbDia.SelectedItem;
            String dia = cbDia.GetItemText(d);
            object m = cbMes.SelectedItem;
            String mes = cbMes.GetItemText(m);
            Clases.CIngreso ingresos = new Clases.CIngreso();
            ingresos.mostrarIngresosDia(dataGridView1, tbAnio, mes, dia);
        }
        private void tbAnio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            object d = cbDia.SelectedItem;
            String dia = cbDia.GetItemText(d);
            object m = cbMes.SelectedItem;
            String mes = cbMes.GetItemText(m);
            Clases.CIngreso ingresos = new Clases.CIngreso();
            ingresos.mostrarIngresosDia(dataGridView1, tbAnio, mes, dia);
        }
    }
}

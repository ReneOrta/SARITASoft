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
    public partial class ad_ped : Form
    {
        public ad_ped()
        {
            InitializeComponent();
            Clases.CPedido combobox = new Clases.CPedido();
            combobox.ComboBoxPedidos(comboBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valorSeleccionado = comboBox1.SelectedItem.ToString();
            int numeroSeleccionado = (int)numericUpDown2.Value;

            dataGridView1.Rows.Add(valorSeleccionado, numeroSeleccionado);
        }

    }
}

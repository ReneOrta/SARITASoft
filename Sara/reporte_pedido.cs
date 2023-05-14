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
    public partial class reporte_pedido : Form
    {
        public reporte_pedido()
        {
            InitializeComponent();
            Clases.CPedido ped = new Clases.CPedido();
            ped.mostrarPedidos(dataGridView1);
        }
    }
}

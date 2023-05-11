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
    public partial class JefeGenerarReporteIngresos : Form
    {
        public JefeGenerarReporteIngresos()
        {
            InitializeComponent();
        }
        public void AbrirFormInPanel(object FormHijo)
        {
            if (this.panelContenedorRepIngre.Controls.Count > 0)
                this.panelContenedorRepIngre.Controls.RemoveAt(0);

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorRepIngre.Controls.Add(fh);
            this.panelContenedorRepIngre.Tag = fh;
            fh.Show();
        }

        private void buttonDia_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RIxDia());
        }

        private void buttonMes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RIxMes());
        }

        private void buttonAnio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RIxAnio());
        }
    }
}

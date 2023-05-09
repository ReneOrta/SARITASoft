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
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
            AbrirFormInPanel_Vista(new ad_ped());
        }

        private void AbrirFormInPanel_Vista(object FormHijo)
        {
            if (this.panel_vista.Controls.Count > 0)
                this.panel_vista.Controls.RemoveAt(0);

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_vista.Controls.Add(fh);
            this.panel_vista.Tag = fh;
            fh.Show();
        }

        private void ad_button_CheckedChanged(object sender, EventArgs e)
        {
            AbrirFormInPanel_Vista(new ad_ped());
        }

        private void mod_button_CheckedChanged(object sender, EventArgs e)
        {
            AbrirFormInPanel_Vista(new del_ped());
        }
    }
}

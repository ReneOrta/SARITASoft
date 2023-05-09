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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            AbrirFormInPanel3(new AdminInicio());
        }

        private void AbrirFormInPanel3(object FormHijo)
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


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel3(new AdminInicio());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel3(new AdminInicio());
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel3(new producto());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel3(new producto());
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel3(new Pedido());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel3(new Pedido());
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Peru;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Peru;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.SaddleBrown;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.SaddleBrown;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Peru;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.SaddleBrown;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Peru;
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.SaddleBrown;
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Peru;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.SaddleBrown;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Peru;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.SaddleBrown;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

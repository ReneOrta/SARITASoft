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
    public partial class Jefe : Form
    {
        public Jefe()
        {
            InitializeComponent();
            AbrirFormInPanel(new JefeInicio());
        }

        private void Jefe_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new JefeInicio());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new JefeInicio());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new JefeInicio());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new JefeGenerarReporte());
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new JefeGenerarReporteIngresos());
        }

        public void AbrirFormInPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new JefeGenerarReporte());
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Gray;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Gray;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Gray;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Tomato;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Tomato;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Tomato;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new JefeGenerarReporteIngresos());
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Gray;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Tomato;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Gray;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Tomato;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Gray;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Tomato;
        }

        private void panelBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new JefeGenerarReporte());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new JefeInicio());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new JefeGenerarReporteIngresos());
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new JefeGenerarReporte());
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new JefeGenerarReporte());
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new JefeInicio());
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new JefeGenerarReporteIngresos());
        }
    }
}

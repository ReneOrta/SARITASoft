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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            if (Usuario.Text == "Admin" && textBox1.Text == "1234")
            {
                Administrador admin = new Administrador();
                admin.Show();
            }
            else if (Usuario.Text == "Jefe" && textBox1.Text == "ABCD")
            {
                /*Jefe jefe = new Jefe();
                jefe.Show();*/
            }
            else
            {
                MessageBox.Show("Error de logeo");
            }
        }
    }
}

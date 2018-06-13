using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion
{
    public partial class fmrLogin : Form
    {
        public fmrLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Eliminar las siguientes dos lineas para validar el login
            //--¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡
            txtUsuario.Text = "Edgardo";
            txtClave.Text = "1234";

            string usuario = "Edgardo";
            string clave = "1234";


            if (txtUsuario.Text != usuario)
            {
                errorProvider1.SetError(txtUsuario, "El usuario ingresado no existe");
                errorProvider1.GetError(txtUsuario);
            }
            else if (txtClave.Text != clave)
            {
                errorProvider1.SetError(txtClave, "El Clave ingresado es incorrecta");
                errorProvider1.GetError(txtClave);
            }
            else
            {
                frmMenu frm1 = new frmMenu();
                this.Hide();
                frm1.ShowDialog();
            }
        }

        private void fmrLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

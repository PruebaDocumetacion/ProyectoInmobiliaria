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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Eliminar las siguientes dos lineas para validar el login
            //--¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡
          //  txtUsuario.Text = "Edgardo";
          ///  txtClave.Text = "1234";

            string usuario = "Edgardo";
            string clave = "1234";


            if (txtUsuario.Text != usuario)
            {
                errorProvider1.SetError(txtUsuario, "El usuario ingresado no existe");
                errorProvider1.GetError(txtUsuario);
                txtUsuario.Focus();
            }
            else if (txtClave.Text != clave)
            {
                errorProvider1.SetError(txtClave, "El Clave ingresado es incorrecta");
                errorProvider1.GetError(txtClave);
                txtClave.Focus();
            }
            else
            {
                frmMenu menu = new frmMenu();
                this.Hide();
                menu.ShowDialog();
                this.Show();
                InitLogin();
            }
        }

        private void fmrLogin_Load(object sender, EventArgs e)
        {
            InitLogin();
        }

        private void InitLogin()
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtUsuario.Focus();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Conexion.Empleado
{
    public partial class frmAgregarEmpleado : Form
    {
        public frmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.cerrarconexion();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                try
                {
                    //Conexion conectar = new Conexion();
                    //conectar.abrirconexion();

                    Empleados pEmpleado = new Empleados();
                    pEmpleado.Id = txtId.Text.Trim();
                    pEmpleado.Nombre = txtNombre.Text.Trim();
                    pEmpleado.Telefono = txtTelefono.Text.Trim();
                    pEmpleado.Correo = txtCorreo.Text.Trim();
                    pEmpleado.Direccion = txtDireccion.Text.Trim();
                    pEmpleado.Agregar();
                    //int resultado = operaEmpleados.agregarempleado(conectar.con, pEmpleado);
                    //if (resultado > 0)
                    //{
                    MessageBox.Show("Empleado Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                txtId.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();
                txtDireccion.Clear();
            }
        }
        private bool ValidarCamposVacios()
        {
            bool valido = false;
            if (txtId.Text.Length != 15)
            {
                MessageBox.Show("La identidad del cliente esta incompleta");
            }
            else
            {
                if (txtNombre.Text.Trim() == "")
                {
                    MessageBox.Show("ingrese el nombre del cliente");
                }
                else
                {
                    if (txtTelefono.Text.Trim() == "")
                    {
                        MessageBox.Show("Ingrese el telefono del cliente");
                    }
                    else
                    {
                            if (txtDireccion.Text.Trim() == "")
                            {
                                MessageBox.Show("Ingrese la direccion del cliente");
                            }
                            else
                            {
                                valido = true;
                            }

                        }
                    }
                }
            

            return valido;

        }




        private void btnRefre_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgEmpleado.DataSource = operaEmpleados.Buscar(conectar.con);
        }

        private void frmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgEmpleado.DataSource = operaEmpleados.Buscar(conectar.con);
        }

        private void txtId_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

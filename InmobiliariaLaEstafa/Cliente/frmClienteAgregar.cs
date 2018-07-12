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

namespace Conexion
{
    public partial class frmClienteAgregar : Form
    {

        public frmClienteAgregar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.cerrarconexion();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                try
                {
                    Clientes Cliente = new Clientes(
                    txtId.Text.Trim(),
                    txtNombre.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtCorreo.Text.Trim(),
                    txtOficio.Text.Trim(),
                    txtDireccion.Text.Trim()
                    );
                    Cliente.Agregar();
                    MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("No se pudo guardar el cliente " + ex.ToString(), "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                LimpiarFormulario();
                CargarDGVClientes();
            }

            
        }

        public void LimpiarFormulario()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtOficio.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgCliente.DataSource = Clientes.listarTodos();
        }

        private void CargarDGVClientes()
        {
            dgCliente.DataSource = Clientes.listarTodos();
        }

        private void frmClienteAgregar_Load(object sender, EventArgs e)
        {
            CargarDGVClientes();
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
                        if (txtOficio.Text.Trim() == "")
                        {
                            MessageBox.Show("Ingrese el oficio del cliente");
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
            }

            return valido;

        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)||char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)|| char.IsControl(e.KeyChar)|| char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
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
    }
}

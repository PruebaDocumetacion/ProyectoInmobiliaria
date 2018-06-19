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

namespace Conexion.Cliente
{
    public partial class frmClienteModificar : Form
    {
        public frmClienteModificar()
        {
            InitializeComponent();
        }

        private void frmClienteModificar_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgModificarCliente.DataSource = operaClientes.Buscar(conectar.con);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.cerrarconexion();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            
                string id = Convert.ToString(txtId.Text);
                ClienteSelecionado = operaClientes.Buscarparametro1(id, conectar.con);

            if (ClienteSelecionado.IdC != null)
            {
                txtNombre.Text = ClienteSelecionado.NombreC;
                txtTelefono.Text = ClienteSelecionado.Telefono;
                txtCorreo.Text = ClienteSelecionado.Correo;
                txtOficio.Text = ClienteSelecionado.Oficio;
                txtDireccion.Text = ClienteSelecionado.DireccionC;
                ClienteActual = ClienteSelecionado;
                txtId.Enabled = false;
                conectar.cerrarconexion();
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                txtId.Enabled = true;
                MessageBox.Show("El cliente no existe");
            }
           
        }
        public Clientes ClienteActual { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();

            Clientes pCliente = new Clientes();
            pCliente.IdC = ClienteActual.IdC;
            pCliente.NombreC = txtNombre.Text.Trim();
            pCliente.Telefono = txtTelefono.Text.Trim();
            pCliente.Correo = txtCorreo.Text.Trim();
            pCliente.Oficio = txtOficio.Text.Trim();
            pCliente.DireccionC = txtDireccion.Text.Trim();

            int resultado = operaClientes.modificarcliente(conectar.con, pCliente);
            if (resultado > 0)
            {
                MessageBox.Show("Cliente Actualizado Con Exito!!", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conectar.cerrarconexion();

            txtId.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtOficio.Clear();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        public Clientes ClienteSelecionado { get; set; }
        private void button4_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgModificarCliente.DataSource = operaClientes.Buscar(conectar.con);
            txtId.Enabled = true;
            txtId.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtOficio.Clear();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();

            Clientes pCliente1 = new Clientes();
                pCliente1.IdC = ClienteActual.IdC;

            
            if (MessageBox.Show("Esta Seguro que desea eliminar el Cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtId.Enabled = true;
                
                int resultado3 = operaClientes.eliminarcliente(conectar.con, pCliente1);
                if (resultado3 > 0)
                {
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Cliente", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            txtId.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtOficio.Clear();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            dgModificarCliente.DataSource = operaClientes.Buscar(conectar.con);
            conectar.cerrarconexion();  
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            dgModificarCliente.DataSource = null;
        }
    }
}

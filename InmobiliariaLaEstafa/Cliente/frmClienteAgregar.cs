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
            Conexion conectar = new Conexion();
            conectar.abrirconexion();

            Clientes pCliente = new Clientes();
            pCliente.Id = txtId.Text.Trim();
            pCliente.Nombre = txtNombre.Text.Trim();
            pCliente.Telefono = txtTelefono.Text.Trim();
            pCliente.Correo = txtCorreo.Text.Trim();
            pCliente.Oficio = txtOficio.Text.Trim();
            pCliente.Direccion = txtDireccion.Text.Trim();

            int resultado = operaClientes.agregarcliente(conectar.con, pCliente);
            if (resultado > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conectar.cerrarconexion();

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
            dgCliente.DataSource = operaClientes.Buscar(conectar.con);
        }

        private void frmClienteAgregar_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgCliente.DataSource = operaClientes.Buscar(conectar.con);
        }
    }
}

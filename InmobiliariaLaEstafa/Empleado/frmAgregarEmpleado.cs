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
            Conexion conectar = new Conexion();
            conectar.abrirconexion();

            Empleados pEmpleado = new Empleados();
            pEmpleado.Id = txtId.Text.Trim();
            pEmpleado.Nombre = txtNombre.Text.Trim();
            pEmpleado.Telefono = txtTelefono.Text.Trim();
            pEmpleado.Correo = txtCorreo.Text.Trim();
            pEmpleado.Direccion = txtDireccion.Text.Trim();

            int resultado = operaEmpleados.agregarempleado(conectar.con, pEmpleado);
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
    }
}

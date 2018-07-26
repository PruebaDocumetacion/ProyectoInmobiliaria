using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion.Empleado
{
    public partial class frmActualizarEmpleado : Form
    {
        public frmActualizarEmpleado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();

            Empleados pEmpleado = new Empleados();
            pEmpleado.Id = EmpleadoActual.Id;
            pEmpleado.Nombre = txtNombre.Text.Trim();
            pEmpleado.Telefono = txtTelefono.Text.Trim();
            pEmpleado.Correo = txtCorreo.Text.Trim();

            pEmpleado.Direccion = txtDireccion.Text.Trim();

            int resultado = operaEmpleados.modificarempleado(conectar.con, pEmpleado);
            if (resultado > 0)
            {
                MessageBox.Show("Empleado Actualizado Con Exito!!", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        public Empleados EmpleadoActual { get; set; }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtId.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();

        }
        public Empleados Empleadoelecionado{get;set;}
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();

            string id = Convert.ToString(txtId.Text);
            Empleadoelecionado = operaEmpleados.Buscarparametro1(id, conectar.con);

            if (Empleadoelecionado != null)
            {
                txtNombre.Text = Empleadoelecionado.Nombre;
                txtTelefono.Text = Empleadoelecionado.Telefono;
                txtCorreo.Text = Empleadoelecionado.Correo;
             
                txtDireccion.Text = Empleadoelecionado.Direccion;
                EmpleadoActual = Empleadoelecionado;
            }
            txtId.Enabled = false;
            conectar.cerrarconexion();
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();

            Empleados pEmpleado1 = new Empleados();
            pEmpleado1.Id = EmpleadoActual.Id;


            if (MessageBox.Show("Esta Seguro que desea eliminar el Cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtId.Enabled = true;

                int resultado3 = operaEmpleados.eliminarempleado(conectar.con, pEmpleado1);
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
           
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            dgActualizarEmpleado.DataSource = operaEmpleados.Buscar(conectar.con);
            conectar.cerrarconexion();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            dgActualizarEmpleado.DataSource = null;
        }

        private void frmActualizarEmpleado_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgActualizarEmpleado.DataSource = operaEmpleados.Buscar(conectar.con);
        }

        private void txtId_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
 }


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
    public partial class frmBuscarEmpleado : Form
    {
        public frmBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgBuscarEmpleado.DataSource = operaEmpleados.Buscarparametro(txtId.Text, txtNombre.Text, conectar.con);
        }

        private void frmBuscarEmpleado_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgBuscarEmpleado.DataSource = operaEmpleados.Buscar(conectar.con);
        }

       
private void button1_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgBuscarEmpleado.DataSource = operaEmpleados.Buscar(conectar.con);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            dgBuscarEmpleado.DataSource = null;
        }
    }
}

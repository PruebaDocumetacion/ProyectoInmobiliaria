using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion.Cliente
{
    public partial class frmClientesBuscar : Form
    {
        public frmClientesBuscar()
        {
            InitializeComponent();
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
            dgBuscarCliente.DataSource = operaClientes.Buscarparametro(txtId.Text,txtNombre.Text, conectar.con);
        }

        private void frmClientesBuscar_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgBuscarCliente.DataSource = operaClientes.Buscar(conectar.con);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            dgBuscarCliente.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgBuscarCliente.DataSource = operaClientes.Buscar(conectar.con);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion.Venta
{
    public partial class frmVentasBuscar : Form
    {
        public frmVentasBuscar()
        {
            InitializeComponent();
        }

        private void frmVentasBuscar_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgActualizarInmueble.DataSource = operaVenta.BuscarContrato1(conectar.con);
            conectar.cerrarconexion();
            txtId.Focus();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgActualizarInmueble.DataSource = operaVenta.BuscarContrato(txtId.Text, conectar.con);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtId.Focus();
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgActualizarInmueble.DataSource = operaVenta.BuscarContrato1(conectar.con);
            conectar.cerrarconexion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion cone = new Conexion();
            cone.cerrarconexion();
            this.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

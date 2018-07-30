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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void proveedorestoolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente.frmClienteModificar frm1 = new Cliente.frmClienteModificar();
            frm1.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteAgregar frm1 = new frmClienteAgregar();
            frm1.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cliente.frmClientesBuscar frm1 = new Cliente.frmClientesBuscar();
            frm1.Show();
        }

        private void toolStripDropDownButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Empleado.frmAgregarEmpleado frm1 = new Empleado.frmAgregarEmpleado();
            frm1.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Empleado.frmActualizarEmpleado frm1 = new Empleado.frmActualizarEmpleado();
            frm1.Show();
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            Empleado.frmBuscarEmpleado frm1 = new Empleado.frmBuscarEmpleado();
            frm1.Show();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inmueble.frmInmuebleAgregar frm1 = new Inmueble.frmInmuebleAgregar();
            frm1.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Inmueble.frmInmuebleActualizar frm1 = new Inmueble.frmInmuebleActualizar();
            frm1.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Inmueble.frmInmuebleBuscar frm1 = new Inmueble.frmInmuebleBuscar();
            frm1.Show();
        }

        private void nuevoContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nuevoContratoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Venta.frmVentasAgregar frm11 = new Venta.frmVentasAgregar();
            frm11.Show();
        }

        private void pagoMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagos.frmPagoAgregar frm1 = new Pagos.frmPagoAgregar();
            frm1.Show();
        }

        private void buscarContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta.frmVentasBuscar frm1 = new Venta.frmVentasBuscar();
            frm1.Show();
        }

        private void buscarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagos.frmPagoBuscar frm1 = new Pagos.frmPagoBuscar();
            frm1.Show();
        }

        private void clientestoolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            Inmueble.frmInmuebleBuscar frm = new Inmueble.frmInmuebleBuscar();
            frm.Show();
        }
    }
}

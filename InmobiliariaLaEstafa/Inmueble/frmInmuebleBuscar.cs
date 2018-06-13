using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion.Inmueble
{
    public partial class frmInmuebleBuscar : Form
    {
        public frmInmuebleBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgActualizarInmueble.DataSource = operaInmueble.Buscarparametro(txtId.Text, cbDireccion.Text,cbTipo.Text, conectar.con);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            dgActualizarInmueble.DataSource = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            cbDireccion.Text="";
            cbTipo.Text = "";
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgActualizarInmueble.DataSource = operaInmueble.Buscar(conectar.con);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.cerrarconexion();
            this.Close();
        }

        private void frmInmuebleBuscar_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgActualizarInmueble.DataSource = operaInmueble.Buscar(conectar.con);
        }
    }
}

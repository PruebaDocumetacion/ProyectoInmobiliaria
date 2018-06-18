using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion.Pagos
{
    public partial class frmPagoAgregar : Form
    {
        public frmPagoAgregar()
        {
            InitializeComponent();
        }
        public Ventas PagoActual { get; set; }
        public Ventas Pagoselecionado { get; set; }
        

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            string id2 = Convert.ToString(txtId.Text);
           
            Pagoselecionado = operaPagos.BuscarContrato(id2, conectar.con);

            if (Pagoselecionado.Id != null)
            {
             //   txtDescripcion.Text = Pagoselecionado.Descripcion;
                //txtPrecio.Text = Convert.ToString(Pagoselecionado.Precio);
                txtId.Enabled = false;
            }
            else
            {
                MessageBox.Show("Pago No Encontrado!!", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Clear();
            }
            conectar.cerrarconexion();
            conectar.abrirconexion();
            //string id1 = Convert.ToString(txtId.Text);
            dgPago.DataSource = operaPagos.BuscarContrato1(conectar.con);
            conectar.cerrarconexion();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }

        private void frmPagoAgregar_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            //string id1 = Convert.ToString(txtId.Text);
            dgPago.DataSource = operaPagos.BuscarContrato1(conectar.con);
            conectar.cerrarconexion();
        }
    }
}

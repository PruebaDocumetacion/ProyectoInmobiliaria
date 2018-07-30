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
    public partial class frmPagoBuscar : Form
    {
        public frmPagoBuscar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            string id2 = Convert.ToString(Id.Text);
            dgPago.DataSource = operaPagos.BuscarContratos(id2, conectar.con);
           // dgPago.DataSourceChanged();
            conectar.cerrarconexion();
        }

        private void dgPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Id_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            dgPago.DataSource = null;
        }

        private void frmPagoBuscar_Load(object sender, EventArgs e)
        {
            Id.Focus();
        }
    }
}

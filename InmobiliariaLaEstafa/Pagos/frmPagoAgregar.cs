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
        public Pago PagoActual { get; set; }
        public Pago Pagoselecionado { get; set; }
        

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void grid()
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            string id2 = Convert.ToString(txtId.Text);
            dgPago.DataSource = operaPagos.BuscarContratos(id2,conectar.con);
            conectar.cerrarconexion();
        }

        public Consulta ConsultaActual { get; set; }
        public Consulta Consultaselecionado { get; set; }

        //boton  buscar
        private void button5_Click(object sender, EventArgs e)
        {
            
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            string id2 = Convert.ToString(txtId.Text);
           
           Consultaselecionado = operaPagos.Contrato1(id2, conectar.con);
          //  MessageBox.Show("mostrar id ", Consultaselecionado.Operacion);
            if (Consultaselecionado != null)
            {

                // txtId.Text = Consultaselecionado.Operacion;
                txtNumero.Text = Convert.ToString(Consultaselecionado.numeroFac);
                txtCliente.Text = Consultaselecionado.NombreCliente;
                tDireccion.Text = Consultaselecionado.DireccionCliente;
                txtTipo.Text = Consultaselecionado.TipoInmueble;
              txtDescripcion.Text = Consultaselecionado.DescripcionInmueble;
                textBox1.Text = Convert.ToString(Consultaselecionado.CuotasPago);
               textAbono.Text = Convert.ToString(Consultaselecionado.ValorCuota);
                txtAcumullada.Text = Convert.ToString(Consultaselecionado.CuotasPagadas);
                txtPendiente.Text = Convert.ToString(Consultaselecionado.CuotasPendientes);
                txtmora.Text = Convert.ToString(Consultaselecionado.MoraPago);
                dtpFecha.Text = Convert.ToString(Consultaselecionado.FechaPago);
                this.grid();
                txtId.Enabled = false;
                txtCliente.Enabled = false;
                txtDescripcion.Enabled = false;
                txtTipo.Enabled = false;
                txtAcumullada.Enabled = false;
                txtmora.Enabled = false;
                tDireccion.Enabled = false;
                textAbono.Enabled = false;
                txtNumero.Enabled = false;
                txtPendiente.Enabled = false;
                textBox1.Enabled = false;

            }
            else
            {
                MessageBox.Show("Pago No Encontrado!!", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Clear();
                txtId.Enabled = true;
                txtCliente.Enabled = true;
                txtDescripcion.Enabled = true;
                txtTipo.Enabled = true;
                txtAcumullada.Enabled = true;
                txtmora.Enabled = true;
                tDireccion.Enabled = true;
                textAbono.Enabled = true;
                txtNumero.Enabled = true;
                txtPendiente.Enabled = true;
                textBox1.Enabled = true;
            }
            conectar.cerrarconexion();
            //conectar.abrirconexion();
            ////string id1 = Convert.ToString(txtId.Text);
            //string id3 = Convert.ToString(txtId.Text);
            //dgPago.DataSource = Pagoselecionado;
            //conectar.cerrarconexion();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ///////////////
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            Pago pInmue1 = new Pago();
            pInmue1.Factura = Convert.ToInt16(txtNumero.Text)+1;
            pInmue1.Operacion = txtId.Text.Trim();
            pInmue1.Pagado = Convert.ToDouble(Convert.ToDouble(txtAcumullada.Text) + Convert.ToDouble(textAbono.Text));
            pInmue1.Pendiente = Convert.ToDouble(Convert.ToDouble(txtPendiente.Text) - Convert.ToDouble(textAbono.Text));
            pInmue1.Mora = Convert.ToDouble(txtmora.Text);
            pInmue1.CuotasP = Convert.ToInt16(textBox1.Text) - 1;
            pInmue1.Fecha = dtpFecha.Value.Day + "/" + dtpFecha.Value.Month + "/" + dtpFecha.Value.Year;


            if (pInmue1.CuotasP != 0)
            {
                int resultado1 = operaPagos.agregarPago(conectar.con, pInmue1);


                if (resultado1 > 0)
                {
                    MessageBox.Show("se registrado el pago Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el pagos", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                conectar.cerrarconexion();
            }
            else
            {
                MessageBox.Show("El Cliente ha terminado su Deuda", "Pago Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtId.Enabled = true;
            txtId.Clear();
            txtNumero.Clear();
            txtPendiente.Clear();
            txtAcumullada.Clear();
            textBox1.Clear();
            txtCliente.Clear();
            tDireccion.Clear();
            txtTipo.Clear();
            txtDescripcion.Clear();
            textAbono.Text = "";
            txtmora.Text = "";
         
        }

        private void frmPagoAgregar_Load(object sender, EventArgs e)
        {
            /*Conexion conectar = new Conexion();
            conectar.abrirconexion();
            string id1 = Convert.ToString(txtId.Text);
            dgPago.DataSource = operaPagos.Contrato1(id1, conectar.con);
            conectar.cerrarconexion();
        */}

        private void btnCancela_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtId.Clear();
            txtNumero.Clear();
            txtPendiente.Clear();
            txtAcumullada.Clear();
            textBox1.Clear();
            txtCliente.Clear();
            tDireccion.Clear();
            txtTipo.Clear();
            txtDescripcion.Clear();
            textAbono.Text = "";
            txtmora.Text = "";
            txtId.Enabled = true;
            txtCliente.Enabled = true;
            txtDescripcion.Enabled = true;
            txtTipo.Enabled = true;
            txtAcumullada.Enabled = true;
            txtmora.Enabled = true;
            tDireccion.Enabled = true;
            textAbono.Enabled = true;
            txtNumero.Enabled = true;
            txtPendiente.Enabled = true;
            textBox1.Enabled = true;
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            dgPago.DataSource = Consultaselecionado;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCobrer_Click(object sender, EventArgs e)
        {

        }
    }
}

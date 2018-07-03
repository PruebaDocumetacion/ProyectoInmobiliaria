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
    public partial class frmVentasAgregar : Form
    {
        
        public frmVentasAgregar()
        {
            InitializeComponent();
        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            txtIdC.Clear();
            txtIdE.Clear();
            txtIdInmeble.Clear();
            txtIdContrato.Clear();
            txtCuotas.Text="1";
            txtCuotas.Visible = false;
            txtPrecio.Clear();
            txtNombreC.Clear();
            txtNombreE.Clear();
            txtDescripcion.Clear();
            txtObservacion.Text = "";
            txtPrima.Text = "";
            txtTotal.Text = "";
            dgInmueble.Text = "";
            dtpFechaCotrato.Text = "";
            txtImpuesto.Clear();
            txtImporte.Clear();
            txtDescuento.Clear();
            cbForma.Text = "";
            txtIdC.Enabled = true;
            txtNombreC.Enabled = true;
            txtNombreE.Enabled = true;
            txtIdE.Enabled = true;
            txtIdInmeble.Enabled = true;
        }

        private void txtImpuesto_TextChanged(object sender, EventArgs e)
        {

        }
        public Inmuebles InmuebleActual { get; set; }
        public Inmuebles Inmuebleselecionado { get; set; }
        public Clientes ClienteActual { get; set; }
        public Clientes ClienteSelecionado { get; set; }
        public Empleados EmpleadoActual { get; set; }
        public Empleados EmpleadoSelecionado { get; set; }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            string id = Convert.ToString(txtIdC.Text);
            ClienteSelecionado = operaVenta.BuscarparametroC(id, conectar.con);

            if (ClienteSelecionado == null)
            {
                MessageBox.Show("Cliente No Encontrado!!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdC.Clear();
                txtIdC.Enabled = true;
                txtNombreC.Enabled = true;
                txtIdC.Focus();
            }            
            else 
            {
                txtNombreC.Text = ClienteSelecionado.NombreC;
                txtIdC.Enabled = false;
                txtNombreC.Enabled = false; 
            }
            conectar.cerrarconexion();
         }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            string id = Convert.ToString(txtIdE.Text);
            EmpleadoSelecionado = operaVenta.BuscarparametroE(id, conectar.con);

            if (EmpleadoSelecionado != null)
            {
                txtNombreE.Text = EmpleadoSelecionado.Nombre;
                txtIdE.Enabled = false;
                txtNombreE.Enabled = false;
            }
            else
            {
                MessageBox.Show("Empleado No Encontrado!!", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdE.Clear();
                txtIdE.Enabled = true;
                txtNombreE.Enabled = true;
                txtIdE.Focus();
            }
            conectar.cerrarconexion();
        }

        private void btnBuscarInmueble_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            
            
            Inmuebleselecionado = operaVenta.BuscarDE(txtIdInmeble.Text, conectar.con);

            if (Inmuebleselecionado != null)
            {
                txtDescripcion.Text = Inmuebleselecionado.Descripcion;
                txtPrecio.Text =Convert.ToString( Inmuebleselecionado.Precio);
                txtIdInmeble.Enabled = false;
            }
            else
            {
                MessageBox.Show("Inmueble No Encontrado!!", "Inmueble", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdInmeble.Clear();
            }
            conectar.cerrarconexion();
            conectar.abrirconexion();
            string id = Convert.ToString(txtIdInmeble.Text);
            dgInmueble.DataSource = operaVenta.BuscarparametroI(id, conectar.con);
            conectar.cerrarconexion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmClienteAgregar frm = new frmClienteAgregar();
            frm.Show();
        }


        public void Calculo()
        {
            double Preci = Convert.ToDouble(txtPrecio.Text);
            double Descu, impu, impuesto, Importe;
         
            if (cbForma.SelectedItem.ToString() == "Contado")
            {
                txtCuotas.Enabled = false;
                txtCuotas.Text = "0";
                txtPrima.Enabled = false;
                lbPrima.Visible = false;
                txtPrima.Visible = false;
                txtDescuento.Visible = true;
                lbDescuento.Visible = true;
                Descu = (Preci * 0.05);
                    
                
                impu = Preci - Descu;
                impuesto = (impu * 0.15);               
                Importe=impu-impuesto;
                txtImporte.Text = Convert.ToString(Importe);
                txtImpuesto.Text = Convert.ToString(impuesto);
                txtTotal.Text = Convert.ToString(impu);
                txtPrima.Text = Convert.ToString(impu);
                txtDescuento.Text = Convert.ToString(Descu);
            }
            else if (cbForma.SelectedItem.ToString() == "Credito")            
            {
                txtCuotas.Enabled = true;
                txtDescuento.Visible = false;
                lbDescuento.Visible = false;
                txtCuotas.Text = "1";
                txtPrima.Visible = true;
                lbPrima.Visible = true;                
                
            }
        }

        public void Pag()
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            Pago pInmue1 = new Pago();
            pInmue1.Id = "1";
            pInmue1.Operacion = txtIdContrato.Text.Trim();
            pInmue1.Pagado = Convert.ToDouble(txtPrima.Text);
            pInmue1.Pendiente = Convert.ToDouble(Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtPrima.Text));
            pInmue1.Mora = Convert.ToDouble("0");
            pInmue1.CuotasP = Convert.ToInt16(txtCuotas.Text);
            pInmue1.Fecha = dtpFechaCotrato.Value.Day + "/" + dtpFechaCotrato.Value.Month + "/" + dtpFechaCotrato.Value.Year;



            int resultado1 = operaPagos.agregarPago(conectar.con, pInmue1);


            if (resultado1 > 0)
            {
                MessageBox.Show("se registrado el primer pago Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo registrar el pagos", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conectar.cerrarconexion();
        } 
        private void cbForma_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.Calculo();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Conexion conectar = new Conexion();
            conectar.abrirconexion();

            Ventas pInmue = new Ventas();
            pInmue.IdV = txtIdContrato.Text.Trim();
            pInmue.FechaV = dtpFechaCotrato.Value.Day + "/" + dtpFechaCotrato.Value.Month + "/" + dtpFechaCotrato.Value.Year;
            pInmue.Observacion = txtObservacion.Text.Trim();
            pInmue.Cliente = txtIdC.Text.Trim();
            pInmue.Empleado = txtIdE.Text.Trim();
            pInmue.Propiedad =txtIdInmeble.Text.Trim();
            pInmue.Forma = cbForma.Text.Trim();
            pInmue.Cuotas = Convert.ToInt16(txtCuotas.Text);
            pInmue.prima = Convert.ToDouble(txtPrima.Text);
            pInmue.Descuento = Convert.ToDouble(txtDescuento.Text);
            pInmue.Total = Convert.ToDouble(txtTotal.Text);
            

            int resultado = operaVenta.agregarVenta(conectar.con, pInmue);
           
            if (resultado > 0)
            {
                MessageBox.Show("Contrato Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Pag();
              
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Inmueble", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conectar.cerrarconexion();
          

            txtIdC.Clear();
            txtIdE.Clear();
            txtIdInmeble.Clear();
            txtIdContrato.Clear();
            txtCuotas.Clear();
            txtPrecio.Clear();
            txtNombreC.Clear();
            txtNombreE.Clear();
            txtDescripcion.Clear();
            txtObservacion.Text = "";
            txtPrima.Text = "";
            txtTotal.Text = "";
            dgInmueble.Text = "";
            dtpFechaCotrato.Text = "";
            txtImpuesto.Clear();
            txtImporte.Clear();
            txtDescuento.Clear();
            cbForma.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int Cuo = 1;
        double Prima;
        private void txtCuotas_TextChanged(object sender, EventArgs e)
        {
            double Preci = Convert.ToDouble(txtPrecio.Text);
            double impuesto1, Importe;
            if (txtCuotas.Text == "")
            {
                txtCuotas.Text = "1";
            }
            Cuo =Convert.ToInt16(txtCuotas.Text);
            Prima = Preci / Cuo;
            txtDescuento.Visible = false;
            txtPrima.Visible = true;
            lbPrima.Visible = true;
            impuesto1 = Preci * 0.15;

            Importe = Preci - impuesto1;
            txtDescuento.Text = "0";
            txtPrima.Text = Convert.ToString(impuesto1);
            txtImporte.Text = Convert.ToString(Importe);
            Math.Round(Prima);
            txtPrima.Text = Convert.ToString(Prima);
            txtImpuesto.Text = Convert.ToString(impuesto1);
            txtTotal.Text = Convert.ToString(Preci);
        }

        private void txtPrima_TextChanged(object sender, EventArgs e)
        {
            if (txtCuotas.Text == "")
            {
                txtCuotas.Text = "1";
            }
        }

        private void txtNombreE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

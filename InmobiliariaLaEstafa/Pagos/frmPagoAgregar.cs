﻿using System;
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
        
        //boton  buscar
        private void button5_Click(object sender, EventArgs e)
        {
            
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            string id2 = Convert.ToString(txtId.Text);
           
           Pagoselecionado = operaPagos.Contrato1(id2, conectar.con);
          //  MessageBox.Show("mostrar id ", Pagoselecionado.Operacion);
            if (Pagoselecionado != null)
            {
                txtNumero.Text = Pagoselecionado.Id;
               // txtId.Text = Pagoselecionado.Operacion;
              txtCliente.Text = Pagoselecionado.NombreC;
                tDireccion.Text = Pagoselecionado.DireccionC;
                txtTipo.Text = Pagoselecionado.Tipo;
              txtDescripcion.Text = Pagoselecionado.Descripcion;
                textBox1.Text = Convert.ToString(Pagoselecionado.CuotasP);
               textAbono.Text = Convert.ToString(Pagoselecionado.prima);
                txtAcumullada.Text = Convert.ToString(Pagoselecionado.Pagado);
                txtPendiente.Text = Convert.ToString(Pagoselecionado.Pendiente);
                txtmora.Text = Convert.ToString(Pagoselecionado.Mora);
                dtpFecha.Text = Convert.ToString(Pagoselecionado.Fecha);
                this.grid();
                txtId.Enabled = false;
                
            }
            else
            {
                MessageBox.Show("Pago No Encontrado!!", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Clear();
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
            pInmue1.Id = txtNumero.Text.Trim(); ;
            pInmue1.Operacion = txtId.Text.Trim();
            pInmue1.Pagado = Convert.ToDouble(Convert.ToDouble(txtAcumullada.Text) + Convert.ToDouble(textAbono.Text));
            pInmue1.Pendiente = Convert.ToDouble(Convert.ToDouble(txtPendiente.Text) - Convert.ToDouble(textAbono.Text));
            pInmue1.Mora = Convert.ToDouble(txtmora.Text);
            pInmue1.CuotasP = Convert.ToInt16(textBox1.Text) - 1;
            pInmue1.Fecha = dtpFecha.Value.Day + "/" + dtpFecha.Value.Month + "/" + dtpFecha.Value.Year;



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

            ///////////////
           
            

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
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            dgPago.DataSource = Pagoselecionado;
        }
    }
}

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
    public partial class frmInmuebleAgregar : Form
    {
        public frmInmuebleAgregar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();

            Inmuebles pInmueble = new Inmuebles();
            pInmueble.Id = txtId.Text.Trim();
            pInmueble.Ciudad = cbCiudad.Text.Trim();
            pInmueble.Direccion = cbDireccion.Text.Trim();
            pInmueble.Descripcion = txtDescripcion.Text.Trim();
            pInmueble.Tipo = cbTipo.Text.Trim();
            pInmueble.Precio = Convert.ToInt32(txtPrecio.Text);
            pInmueble.Comision =Convert.ToInt32(txtComision.Text);
            pInmueble.Medida = Convert.ToInt16(txtMedida.Text);
            pInmueble.Banos = Convert.ToInt16(dudBanos.Text);
            pInmueble.Dormitorios = Convert.ToInt16(dudDormitorios.Text);
            pInmueble.Foto =  txtFoto.Text.Trim();

            int resultado = operaInmueble.agregarinmueble(conectar.con, pInmueble);
            if (resultado > 0)
            {
                MessageBox.Show("Inmueble Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Inmueble", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conectar.cerrarconexion();
            
            txtId.Clear();
            txtComision.Clear();
            txtPrecio.Clear();
            txtMedida.Clear();
            txtDescripcion.Clear();
            cbDireccion.Text="";
            cbCiudad.Text = "";
            cbTipo.Text = "";
            dudDormitorios.Text = "";
            dudBanos.Text = "";
            txtFoto.Clear();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnRefre_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgAgregarInmueble.DataSource = operaInmueble.Buscar(conectar.con);
            txtId.Clear();
            txtComision.Clear();
            txtPrecio.Clear();
            txtMedida.Clear();
            txtDescripcion.Clear();
            cbDireccion.Text = "";
            cbCiudad.Text = "";
            cbTipo.Text = "";
            dudDormitorios.Text = "";
            dudBanos.Text = "";
            txtFoto.Clear();
        }

        private void frmInmuebleAgregar_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgAgregarInmueble.DataSource = operaInmueble.Buscar(conectar.con);
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            double Preci = Convert.ToDouble(txtPrecio.Text);
            double T = 0;
           
            T = (Preci * 0.03);
            txtComision.Text =Convert.ToString(T);
        }

        private void txtComision_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

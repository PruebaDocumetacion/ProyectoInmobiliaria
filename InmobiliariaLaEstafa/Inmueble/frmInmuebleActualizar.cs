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
    public partial class frmInmuebleActualizar : Form
    {
        public frmInmuebleActualizar()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public Inmuebles InmuebleActual { get; set; }
        public Inmuebles Inmuebleselecionado { get; set; }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();

            string id = Convert.ToString(txtId.Text);
            Inmuebleselecionado = operaInmueble.Buscarparametro1(id, conectar.con);

            if (Inmuebleselecionado != null)
            {
                cbCiudad.Text=Inmuebleselecionado.Ciudad;
                cbDireccion.Text=Inmuebleselecionado.DireccionI;
                txtDescripcion.Text=Inmuebleselecionado.Descripcion;
                cbTipo.Text=Inmuebleselecionado.Tipo;
                txtPrecio.Text=Convert.ToString(Inmuebleselecionado.Precio);
                txtComision.Text= Convert.ToString(Inmuebleselecionado.Comision) ;
                txtMedida.Text= Convert.ToString(Inmuebleselecionado.Medida);
                dudBanos.Text= Convert.ToString(Inmuebleselecionado.Banos);
                dudDormitorios.Text= Convert.ToString(Inmuebleselecionado.Dormitorios);
                txtFoto.Text = Inmuebleselecionado.Foto;
                InmuebleActual = Inmuebleselecionado;
            }
            txtId.Enabled = false;
            conectar.cerrarconexion();
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                Conexion conectar = new Conexion();
                conectar.abrirconexion();

                Inmuebles pInmueble = new Inmuebles();
                pInmueble.IdI = txtId.Text.Trim();
                pInmueble.Ciudad = cbCiudad.Text.Trim();
                pInmueble.DireccionI = cbDireccion.Text.Trim();
                pInmueble.Descripcion = txtDescripcion.Text.Trim();
                pInmueble.Tipo = cbTipo.Text.Trim();
                pInmueble.Precio = Convert.ToInt32(txtPrecio.Text);
                pInmueble.Comision = Convert.ToInt32(txtComision.Text);
                pInmueble.Medida = Convert.ToInt16(txtMedida.Text);
                pInmueble.Banos = Convert.ToInt16(dudBanos.Text);
                pInmueble.Dormitorios = Convert.ToInt16(dudDormitorios.Text);
                pInmueble.Foto = txtFoto.Text.Trim();

                int resultado = operaInmueble.modificarinmueble(conectar.con, pInmueble);
                if (resultado > 0)
                {
                    MessageBox.Show("Inmueble Actualizado Con Exito!!", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el Inmueble", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                conectar.cerrarconexion();

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
                pInmueble.Foto = txtFoto.Text.Trim();
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;

                dgActualizarInmueble.DataSource = operaInmueble.Buscar(conectar.con);
            }
            txtId.Enabled = true;

        }
        private bool ValidarCamposVacios()
        {
            bool valido = false;
            if (txtId.Text.Length != 5)
            {
                MessageBox.Show("El Codigo de Inmueble esta incompleto");
            }
            else
            {
                if (cbCiudad.Text.Trim() == "")
                {
                    MessageBox.Show("ingrese La ciudad");
                }
                else
                {
                    if (cbDireccion.Text.Trim() == "")
                    {
                        MessageBox.Show("Ingrese el barrio");
                    }
                    else
                    {
                        if (cbTipo.Text.Trim() == "")
                        {
                            MessageBox.Show("Ingrese el tipo de Inmueble");
                        }
                        else
                        {
                            if (txtMedida.Text.Trim() == "" || txtMedida.Text.Length >= 5)
                            {
                                MessageBox.Show("Ingrese la medida completa que no sea mayor a 10000");
                            }
                            else
                            {
                                if (dudBanos.Text.Trim() == "")
                                {
                                    MessageBox.Show("Ingrese la cantidad de baños");
                                }
                                else
                                {
                                    if (dudDormitorios.Text.Trim() == "")
                                    {
                                        MessageBox.Show("Ingrese la cantidad de dormitorios");
                                    }
                                    else
                                    {
                                        if (txtPrecio.Text.Trim() == "")
                                        {
                                            MessageBox.Show("Ingrese el precio del inmueble");
                                        }
                                        else
                                        {
                                            valido = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            return valido;

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
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
          //  pInmueble.Foto = txtFoto.Text.Trim();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            dgActualizarInmueble.DataSource = operaInmueble.Buscar(conectar.con);
            txtId.Enabled = true;
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();

            Inmuebles pInmueble1 = new Inmuebles();
            pInmueble1.IdI = InmuebleActual.IdI;


            if (MessageBox.Show("Esta Seguro que desea eliminar el Inmueble Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtId.Enabled = true;

                int resultado3 = operaInmueble.eliminarinmueble(conectar.con, pInmueble1);
                if (resultado3 > 0)
                {
                    MessageBox.Show("Inmueble Eliminado Correctamente!", "Inmueble Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Inmueble", "Inmueble No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            

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
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            dgActualizarInmueble.DataSource = operaInmueble.Buscar(conectar.con);
            txtId.Enabled = true;
            conectar.cerrarconexion();
        }

        private void frmInmuebleActualizar_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.abrirconexion();
            dgActualizarInmueble.DataSource = operaInmueble.Buscar(conectar.con);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgActualizarInmueble_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

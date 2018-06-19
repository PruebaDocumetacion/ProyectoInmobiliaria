namespace Conexion.Empleado
{
    partial class frmAgregarEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgEmpleado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefre = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgEmpleado
            // 
            this.dgEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEmpleado.ColumnHeadersHeight = 21;
            this.dgEmpleado.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgEmpleado.Location = new System.Drawing.Point(24, 243);
            this.dgEmpleado.Name = "dgEmpleado";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.dgEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgEmpleado.Size = new System.Drawing.Size(610, 124);
            this.dgEmpleado.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRefre);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 215);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnRefre
            // 
            this.btnRefre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefre.Location = new System.Drawing.Point(278, 167);
            this.btnRefre.Name = "btnRefre";
            this.btnRefre.Size = new System.Drawing.Size(83, 28);
            this.btnRefre.TabIndex = 24;
            this.btnRefre.Text = "Refrescar";
            this.btnRefre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefre.UseVisualStyleBackColor = true;
            this.btnRefre.Click += new System.EventHandler(this.btnRefre_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnGuardar.FlatAppearance.BorderSize = 4;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(162, 165);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 33);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(394, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 33);
            this.button4.TabIndex = 11;
            this.button4.Text = "Cancelar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Correo Electrónico:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(204, 119);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(282, 25);
            this.txtCorreo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(403, 70);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(172, 25);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(137, 70);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(147, 25);
            this.txtTelefono.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(394, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 25);
            this.txtNombre.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(135, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(147, 25);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // frmAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 390);
            this.Controls.Add(this.dgEmpleado);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAgregarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarEmpleado";
            this.Load += new System.EventHandler(this.frmAgregarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefre;
    }
}
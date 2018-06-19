namespace Conexion.Pagos
{
    partial class frmPagoBuscar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoInmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dormitorios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baños = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.Location = new System.Drawing.Point(456, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 33);
            this.button3.TabIndex = 27;
            this.button3.Text = "Crear Tabla";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(625, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 25);
            this.textBox3.TabIndex = 26;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Número Pago :";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(265, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "Buscar Todos los pagos";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.button5.FlatAppearance.BorderSize = 4;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button5.Location = new System.Drawing.Point(161, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 33);
            this.button5.TabIndex = 22;
            this.button5.Text = "Buscar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(559, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(329, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 25);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(161, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 25);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número Contrato :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.Ciudad,
            this.tipoInmueble,
            this.Precio,
            this.Direccion,
            this.Dormitorios,
            this.Column2,
            this.Baños,
            this.Mora});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.Location = new System.Drawing.Point(26, 186);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Size = new System.Drawing.Size(736, 202);
            this.dataGridView2.TabIndex = 48;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código Contrato";
            this.Codigo.Name = "Codigo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° Pago";
            this.Column1.Name = "Column1";
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Cliente";
            this.Ciudad.Name = "Ciudad";
            // 
            // tipoInmueble
            // 
            this.tipoInmueble.HeaderText = "Tipo Inmueble";
            this.tipoInmueble.Name = "tipoInmueble";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Acumulado";
            this.Precio.Name = "Precio";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Pendiente";
            this.Direccion.Name = "Direccion";
            // 
            // Dormitorios
            // 
            this.Dormitorios.HeaderText = "Fecha";
            this.Dormitorios.Name = "Dormitorios";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Abono";
            this.Column2.Name = "Column2";
            // 
            // Baños
            // 
            this.Baños.HeaderText = "Descuento";
            this.Baños.Name = "Baños";
            // 
            // Mora
            // 
            this.Mora.HeaderText = "Mora";
            this.Mora.Name = "Mora";
            // 
            // frmPagoBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPagoBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPagoBuscar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoInmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dormitorios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baños;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mora;
        private System.Windows.Forms.Button button3;
    }
}
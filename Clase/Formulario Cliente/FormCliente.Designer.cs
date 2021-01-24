
namespace Formulario_Cliente
{
    partial class FormCliente
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.seleccionFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntidad = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.lblRut = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 473);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(414, 153);
            this.dgvClientes.TabIndex = 22;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(351, 420);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(108, 420);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.seleccionFecha);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtEntidad);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.lblCliente);
            this.groupBox2.Controls.Add(this.lblEntidad);
            this.groupBox2.Controls.Add(this.txtCuenta);
            this.groupBox2.Controls.Add(this.lblCuenta);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 173);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Clientes";
            // 
            // seleccionFecha
            // 
            this.seleccionFecha.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.seleccionFecha.Location = new System.Drawing.Point(104, 136);
            this.seleccionFecha.Name = "seleccionFecha";
            this.seleccionFecha.Size = new System.Drawing.Size(214, 20);
            this.seleccionFecha.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha Creacion:";
            // 
            // txtEntidad
            // 
            this.txtEntidad.FormattingEnabled = true;
            this.txtEntidad.Items.AddRange(new object[] {
            "Banco Popular",
            "Banco BHD Leon",
            "Banco APAP",
            "Banco del Reservas",
            "Banco Scotiabank"});
            this.txtEntidad.Location = new System.Drawing.Point(106, 27);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(212, 21);
            this.txtEntidad.TabIndex = 18;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(104, 62);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(215, 20);
            this.txtCliente.TabIndex = 17;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 69);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(78, 13);
            this.lblCliente.TabIndex = 16;
            this.lblCliente.Text = "Codigo Cliente:";
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Location = new System.Drawing.Point(6, 35);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(94, 13);
            this.lblEntidad.TabIndex = 14;
            this.lblEntidad.Text = "Entidad Bancaria: ";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(104, 98);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(215, 20);
            this.txtCuenta.TabIndex = 9;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(6, 105);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(96, 13);
            this.lblCuenta.TabIndex = 8;
            this.lblCuenta.Text = "Numero de Cuenta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.lblRut);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.lblApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.lblNombres);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 187);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(104, 140);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(215, 20);
            this.txtRut.TabIndex = 15;
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(6, 143);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(27, 13);
            this.lblRut.TabIndex = 14;
            this.lblRut.Text = "Rut:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(104, 106);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(215, 20);
            this.txtDireccion.TabIndex = 13;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 109);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(104, 76);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(215, 20);
            this.txtApellidos.TabIndex = 11;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(6, 76);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 10;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(104, 40);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(215, 20);
            this.txtNombres.TabIndex = 9;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(6, 43);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 8;
            this.lblNombres.Text = "Nombres:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(270, 420);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(189, 420);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 657);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCliente";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtEntidad;
        private System.Windows.Forms.DateTimePicker seleccionFecha;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}


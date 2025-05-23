namespace BancoSimple2M5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvClientes = new DataGridView();
            dgvCuentas = new DataGridView();
            btnAgregar = new Button();
            btnAgregarCuenta = new Button();
            btnRealizarTransaccion = new Button();
            btnVerTransacciones = new Button();
            btnDesactivar = new Button();
            button6 = new Button();
            btnBuscar = new Button();
            txtBusqueda = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 37);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(442, 239);
            dgvClientes.TabIndex = 0;
            // 
            // dgvCuentas
            // 
            dgvCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.Location = new Point(460, 37);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.Size = new Size(645, 239);
            dgvCuentas.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(25, 282);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Cliente";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += AgregarCliente;
            // 
            // btnAgregarCuenta
            // 
            btnAgregarCuenta.Location = new Point(460, 282);
            btnAgregarCuenta.Name = "btnAgregarCuenta";
            btnAgregarCuenta.Size = new Size(108, 23);
            btnAgregarCuenta.TabIndex = 1;
            btnAgregarCuenta.Text = "Agregar Cuenta";
            btnAgregarCuenta.UseVisualStyleBackColor = true;
            btnAgregarCuenta.Click += AgregarCuenta;
            // 
            // btnRealizarTransaccion
            // 
            btnRealizarTransaccion.Location = new Point(588, 282);
            btnRealizarTransaccion.Name = "btnRealizarTransaccion";
            btnRealizarTransaccion.Size = new Size(135, 23);
            btnRealizarTransaccion.TabIndex = 1;
            btnRealizarTransaccion.Text = "Realizar Transacción";
            btnRealizarTransaccion.UseVisualStyleBackColor = true;
            btnRealizarTransaccion.Click += RegistrarTransferencia;
            // 
            // btnVerTransacciones
            // 
            btnVerTransacciones.Location = new Point(407, 323);
            btnVerTransacciones.Name = "btnVerTransacciones";
            btnVerTransacciones.Size = new Size(108, 23);
            btnVerTransacciones.TabIndex = 1;
            btnVerTransacciones.Text = "Ver Transacciones";
            btnVerTransacciones.UseVisualStyleBackColor = true;
            btnVerTransacciones.Click += VerTransacciones;
            // 
            // btnDesactivar
            // 
            btnDesactivar.Location = new Point(764, 282);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(108, 23);
            btnDesactivar.TabIndex = 1;
            btnDesactivar.Text = "Desactivar cuenta";
            btnDesactivar.UseVisualStyleBackColor = true;
            btnDesactivar.Click += DesactivarCuenta;
            // 
            // button6
            // 
            button6.Location = new Point(898, 282);
            button6.Name = "button6";
            button6.Size = new Size(108, 23);
            button6.TabIndex = 1;
            button6.Text = "Limpiar Seleccion";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(25, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(56, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += BuscarCliente;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(87, 8);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(367, 23);
            txtBusqueda.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 359);
            Controls.Add(txtBusqueda);
            Controls.Add(btnBuscar);
            Controls.Add(btnVerTransacciones);
            Controls.Add(button6);
            Controls.Add(btnDesactivar);
            Controls.Add(btnRealizarTransaccion);
            Controls.Add(btnAgregarCuenta);
            Controls.Add(btnAgregar);
            Controls.Add(dgvCuentas);
            Controls.Add(dgvClientes);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private DataGridView dgvCuentas;
        private Button btnAgregar;
        private Button btnAgregarCuenta;
        private Button btnRealizarTransaccion;
        private Button btnVerTransacciones;
        private Button btnDesactivar;
        private Button button6;
        private Button btnBuscar;
        private TextBox txtBusqueda;
    }
}

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
            components = new System.ComponentModel.Container();
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblContador = new Label();
            tiempo = new System.Windows.Forms.Timer(components);
            lblFechaHora = new Label();
            groupBox2 = new GroupBox();
            lblContadorCuentas = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(496, 37);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(647, 239);
            dgvClientes.TabIndex = 0;
            // 
            // dgvCuentas
            // 
            dgvCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.Location = new Point(496, 311);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.Size = new Size(645, 239);
            dgvCuentas.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(16, 67);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Cliente";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += AgregarCliente;
            // 
            // btnAgregarCuenta
            // 
            btnAgregarCuenta.Location = new Point(11, 59);
            btnAgregarCuenta.Name = "btnAgregarCuenta";
            btnAgregarCuenta.Size = new Size(108, 23);
            btnAgregarCuenta.TabIndex = 1;
            btnAgregarCuenta.Text = "Agregar Cuenta";
            btnAgregarCuenta.UseVisualStyleBackColor = true;
            btnAgregarCuenta.Click += AgregarCuenta;
            // 
            // btnRealizarTransaccion
            // 
            btnRealizarTransaccion.Location = new Point(11, 22);
            btnRealizarTransaccion.Name = "btnRealizarTransaccion";
            btnRealizarTransaccion.Size = new Size(135, 23);
            btnRealizarTransaccion.TabIndex = 1;
            btnRealizarTransaccion.Text = "Realizar Transacción";
            btnRealizarTransaccion.UseVisualStyleBackColor = true;
            btnRealizarTransaccion.Click += RegistrarTransferencia;
            // 
            // btnVerTransacciones
            // 
            btnVerTransacciones.Location = new Point(11, 51);
            btnVerTransacciones.Name = "btnVerTransacciones";
            btnVerTransacciones.Size = new Size(130, 23);
            btnVerTransacciones.TabIndex = 1;
            btnVerTransacciones.Text = "Ver Transacciones";
            btnVerTransacciones.UseVisualStyleBackColor = true;
            btnVerTransacciones.Click += VerTransacciones;
            // 
            // btnDesactivar
            // 
            btnDesactivar.Location = new Point(11, 96);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(108, 23);
            btnDesactivar.TabIndex = 1;
            btnDesactivar.Text = "Desactivar cuenta";
            btnDesactivar.UseVisualStyleBackColor = true;
            btnDesactivar.Click += DesactivarCuenta;
            // 
            // button6
            // 
            button6.Location = new Point(767, 282);
            button6.Name = "button6";
            button6.Size = new Size(108, 23);
            button6.TabIndex = 1;
            button6.Text = "Limpiar Seleccion";
            button6.UseVisualStyleBackColor = true;
            button6.Click += LimpiarSeleccion;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(496, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(56, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += BuscarCliente;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(558, 8);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(367, 23);
            txtBusqueda.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 37);
            label1.Name = "label1";
            label1.Size = new Size(246, 29);
            label1.TabIndex = 3;
            label1.Text = "Sistema Banco 2M5";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblContador);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Location = new Point(20, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 102);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles Clientes";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(16, 31);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(112, 15);
            lblContador.TabIndex = 2;
            lblContador.Text = "lblContadorClientes";
            // 
            // tiempo
            // 
            tiempo.Enabled = true;
            tiempo.Interval = 1000;
            tiempo.Tick += timer1_Tick;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(287, 89);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(38, 15);
            lblFechaHora.TabIndex = 5;
            lblFechaHora.Text = "label4";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblContadorCuentas);
            groupBox2.Controls.Add(btnAgregarCuenta);
            groupBox2.Controls.Add(btnDesactivar);
            groupBox2.Location = new Point(25, 238);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(434, 135);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles Cuentas";
            // 
            // lblContadorCuentas
            // 
            lblContadorCuentas.AutoSize = true;
            lblContadorCuentas.Location = new Point(16, 31);
            lblContadorCuentas.Name = "lblContadorCuentas";
            lblContadorCuentas.Size = new Size(113, 15);
            lblContadorCuentas.TabIndex = 2;
            lblContadorCuentas.Text = "lblContadorCuentas";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRealizarTransaccion);
            groupBox3.Controls.Add(btnVerTransacciones);
            groupBox3.Location = new Point(25, 379);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(434, 109);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalles Transacciones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 575);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(lblFechaHora);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtBusqueda);
            Controls.Add(btnBuscar);
            Controls.Add(button6);
            Controls.Add(dgvCuentas);
            Controls.Add(dgvClientes);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
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
        private Label label1;
        private GroupBox groupBox1;
        private Label lblContador;
        private System.Windows.Forms.Timer tiempo;
        private Label lblFechaHora;
        private GroupBox groupBox2;
        private Label lblContadorCuentas;
        private GroupBox groupBox3;
    }
}

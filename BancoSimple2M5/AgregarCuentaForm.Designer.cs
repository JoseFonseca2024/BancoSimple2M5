namespace BancoSimple2M5
{
    partial class AgregarCuentaForm
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtNumeroCuenta = new TextBox();
            label2 = new Label();
            label1 = new Label();
            numSaldo = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numSaldo).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(236, 100);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 34);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += CancelarRegistro;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(42, 100);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(122, 34);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += AceptarRegistro;
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.Location = new Point(207, 15);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(231, 23);
            txtNumeroCuenta.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 57);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Saldo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 23);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 4;
            label1.Text = "Numero de cuenta:";
            // 
            // numSaldo
            // 
            numSaldo.Location = new Point(207, 55);
            numSaldo.Name = "numSaldo";
            numSaldo.Size = new Size(120, 23);
            numSaldo.TabIndex = 9;
            // 
            // AgregarCuentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 156);
            Controls.Add(numSaldo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNumeroCuenta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarCuentaForm";
            Text = "AgregarCuentaForm";
            ((System.ComponentModel.ISupportInitialize)numSaldo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtNumeroCuenta;
        private Label label2;
        private Label label1;
        private NumericUpDown numSaldo;
    }
}
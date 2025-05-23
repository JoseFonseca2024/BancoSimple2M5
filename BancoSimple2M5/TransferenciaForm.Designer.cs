namespace BancoSimple2M5
{
    partial class TransferenciaForm
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
            lblOrigen = new Label();
            lblMonto = new Label();
            lblDestino = new Label();
            numMonto = new NumericUpDown();
            btnCancelar = new Button();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)numMonto).BeginInit();
            SuspendLayout();
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(39, 39);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(38, 15);
            lblOrigen.TabIndex = 0;
            lblOrigen.Text = "label1";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(39, 96);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(38, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "label1";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(39, 147);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(38, 15);
            lblDestino.TabIndex = 0;
            lblDestino.Text = "label1";
            // 
            // numMonto
            // 
            numMonto.Location = new Point(217, 94);
            numMonto.Name = "numMonto";
            numMonto.Size = new Size(120, 23);
            numMonto.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(261, 189);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 34);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += CancelarRegistro;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(67, 189);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(122, 34);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += AceptarRegistro;
            // 
            // TransferenciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 254);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(numMonto);
            Controls.Add(lblDestino);
            Controls.Add(lblMonto);
            Controls.Add(lblOrigen);
            Name = "TransferenciaForm";
            Text = "TransferenciaForm";
            ((System.ComponentModel.ISupportInitialize)numMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrigen;
        private Label lblMonto;
        private Label lblDestino;
        private NumericUpDown numMonto;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}
namespace BancoSimple2M5
{
    partial class TransaccionForm
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
            label1 = new Label();
            txtDescripción = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numMonto).BeginInit();
            SuspendLayout();
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(39, 13);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(38, 15);
            lblOrigen.TabIndex = 0;
            lblOrigen.Text = "label1";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(39, 70);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(38, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "label1";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(39, 121);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(38, 15);
            lblDestino.TabIndex = 0;
            lblDestino.Text = "label1";
            // 
            // numMonto
            // 
            numMonto.Location = new Point(217, 68);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 156);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripción:";
            // 
            // txtDescripción
            // 
            txtDescripción.Location = new Point(117, 153);
            txtDescripción.Name = "txtDescripción";
            txtDescripción.Size = new Size(356, 23);
            txtDescripción.TabIndex = 11;
            // 
            // TransferenciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 254);
            Controls.Add(txtDescripción);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(numMonto);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox txtDescripción;
    }
}
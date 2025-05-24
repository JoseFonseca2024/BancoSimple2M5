namespace BancoSimple2M5
{
    partial class AgregarClienteForm
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
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtIdentificación = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 65);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 0;
            label2.Text = "Identificación:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(224, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(231, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtIdentificación
            // 
            txtIdentificación.Location = new Point(224, 62);
            txtIdentificación.Name = "txtIdentificación";
            txtIdentificación.Size = new Size(231, 23);
            txtIdentificación.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(59, 110);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(122, 34);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += AceptarRegistro;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(253, 110);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 34);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += CancelarRegistro;
            // 
            // AgregarClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 156);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtIdentificación);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarClienteForm";
            Text = "AgregarClienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtIdentificación;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}
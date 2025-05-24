namespace BancoSimple2M5
{
    partial class VerTransaccionesForm
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
            dgvTransacciones = new DataGridView();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).BeginInit();
            SuspendLayout();
            // 
            // dgvTransacciones
            // 
            dgvTransacciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacciones.Location = new Point(31, 25);
            dgvTransacciones.Name = "dgvTransacciones";
            dgvTransacciones.Size = new Size(734, 365);
            dgvTransacciones.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(357, 405);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(107, 33);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += Aceptar;
            // 
            // VerTransaccionesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(dgvTransacciones);
            Name = "VerTransaccionesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerTransaccionesForm";
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTransacciones;
        private Button btnAceptar;
    }
}
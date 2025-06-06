﻿using BancoSimple2M5.Models;

namespace BancoSimple2M5
{
    public partial class AgregarCuentaForm : Form
    {
        public Cuenta NuevaCuenta { get; set; }
        private int ClienteID;
        public AgregarCuentaForm(int clienteID)
        {
            InitializeComponent();
            ClienteID = clienteID;
            //Maximo para permitir un rango ampleo en el saldo incial
            numSaldo.Maximum = 1000000;
        }

        private void AceptarRegistro(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeroCuenta.Text))
            {
                MessageBox.Show($"Ingrese el número de cuenta.");
                return;
            }
            else
            {
                NuevaCuenta = new Cuenta
                {
                    NumeroCuenta = txtNumeroCuenta.Text,
                    Saldo = numSaldo.Value,
                    ClienteID = ClienteID,
                    Activa = true,
                };
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CancelarRegistro(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

using BancoSimple2M5.Data;
using Microsoft.EntityFrameworkCore;


namespace BancoSimple2M5
{
    public partial class TransaccionForm : Form
    {
        public int CuentaOrigenID;

        public int CuentaDestinoID;

        public decimal Monto { get; private set; }

        public string Descripción { get; private set; }

        private BancoSimple2M5Context context;

        public TransaccionForm(int cuentaOrigenID, int cuentaDestinoID)
        {
            InitializeComponent();
            CuentaOrigenID = cuentaOrigenID;
            CuentaDestinoID = cuentaDestinoID;
            context = new BancoSimple2M5Context();
            CargarDatosCuentas();
            //Maximo de monto a despositar
            numMonto.Maximum = 1000000;
        }

        private void CargarDatosCuentas()
        {
            var cuentaOrigen = context.Cuenta.Include(c => c.Cliente).First(c => c.CuentaID == CuentaOrigenID);
            var cuentaDestino = context.Cuenta.Include(c => c.Cliente).First(c => c.CuentaID == CuentaDestinoID);

            lblOrigen.Text = $"CUENTA ORIGEN:  {cuentaOrigen.Cliente.Nombre} - {cuentaOrigen.NumeroCuenta}";
            lblDestino.Text = $"CUENTA DESTINO:  {cuentaDestino.Cliente.Nombre} - {cuentaDestino.NumeroCuenta}";
            lblMonto.Text = $"SALDO DISPONIBLE: {cuentaOrigen.Saldo}";
        }

        private void AceptarRegistro(object sender, EventArgs e)
        {
            if (numMonto.Value > 0)
            {
                Monto = numMonto.Value;
                Descripción = txtDescripción.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ingrese un monto válido mayor a 0", "Monto no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarRegistro(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

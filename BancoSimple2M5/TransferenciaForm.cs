using BancoSimple2M5.Data;
using BancoSimple2M5.Models;
using Microsoft.EntityFrameworkCore;


namespace BancoSimple2M5
{
    public partial class TransferenciaForm : Form
    {
        public int CuentaOrigenID;

        public int CuentaDestinoID;

        public Decimal Monto { get; private set; }

        private BancoSimple2M5Context context;

        public TransferenciaForm(int cuentaOrigenID, int cuentaDestinoID)
        {
            InitializeComponent();
            CuentaOrigenID = cuentaOrigenID;
            CuentaDestinoID = cuentaDestinoID;
            context = new BancoSimple2M5Context();
            CargarDatosCuentas();
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
              
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ingrese un monto válido mayor a 0");
            }
        }

        private void CancelarRegistro(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

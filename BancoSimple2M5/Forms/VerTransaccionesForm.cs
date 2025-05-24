using BancoSimple2M5.Data;
using BancoSimple2M5.Services;

namespace BancoSimple2M5
{
    public partial class VerTransaccionesForm : Form
    {
        private BancoSimple2M5Context _context = new BancoSimple2M5Context();
        public VerTransaccionesForm()
        {
            InitializeComponent();
            CargarTransferencias();
        }

        private void CargarTransferencias()
        {
            var transferecnia_server = new TransaccionService(_context);
            dgvTransacciones.DataSource = transferecnia_server.ObtenerTransaccion();
        }

        private void Aceptar(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

using BancoSimple2M5.Data;
using BancoSimple2M5.Services;

namespace BancoSimple2M5
{
    public partial class Form1 : Form
    {
        private BancoSimple2M5Context _db = new BancoSimple2M5Context();

        public Form1()
        {
            InitializeComponent();
            CargarDatos();
            reloj.Start();
        }

        private void CargarDatos()
        {
            dgvClientes.ClearSelection();
            dgvCuentas.ClearSelection();

            //Uso de cliente_service y sus metodos de obtención de datos
            var clienteService = new ClienteService(_db);
            dgvClientes.DataSource = clienteService.ObtenerClientes();
            lblContador.Text = clienteService.ContarCLientes();

            //Uso de cuenta_service y sus metodos de obtención de datos
            var cuentaService = new CuentaService(_db);
            dgvCuentas.DataSource = cuentaService.ObtenerCuentasActivas();
            lblContadorCuentas.Text = cuentaService.ContadorCuentas();

        }

        //Evento para agregar al cliente a la base de datos
        private void OnClienteAgragrado(object sender, EventArgs e)
        {
            var form = new AgregarClienteForm();
            var clienteService = new ClienteService(_db);
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    clienteService.AgregarCliente(form.NuevoCliente);
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        //Evento para agregar cuenta
        private void OnCuentaAgregada(object sender, EventArgs e)
        {

            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente primero", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            var clienteId = (int)dgvClientes.SelectedRows[0].Cells["ClienteId"].Value;
            var form = new AgregarCuentaForm(clienteId);

            if (form.ShowDialog() == DialogResult.OK)
            {
                var cuentaService = new CuentaService(_db);
                cuentaService.AgregarCuenta(form.NuevaCuenta);
                CargarDatos();
            }
        }

        // Evento para realizar y registrar transferecnia
        private void OnTransferenciaRealizada(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count != 2)
            {
                MessageBox.Show("Seleccione exactamente 2 cuentas", "Sobre-selección", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;

            }
            else
            {
                //Primera cuenta seleccionada
                var cuentaOrigenId = (int)dgvCuentas.SelectedRows[1].Cells["CuentaId"].Value;
                //Segunda cuenta seleccionada
                var cuentaDestinoId = (int)dgvCuentas.SelectedRows[0].Cells["CuentaId"].Value;

                var form = new TransaccionForm(cuentaOrigenId, cuentaDestinoId);
                var transferenciaService = new TransaccionService(_db);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        transferenciaService.RealizarTransaccion(cuentaOrigenId, cuentaDestinoId, form.Monto, form.Descripción);
                        CargarDatos();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        //Evento para desactivar cuenta
        private void OnCuentaDesactivada(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciones una cuenta para desactivar", "Cuentas no seleccionadas", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            var cuentaId = (int)dgvCuentas.SelectedRows[0].Cells["CuentaId"].Value;
            var cuentaService = new CuentaService(_db);
            cuentaService.DesactivarCuenta(cuentaId);
            CargarDatos();
        }

        //Evento para llamar form y ver transacciones
        private void OnVerTransacciones(object sender, EventArgs e)
        {
            var form = new VerTransaccionesForm();
            form.ShowDialog();

        }

        //Evento para realizar busqueda de cliente por su nombre
        private void OnClienteBuscado(object sender, EventArgs e)
        {
            // busqueda con patrones con like
            var like = txtBusqueda.Text;
            var cliente_service = new ClienteService(_db);
            cliente_service.BuscarCliente(like, dgvClientes);
        }

        //boton para limpiar la seleccion en los dataGriedView
        private void OnSeleccionLimpiada(object sender, EventArgs e)
        {
            dgvClientes.ClearSelection();
            dgvCuentas.ClearSelection();
        }

        //Reloj para mostrar hora actual
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = $"Hoy: {DateTime.Now}";
        }

        //Carga de los DataGriedview sin seleccionar algun objeto
        private void CargarsinSeleccion(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvClientes.ClearSelection();
            dgvCuentas.ClearSelection();    
            dgvClientes.CurrentCell = null;
            dgvCuentas.CurrentCell = null;
        }
    }
}

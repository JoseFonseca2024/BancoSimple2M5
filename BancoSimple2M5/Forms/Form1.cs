    using BancoSimple2M5.Data;
    using Microsoft.EntityFrameworkCore;
    using BancoSimple2M5.Models;
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
            tiempo.Start();
        }

        private void CargarDatos()
        {
            //Uso de cuenta_service y sus metodos de obtención de datos
            var cuentaService = new Cuenta_Services(_db);
            dgvCuentas.DataSource = cuentaService.ObtenerCuentasActivas();
            lblContadorCuentas.Text = cuentaService.ContadorCuentas();

            //Uso de cliente_service y sus metodos de obtención de datos
            var clienteService = new Cliente_Service(_db);
            dgvClientes.DataSource = clienteService.ObtenerClientes();
            lblContador.Text = clienteService.ContarCLientes();
        }

        //Usar Metodo de Cliente_service para agregar
        private void AgregarCliente(object sender, EventArgs e)
        {
            var form = new AgregarClienteForm();
            var clienteService = new Cliente_Service(_db);
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    clienteService.AgregarCliente(form.NuevoCliente);
                    CargarDatos();
                    MessageBox.Show("Cliente agregado exitosamente." , "Éxito" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                
                }
                
            }
        }

        //Usar Metodo de Cuenta_service para agregar
        private void AgregarCuenta(object sender, EventArgs e)
        {
           
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente primero");
                return;
            }
            var clienteId = (int)dgvClientes.SelectedRows[0].Cells["ClienteId"].Value;
            var form = new AgregarCuentaForm(clienteId);
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                var cuentaService = new Cuenta_Services(_db);
                cuentaService.AgregarCuenta(form.NuevaCuenta);
                CargarDatos();
            }
        }  

        // Usar metodo de Transferenciaservice
        private void RegistrarTransferencia(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count != 2)
            {
                MessageBox.Show("Seleccione exactamente 2 cuentas");
                return;

            }
            else
            {
                var cuentaOrigenId = (int)dgvCuentas.SelectedRows[1].Cells["CuentaId"].Value;
                var cuentaDestinoId = (int)dgvCuentas.SelectedRows[0].Cells["CuentaId"].Value;

                var form = new TransferenciaForm(cuentaOrigenId, cuentaDestinoId);
                var transferenciaService = new Transferencia_Service(_db);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        transferenciaService.RealizarTransferencia(cuentaOrigenId, cuentaDestinoId, form.Monto, form.Descripción);
                        MessageBox.Show("Transferencia Realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    } catch (Exception ex){

                        MessageBox.Show(ex.Message);
                    
                    }
                    
                }
            }
        }

        //Usar Metodo de Cuenta_service para agregar
        private void DesactivarCuenta(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciones una cuenta para desactivar");
            }
            var cuentaId = (int)dgvCuentas.SelectedRows[0].Cells["CuentaId"].Value;
            var cuentaService = new Cuenta_Services(_db);
            cuentaService.DesactivarCuenta(cuentaId);
            CargarDatos();
        }

        private void VerTransacciones(object sender, EventArgs e)
        {
            var form = new VerTransaccionesForm();
            form.ShowDialog();

        }

        private void BuscarCliente(object sender, EventArgs e)
        {
            // busqueda con patrones con like
            var like = txtBusqueda.Text;
            var cliente_service = new Cliente_Service(_db);
            cliente_service.BuscarCliente(like, dgvClientes);
        }


        private void LimpiarSeleccion(object sender, EventArgs e)
        {
            dgvClientes.ClearSelection();
            dgvCuentas.ClearSelection();
        }

        //Reloj para mostrar hora actual
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = $"Hoy: {DateTime.Now}";
        }
    }
}

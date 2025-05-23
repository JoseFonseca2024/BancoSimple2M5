using BancoSimple2M5.Data;
using Microsoft.EntityFrameworkCore;
using BancoSimple2M5.Models;

namespace BancoSimple2M5
{
    public partial class Form1 : Form
    {
        private BancoSimple2M5Context _db = new BancoSimple2M5Context();
        public Form1()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            var cuenta = _db.Cuenta.
                Include(c => c.Cliente).
                Where(c => c.Activa).
                Select(c => new
                {
                    c.CuentaID,
                    c.NumeroCuenta,
                    c.Saldo,
                    c.Activa,
                    c.ClienteID,
                    c.Cliente.Nombre
                }


                ).ToList();
            dgvClientes.DataSource = _db.Cliente.ToList();
            dgvCuentas.DataSource = cuenta;
        }

        private void AgregarCliente (object sender, EventArgs e)
        {
            var form = new AgregarClienteForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _db.Cliente.Add(form.NuevoCliente);
                _db.SaveChanges();
                CargarDatos();
            }
        }

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
                _db.Cuenta.Add(form.NuevaCuenta);
                _db.SaveChanges();
                CargarDatos();
            }
        }

        private void RealizarTransfrencia(int origenId, int destinoId, decimal monto)
        {
            //Transacciones
            //Niveles de aislamiento
            using var transaccion = _db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable);
            {
                try
                {
                    var cuentaOrigen = _db.Cuenta.FirstOrDefault(c => c.CuentaID == origenId);
                    var cuentaDestino = _db.Cuenta.FirstOrDefault(c => c.CuentaID == destinoId);

                    if (cuentaOrigen.Saldo < monto)
                    {
                        throw new Exception("Saldo Insuficiente ");
                    }

                    cuentaOrigen.Saldo -= monto;
                    cuentaDestino.Saldo += monto;

                    //Registrar la transaccion
                    _db.Transaccion.Add(new Transaccion
                    {
                        Monto = monto,
                        Fecha = DateTime.Now,
                        Descripción = "Transferencia",
                        CuentaOrigenId = origenId,
                        CuentaDestinoId = destinoId
                    });
                    _db.SaveChanges();
                    //Transaccion completada
                    transaccion.Commit();
                    MessageBox.Show("Transferencia realizada con exito");
                    CargarDatos();


                }
                catch (Exception ex)
                {
                    //Reversion de transacciones
                    transaccion.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

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
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RealizarTransfrencia(cuentaOrigenId, cuentaDestinoId, form.Monto);
                }
            }
        }

        private void DesactivarCuenta(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciones una cuenta para desactivar");
            }
            var cuentaId = (int)dgvCuentas.SelectedRows[0].Cells["CuentaId"].Value;
            var cuenta = _db.Cuenta.Find(cuentaId);
            cuenta.Activa = false;
            _db.SaveChanges();
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
            var clientes = _db.Cliente.
                Where
                (c => EF.Functions.Like(c.Nombre, $"%{like}%")).
                ToList();
            dgvClientes.DataSource = clientes;
        }
    }
}

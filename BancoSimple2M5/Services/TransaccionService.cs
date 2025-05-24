using BancoSimple2M5.Data;
using BancoSimple2M5.Models;
using Microsoft.EntityFrameworkCore;

namespace BancoSimple2M5.Services
{
    public class TransaccionService
    {
        //Declaración de la dependencia con la base de datos
        private readonly BancoSimple2M5Context _context;

        public TransaccionService(BancoSimple2M5Context context)
        {
            _context = context;
        }

        public List<Transaccion> ObtenerTransaccion()
        {
            return _context.Transaccion.ToList();
        }

        public void RealizarTransaccion(int origenID, int destinoID, decimal monto, string descripción)
        {
            //Transacciones 
            //Niveles de aislamiento
            using var transacción = _context.Database.BeginTransaction(System.Data.IsolationLevel.Serializable);
            {
                try
                {
                    var cuentaOrigen = _context.Cuenta.FirstOrDefault(c => c.CuentaID == origenID);
                    var cuentaDestino = _context.Cuenta.FirstOrDefault(c => c.CuentaID == destinoID);
                    if (cuentaOrigen.Saldo < monto)
                    {
                        throw new Exception("Saldo insuficiente");
                    }
                    else
                    {
                        cuentaOrigen.Saldo -= monto;
                        cuentaDestino.Saldo += monto;

                        //Registrar la transacción

                        _context.Transaccion.Add(new Transaccion
                        {
                            Monto = monto,
                            Fecha = DateTime.Now,
                            Descripción = descripción,
                            CuentaOrigenId = origenID,
                            CuentaDestinoId = destinoID
                        });
                        _context.SaveChanges();
                        //Transacción Completada
                        transacción.Commit();
                        MessageBox.Show("Transferencia realizada con exito", "Exto en operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    //Reversión de transacción
                    transacción.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}

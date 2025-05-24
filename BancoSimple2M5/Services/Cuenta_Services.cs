using BancoSimple2M5.Data;
using BancoSimple2M5.Models;
using Microsoft.EntityFrameworkCore;

namespace BancoSimple2M5.Services
{
    public class Cuenta_Services
    {
        private readonly BancoSimple2M5Context _context;

        public Cuenta_Services(BancoSimple2M5Context context)
        {
            _context = context;
        }

        public void AgregarCuenta(Cuenta cuenta)
        {
            _context.Cuenta.Add(cuenta);
            _context.SaveChanges();
        }

        public void DesactivarCuenta(int cuentaId)
        {
            var cuenta = _context.Cuenta.Find(cuentaId);
            cuenta.Activa = false;
            _context.SaveChanges();
        }

        //Obtener las cuentas 
        public List<object> ObtenerCuentasActivas()
        {
            return _context.Cuenta.Include(c => c.Cliente)
                .Where(c => c.Activa)
                .Select(c => new {
                    c.CuentaID,
                    c.NumeroCuenta,
                    c.Saldo,
                    c.Activa,
                    c.Cliente.Nombre
                }).ToList<object>();
        }

        //Contador de cuentas registradas
        public string ContadorCuentas ()
        {
            int contador = _context.Cuenta.Count();
            return $"Cuentas activas registradas: {contador}";
        }
    }
}

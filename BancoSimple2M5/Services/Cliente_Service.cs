using BancoSimple2M5.Data;
using BancoSimple2M5.Models;
using Microsoft.EntityFrameworkCore;

namespace BancoSimple2M5.Services
{
    public class Cliente_Service
    {
        private readonly BancoSimple2M5Context _context;
        public Cliente_Service(BancoSimple2M5Context context)
        {
            _context = context;
        }

        public void AgregarCliente(Cliente cliente)
        {
            //Try para evitar quiebre al superar los limites de digitos en la cedula
            try
            {
                _context.Cliente.Add(cliente);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Cliente> ObtenerClientes()
        {
            return _context.Cliente.ToList();
        }

        public void BuscarCliente (string cliente, DataGridView dg)
        {
            var clientes = _context.Cliente.
                Where
                (c => EF.Functions.Like(c.Nombre, $"%{cliente}%")).
                ToList();
            dg.DataSource = clientes;
        }

        public string ContarCLientes()
        {
           int contador =  _context.Cliente.Count();
            return $"Clientes registrados: {contador}";
        }
    }
}

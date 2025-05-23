

namespace BancoSimple2M5.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Identificación { get; set; }

        public List<Cuenta> Cuentas { get; set; } = new List<Cuenta>();

    }
}

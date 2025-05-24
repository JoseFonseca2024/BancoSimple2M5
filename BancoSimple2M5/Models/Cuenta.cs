namespace BancoSimple2M5.Models
{
    public class Cuenta
    {
        public int CuentaID { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }
        public bool Activa { get; set; } = true;
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }
    }
}

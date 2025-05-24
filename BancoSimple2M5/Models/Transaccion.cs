using System.ComponentModel.DataAnnotations;

namespace BancoSimple2M5.Models
{
    public class Transaccion
    {
        [Key] public int TransacciónID { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Descripción { get; set; }
        public int? CuentaOrigenId { get; set; }
        public int? CuentaDestinoId { get; set; }
    }
}

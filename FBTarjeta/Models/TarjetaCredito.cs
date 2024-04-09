using System.ComponentModel.DataAnnotations;

namespace FBTarjeta.Models
{
    public class TarjetaCredito
    {
        public int Id { get; set; }
        
        public required String Titular { get; set; }
        
        public required string NumeroTarjeta { get; set; }
        
        public required string FechaExpiracion { get; set; }
        
        public required string cvv { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerMecanicoAPI.Models
{
    [Table("vehiculo")]
    public class Vehiculo
    {
        [Key]
        [Column("id_vehiculo")]
        public int IdVehiculo { get; set; }

        [Required]
        [Column("marca")]
        [StringLength(50)]
        public string Marca { get; set; }

        [Required]
        [Column("modelo")]
        [StringLength(50)]
        public string Modelo { get; set; }

        [Required]
        [Column("anio")]
        public int Anio { get; set; }

        [Required]
        [Column("patente")]
        [StringLength(10)]
        public string Patente { get; set; }

        [Required]
        [Column("id_cliente")]
        public int IdCliente { get; set; }
    }
}

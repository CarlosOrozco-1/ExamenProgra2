namespace TallerAPI.Models
{
    public class Repuesto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }          // Nombre del repuesto
        public string Descripcion { get; set; }     // Descripción breve
        public int CantidadDisponible { get; set; } // Stock disponible
        public decimal Precio { get; set; }         // Precio unitario
        public bool Activo { get; set; }             // Indica si está activo o no
    }
}

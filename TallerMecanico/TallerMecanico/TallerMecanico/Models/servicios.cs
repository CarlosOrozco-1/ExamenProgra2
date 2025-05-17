namespace TallerAPI.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }       // Nombre del servicio (ej: cambio de aceite)
        public string Descripcion { get; set; }  // Descripción breve
        public decimal Precio { get; set; }      // Precio del servicio
        public bool Activo { get; set; }         // Indica si está disponible
    }
}

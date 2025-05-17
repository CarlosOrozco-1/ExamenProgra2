namespace TallerAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }         // Nombre completo
        public string Telefono { get; set; }       // Teléfono de contacto
        public string Email { get; set; }          // Correo electrónico
        public string Direccion { get; set; }      // Dirección física
        public string Ciudad { get; set; }         // Ciudad
        public string CodigoPostal { get; set; }   // Código postal
        public bool Activo { get; set; }           // Si está activo o no
    }
}

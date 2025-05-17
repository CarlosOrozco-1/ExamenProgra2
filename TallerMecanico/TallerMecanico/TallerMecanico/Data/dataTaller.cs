using TallerAPI.Models;

namespace TallerAPI.Data
{
    public static class TallerData
    {
        public static Taller InfoTaller = new Taller
        {
            Nombre = "Taller Mecánico El Rápido",
            Direccion = "Av. Principal 123, Ciudad",
            Telefono = "+54 9 11 1234 5678",
            Email = "contacto@tallerelrapido.com",
            Horario = "Lunes a Viernes 8:00 - 18:00, Sábados 9:00 - 14:00"
        };
    }
}

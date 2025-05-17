using System.Collections.Generic;
using TallerAPI.Models;

namespace TallerAPI.Data
{
    public static class MecanicoData
    {
        public static List<Mecanico> Mecanicos = new List<Mecanico>()
        {
            new Mecanico { Id = 1, Nombre = "Juan Perez", Especialidad = "Motor", Telefono = "555-1234", Email = "juan.perez@taller.com", Activo = true },
            new Mecanico { Id = 2, Nombre = "Maria Gomez", Especialidad = "Frenos", Telefono = "555-5678", Email = "maria.gomez@taller.com", Activo = true },
            new Mecanico { Id = 3, Nombre = "Carlos Ruiz", Especialidad = "Electricidad", Telefono = "555-9012", Email = "carlos.ruiz@taller.com", Activo = false },
            new Mecanico { Id = 4, Nombre = "Laura Fernandez", Especialidad = "Suspensión", Telefono = "555-3456", Email = "laura.fernandez@taller.com", Activo = true },
            new Mecanico { Id = 5, Nombre = "Pedro Morales", Especialidad = "Transmisión", Telefono = "555-7890", Email = "pedro.morales@taller.com", Activo = true }
        };
    }
}

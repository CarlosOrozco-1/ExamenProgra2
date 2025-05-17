using System.Collections.Generic;
using TallerAPI.Models;

namespace TallerAPI.Data
{
    public static class ServicioData
    {
        public static List<Servicio> Servicios = new List<Servicio>()
        {
            new Servicio { Id = 1, Nombre = "Cambio de Aceite", Descripcion = "Cambio de aceite y filtro", Precio = 250.00m, Activo = true },
            new Servicio { Id = 2, Nombre = "Alineación y Balanceo", Descripcion = "Alineación y balanceo de las ruedas", Precio = 400.00m, Activo = true },
            new Servicio { Id = 3, Nombre = "Revisión de Frenos", Descripcion = "Inspección y reparación de frenos", Precio = 300.00m, Activo = true },
            new Servicio { Id = 4, Nombre = "Cambio de Batería", Descripcion = "Cambio y revisión de batería", Precio = 800.00m, Activo = false },
            new Servicio { Id = 5, Nombre = "Servicio General", Descripcion = "Revisión general del vehículo", Precio = 1000.00m, Activo = true }
        };
    }
}

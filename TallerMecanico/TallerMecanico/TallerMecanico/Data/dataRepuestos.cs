using System.Collections.Generic;
using TallerAPI.Models;

namespace TallerAPI.Data
{
    public static class RepuestoData
    {
        public static List<Repuesto> Repuestos = new List<Repuesto>()
        {
            new Repuesto { Id = 1, Nombre = "Filtro de aceite", Descripcion = "Filtro para aceite de motor", CantidadDisponible = 15, Precio = 250.00m, Activo = true },
            new Repuesto { Id = 2, Nombre = "Bujía", Descripcion = "Bujía para motor gasolina", CantidadDisponible = 30, Precio = 120.00m, Activo = true },
            new Repuesto { Id = 3, Nombre = "Pastillas de freno", Descripcion = "Juego de pastillas delanteras", CantidadDisponible = 10, Precio = 500.00m, Activo = true },
            new Repuesto { Id = 4, Nombre = "Correa de distribución", Descripcion = "Correa para motor 1.6L", CantidadDisponible = 7, Precio = 800.00m, Activo = false },
            new Repuesto { Id = 5, Nombre = "Aceite motor 5W-30", Descripcion = "Aceite sintético para motor", CantidadDisponible = 50, Precio = 350.00m, Activo = true }
        };
    }
}

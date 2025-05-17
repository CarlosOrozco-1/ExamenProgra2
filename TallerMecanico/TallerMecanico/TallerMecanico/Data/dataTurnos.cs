using System;
using System.Collections.Generic;
using TallerAPI.Models;

namespace TallerAPI.Data
{
    public static class TurnoData
    {
        public static List<Turno> Turnos = new List<Turno>()
        {
            new Turno { Id = 1, ClienteId = 1, VehiculoId = 1, MecanicoId = 2, FechaHora = DateTime.Now.AddDays(1).AddHours(9), Estado = "Pendiente", Observaciones = "Revisión general" },
            new Turno { Id = 2, ClienteId = 2, VehiculoId = 2, MecanicoId = 1, FechaHora = DateTime.Now.AddDays(2).AddHours(11), Estado = "Confirmado", Observaciones = "Cambio de aceite" },
            new Turno { Id = 3, ClienteId = 3, VehiculoId = 3, MecanicoId = 3, FechaHora = DateTime.Now.AddDays(1).AddHours(14), Estado = "Cancelado", Observaciones = "Cliente canceló" },
            new Turno { Id = 4, ClienteId = 4, VehiculoId = 4, MecanicoId = 1, FechaHora = DateTime.Now.AddDays(3).AddHours(10), Estado = "Pendiente", Observaciones = "" },
            new Turno { Id = 5, ClienteId = 5, VehiculoId = 5, MecanicoId = 2, FechaHora = DateTime.Now.AddDays(4).AddHours(15), Estado = "Confirmado", Observaciones = "Alineación" }
        };
    }
}

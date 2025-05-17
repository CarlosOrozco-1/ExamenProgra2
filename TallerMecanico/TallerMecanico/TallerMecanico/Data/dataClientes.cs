using System.Collections.Generic;
using TallerAPI.Models;

namespace TallerAPI.Data
{
    public static class ClienteData
    {
        public static List<Cliente> Clientes = new List<Cliente>()
        {
            new Cliente { Id = 1, Nombre = "Ana López", Telefono = "555-1111", Email = "ana.lopez@cliente.com", Direccion = "Av. Reforma 123", Ciudad = "Ciudad A", CodigoPostal = "01010", Activo = true },
            new Cliente { Id = 2, Nombre = "Luis Martínez", Telefono = "555-2222", Email = "luis.martinez@cliente.com", Direccion = "Calle Falsa 456", Ciudad = "Ciudad B", CodigoPostal = "02020", Activo = true },
            new Cliente { Id = 3, Nombre = "Carla Sánchez", Telefono = "555-3333", Email = "carla.sanchez@cliente.com", Direccion = "Boulevard Central 789", Ciudad = "Ciudad C", CodigoPostal = "03030", Activo = false },
            new Cliente { Id = 4, Nombre = "Miguel Torres", Telefono = "555-4444", Email = "miguel.torres@cliente.com", Direccion = "Paseo de la Reforma 101", Ciudad = "Ciudad D", CodigoPostal = "04040", Activo = true },
            new Cliente { Id = 5, Nombre = "Sofia Reyes", Telefono = "555-5555", Email = "sofia.reyes@cliente.com", Direccion = "Av. Siempre Viva 202", Ciudad = "Ciudad E", CodigoPostal = "05050", Activo = true }
        };
    }
}

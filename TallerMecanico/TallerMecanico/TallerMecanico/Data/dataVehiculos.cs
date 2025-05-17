using System.Collections.Generic;
using TallerMecanicoAPI.Models;

namespace TallerMecanicoAPI.Data
{
    public static class VehiculoRepository
    {
        private static List<Vehiculo> vehiculos = new List<Vehiculo>
        {
            new Vehiculo { IdVehiculo = 1, Marca = "Toyota", Modelo = "Corolla", Anio = 2015, Patente = "ABC123", IdCliente = 1 },
            new Vehiculo { IdVehiculo = 2, Marca = "Ford", Modelo = "Focus", Anio = 2018, Patente = "DEF456", IdCliente = 2 },
            new Vehiculo { IdVehiculo = 3, Marca = "Chevrolet", Modelo = "Cruze", Anio = 2020, Patente = "GHI789", IdCliente = 3 },
            new Vehiculo { IdVehiculo = 4, Marca = "Volkswagen", Modelo = "Golf", Anio = 2017, Patente = "JKL321", IdCliente = 4 },
            new Vehiculo { IdVehiculo = 5, Marca = "Nissan", Modelo = "Sentra", Anio = 2019, Patente = "MNO654", IdCliente = 5 }
        };

        public static List<Vehiculo> GetVehiculos()
        {
            return vehiculos;
        }

        public static Vehiculo GetVehiculoById(int id)
        {
            return vehiculos.Find(v => v.IdVehiculo == id);
        }

        public static void AddVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }

        public static void DeleteVehiculo(int id)
        {
            var vehiculo = GetVehiculoById(id);
            if (vehiculo != null)
                vehiculos.Remove(vehiculo);
        }
    }
}

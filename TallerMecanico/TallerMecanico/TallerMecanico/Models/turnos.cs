using System;

namespace TallerAPI.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }      // Referencia al cliente que pidió el turno
        public int VehiculoId { get; set; }     // Referencia al vehículo a atender
        public int MecanicoId { get; set; }     // Mecánico asignado
        public DateTime FechaHora { get; set; } // Fecha y hora del turno
        public string Estado { get; set; }      // Estado: Pendiente, Confirmado, Cancelado, Finalizado
        public string Observaciones { get; set; }  // Comentarios o notas adicionales
    }
}

using System;

namespace ParkinLot.App.Dominio
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public EspacioParqueadero EspacioParqueadero { get; set; }
        
    }
}
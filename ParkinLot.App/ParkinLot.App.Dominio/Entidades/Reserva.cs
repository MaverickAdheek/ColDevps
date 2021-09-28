using System;
using ParkinLot.App.Dominio;

namespace parkinLot.App.Dominio
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public EspacioParquedero EspacioParquedero { get; set; }
        
    }
}
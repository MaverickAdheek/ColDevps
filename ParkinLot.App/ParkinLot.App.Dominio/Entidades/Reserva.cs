using System;

namespace parkinLot.App.Dominio
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        //faltan las asociaciones de vehiculo y espacio.
    }
}
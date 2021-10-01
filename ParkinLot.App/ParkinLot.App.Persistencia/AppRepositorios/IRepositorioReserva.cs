using System.Collections.Generic;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia.AppRepositorios
{
    public interface IRepositorioReserva
    {
        IEnumerable<Reserva> GetAllReservas();
        Reserva GetReserva(int idReserva);
        Reserva AddReserva(Reserva reserva);
        Reserva UpdateReserva(Reserva reserva);
        void DeleteReserva(int idReserva);
    }
}
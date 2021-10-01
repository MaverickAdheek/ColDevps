using System.Collections.Generic;
using System.Linq;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia.AppRepositorios
{
    public class RepositorioReserva
    {
        private readonly AppContexto _appContexto; // Conexión con el contexto
        public RepositorioReserva(AppContexto appContext) // Constructor de este repositorio
        {
            this._appContexto = appContext;
        }

        public Reserva AddReserva(Reserva reserva)
        {
            var reservaNueva = _appContexto.Reservas.Add(reserva);
            _appContexto.SaveChanges();
            return reservaNueva.Entity;
        }

        public void DeleteReserva(int idReserva)
        {
            var reservaEncontrada = _appContexto.Reservas.FirstOrDefault(r => r.Id == idReserva);
            if (reservaEncontrada != null)
            {
                _appContexto.Reservas.Remove(reservaEncontrada);
                _appContexto.SaveChanges();
            }
        }

        public Reserva GetReserva(int idReserva)
        {
            return _appContexto.Reservas.FirstOrDefault(r => r.Id == idReserva);
        }

        public IEnumerable<Reserva> GetAllReservas()
        {
            return _appContexto.Reservas;
        }

        public Reserva UpdateReserva(Reserva reserva)
        {
            var reservaEncontrada = _appContexto.Reservas.FirstOrDefault(r => r.Id == reserva.Id);
            if (reservaEncontrada != null)
            {
                reservaEncontrada.FechaReserva = reserva.FechaReserva;
                reservaEncontrada.HoraInicio = reserva.HoraInicio;
                reservaEncontrada.HoraFin = reserva.HoraFin;
                reservaEncontrada.Vehiculo = reserva.Vehiculo;
                reservaEncontrada.EspacioParqueadero = reserva.EspacioParqueadero;
                _appContexto.SaveChanges();
            }
            return reservaEncontrada;
        }
    }
}
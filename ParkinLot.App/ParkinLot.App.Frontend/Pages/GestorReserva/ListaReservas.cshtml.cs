using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ParkinLot.App.Dominio;
using ParkinLot.App.Persistencia;

namespace ParkinLot.App.Frontend.Pages
{
    public class ListaReservasModel : PageModel
    {
        private readonly IRepositorioReserva repositorioReserva;
        public IEnumerable<Reserva> Reservas {get; set; }

        public ListaReservasModel(IRepositorioReserva repositorioReserva)
        {
            this.repositorioReserva = repositorioReserva;
        }
        public void OnGet()
        {
            Reservas = repositorioReserva.GetAllReservas();
        }
    }
}

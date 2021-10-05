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
    public class ListaEspaciosParqueaderoModel : PageModel
    {
        private readonly IRepositorioEspacioParqueadero repositorioEspacioParqueadero;
        public IEnumerable<EspacioParqueadero> EspaciosParqueadero {get; set; }

        public ListaEspaciosParqueaderoModel(IRepositorioEspacioParqueadero repositorioEspacioParqueadero)
        {
            this.repositorioEspacioParqueadero = repositorioEspacioParqueadero;
        }
        public void OnGet()
        {
            EspaciosParqueadero = repositorioEspacioParqueadero.GetAllEspaciosParqueadero();
        }
    }
}

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
    public class EliminarEspacioParqueaderoModel : PageModel
    {
        private readonly IRepositorioEspacioParqueadero repositorioEspacioParqueadero;
        public EspacioParqueadero espacioParqueadero { get; set; }
        public EliminarEspacioParqueaderoModel (IRepositorioEspacioParqueadero repositorioEspacioParqueadero)
        {
            this.repositorioEspacioParqueadero = repositorioEspacioParqueadero;
        }
        public void OnGet(int Id)
        {
            espacioParqueadero = repositorioEspacioParqueadero.GetEspacioParqueadero(Id);
        }
        public IActionResult OnPost(EspacioParqueadero espacioParqueadero)
        {
            try {
                repositorioEspacioParqueadero.DeleteEspacioParqueadero(espacioParqueadero.Id);
                return RedirectToPage("./ListaEspaciosParqueadero");
            }
            catch {
                return RedirectToPage("../Error");
            }
        }
    }
}

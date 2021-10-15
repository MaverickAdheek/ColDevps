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
    public class AgregarEspacioParqueaderoModel : PageModel
    {
        private readonly IRepositorioEspacioParqueadero repositorioEspacioParqueadero;
        public EspacioParqueadero espacioParqueadero { get; set; }

        public AgregarEspacioParqueaderoModel(IRepositorioEspacioParqueadero repositorioEspacioParqueadero) 
        {
            this.repositorioEspacioParqueadero = repositorioEspacioParqueadero;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(EspacioParqueadero espacioParqueadero)
        {
            try {
            repositorioEspacioParqueadero.AddEspacioParqueadero(espacioParqueadero);
            return RedirectToPage("./ListaEspaciosParqueadero");
            }
            catch {
                return RedirectToPage("../Error");
            }
        }
    }
}

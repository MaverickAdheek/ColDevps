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
    public class AgregarGerenteModel : PageModel
    {
        private readonly IRepositorioGerente repositorioGerente;
        public Gerente Gerente { get; set; }

        // Constructor
        public AgregarGerenteModel(IRepositorioGerente repositorioGerente)
        {
            this.repositorioGerente = repositorioGerente;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(Gerente gerente){
            try {
                repositorioGerente.AddGerente(gerente);
                return RedirectToPage("./ListaGerentes");
            }
            catch {
                return RedirectToPage("../Error");
            }
        }
    }
}

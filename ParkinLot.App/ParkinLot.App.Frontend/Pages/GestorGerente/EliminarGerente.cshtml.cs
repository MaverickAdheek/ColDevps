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
    public class EliminarGerenteModel : PageModel
    {
        private readonly IRepositorioGerente repositorioGerente;
        public Gerente Gerente { get; set; }

        public EliminarGerenteModel(IRepositorioGerente repositorioGerente)
        {
            this.repositorioGerente = repositorioGerente;
        }
        public void OnGet(string codigoEmpleado)
        {
            Gerente = repositorioGerente.GetGerente(codigoEmpleado);
        }

        public IActionResult OnPost(Gerente gerente)
        {
            try {
                repositorioGerente.DeleteGerente(gerente.CodigoEmpleado);
                return RedirectToPage("./ListaGerentes");
            }
            catch {
                return RedirectToPage("../Error");
            }
        }
    }
}

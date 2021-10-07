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
    public class EditarGerenteModel : PageModel
    {
        private readonly IRepositorioGerente repositorioGerente;
        public Gerente Gerente { get; set; }

        public EditarGerenteModel(IRepositorioGerente repositorioGerente)
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
                repositorioGerente.UpdateGerente(gerente);
                return RedirectToPage("./ListaGerentes");
            }
            catch {
                return RedirectToPage("../Error");
            }
        }
    }
}

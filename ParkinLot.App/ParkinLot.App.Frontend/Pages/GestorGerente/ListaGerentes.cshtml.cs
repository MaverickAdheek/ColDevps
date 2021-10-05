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
    public class ListaGerentesModel : PageModel
    {
        private readonly IRepositorioGerente repositorioGerente;
        public IEnumerable<Gerente> Gerentes {get; set; }

        public ListaGerentesModel(IRepositorioGerente repositorioGerente)
        {
            this.repositorioGerente = repositorioGerente;
        }
        public void OnGet()
        {
            Gerentes = repositorioGerente.GetAllGerentes();
        }
    }
}

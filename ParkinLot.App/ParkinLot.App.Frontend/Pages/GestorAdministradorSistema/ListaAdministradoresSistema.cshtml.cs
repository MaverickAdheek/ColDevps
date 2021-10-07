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
    public class ListaAdministradoresSistemaModel : PageModel
    {
        private readonly IRepositorioAdministradorSistema repositorioAdministradorSistema;
        public IEnumerable<AdministradorSistema> AdministradoresSistema { get; set; }

        // Constructor
        public ListaAdministradoresSistemaModel(IRepositorioAdministradorSistema repositorioAdministradorSistema)
        {
            this.repositorioAdministradorSistema = repositorioAdministradorSistema;
        }
        public void OnGet()
        {
            AdministradoresSistema = repositorioAdministradorSistema.GetAllAdministradoresSistema();
        }
    }
}

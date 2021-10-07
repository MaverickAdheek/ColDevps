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
    public class EliminarAdministradorSistemaModel : PageModel
    {
        private readonly IRepositorioAdministradorSistema repositorioAdministradorSistema;
        public AdministradorSistema AdministradorSistema { get; set; }

        // Constructor
        public EliminarAdministradorSistemaModel(IRepositorioAdministradorSistema repositorioAdministradorSistema)
        {
            this.repositorioAdministradorSistema = repositorioAdministradorSistema;
        }
        public void OnGet(string codigoEmpleado)
        {
            AdministradorSistema = repositorioAdministradorSistema.GetAdministradorSistema(codigoEmpleado);
        }

        public IActionResult OnPost(AdministradorSistema administradorSistema)
        {
            try {
                repositorioAdministradorSistema.DeleteAdministradorSistema(administradorSistema.CodigoEmpleado);
                return RedirectToPage("./ListaAdministradoresSistema");
            }
            catch {
                return RedirectToPage("../Error");
            }
        }
    }
}

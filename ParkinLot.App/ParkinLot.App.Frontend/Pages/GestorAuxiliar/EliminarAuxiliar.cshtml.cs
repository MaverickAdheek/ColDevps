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
    public class EliminarAuxiliarModel : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        public Auxiliar Auxiliar { get; set; }

        // Constructor
        public EliminarAuxiliarModel(IRepositorioAuxiliar repositorioAuxiliar)
        {
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public void OnGet(string codigoEmpleado)
        {
            Auxiliar = repositorioAuxiliar.GetAuxiliar(codigoEmpleado);
        }

        public IActionResult OnPost(Auxiliar auxiliar)
        {
            try {
                repositorioAuxiliar.DeleteAuxiliar(auxiliar.CodigoEmpleado);
                return RedirectToPage("./ListaAuxiliares");
            }
            catch {
                return RedirectToPage("../Error");
            }
        }
    }
}

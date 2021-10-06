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
    public class EditarAuxiliarModel : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        public Auxiliar Auxiliar { get; set; }

        // Constructor
        public EditarAuxiliarModel(IRepositorioAuxiliar repositorioAuxiliar)
        {
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public void OnGet(string codigoEmpleado) // Al editar al auxiliar se recibe como argumento el documento del auxiliar
        {
            Auxiliar = repositorioAuxiliar.GetAuxiliar(codigoEmpleado);
        }

        public IActionResult OnPost(Auxiliar auxiliar)
        {
            try {
            repositorioAuxiliar.UpdateAuxiliar(auxiliar);
            return RedirectToPage("./ListaAuxiliares");
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return RedirectToPage("../Error");
            }
        }
    }
}

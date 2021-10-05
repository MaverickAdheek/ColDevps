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
    public class AgregarAuxiliarModel : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar; // Conexión con el repositorio
        public Auxiliar Auxiliar { get; set; } // Propiedad en la que se guardará el Auxiliare agregado

        // Constructor
        public AgregarAuxiliarModel(IRepositorioAuxiliar repositorioAuxiliar)
        {
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public void OnGet()
        {
        }
    }
}

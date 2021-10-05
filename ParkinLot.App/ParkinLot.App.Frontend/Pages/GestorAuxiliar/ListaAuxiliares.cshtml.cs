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
    public class ListaAuxiliaresModel : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar; // Conexión con el repositorio
        public IEnumerable<Auxiliar> Auxiliares {get; set; } // Propiedad en la que guardar la lista de auxiliares

        // Constructor
        public ListaAuxiliaresModel(IRepositorioAuxiliar repositorioAuxiliar)
        {
            this.repositorioAuxiliar = repositorioAuxiliar;
        }

        public void OnGet()
        {
            Auxiliares = repositorioAuxiliar.GetAllAuxiliares(); // Llamado al método del RepositorioAuxiliar que retorna una lista de auxiliares
        }
    }
}

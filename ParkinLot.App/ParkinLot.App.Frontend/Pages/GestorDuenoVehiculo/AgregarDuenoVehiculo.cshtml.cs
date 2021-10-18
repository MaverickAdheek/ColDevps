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
    public class AgregarDuenoVehiculoModel : PageModel
    {
    private readonly IRepositorioDuenoVehiculo repositorioDuenoVehiculo; // Conexión con el repositorio
        public DuenoVehiculo DuenoVehiculo { get; set; } // Propiedad en la que se guardará el DuenoVehiculo agregado

        // Constructor
        public AgregarDuenoVehiculoModel(IRepositorioDuenoVehiculo repositorioDuenoVehiculo)
        {
            this.repositorioDuenoVehiculo = repositorioDuenoVehiculo;
        }
        public void OnGet()
        {
        }
         public IActionResult OnPost(DuenoVehiculo duenoVehiculo)
        {
            try {
            repositorioDuenoVehiculo.AddDuenoVehiculo(duenoVehiculo);
            return RedirectToPage("./ListaDuenosVehiculos");
            }
            catch {
                return RedirectToPage("../Error");
            }
        }
    }
}

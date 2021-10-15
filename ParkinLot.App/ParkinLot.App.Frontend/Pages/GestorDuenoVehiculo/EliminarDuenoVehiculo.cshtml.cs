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
    public class EliminarDuenoVehiculoModel : PageModel
    {
        private readonly IRepositorioDuenoVehiculo repositorioDuenoVehiculo;
        public DuenoVehiculo DuenoVehiculo { get; set; }

        // Constructor
        public EliminarDuenoVehiculoModel(IRepositorioDuenoVehiculo repositorioDuenoVehiculo)
        {
            this.repositorioDuenoVehiculo = repositorioDuenoVehiculo;
        }
        public void OnGet(string documento)
        {
            DuenoVehiculo = repositorioDuenoVehiculo.GetDuenoVehiculo(documento);
        }
        public IActionResult OnPost(DuenoVehiculo DuenoVehiculo)
        {
            try {
                repositorioDuenoVehiculo.DeleteDuenoVehiculo(DuenoVehiculo.Documento);
                return RedirectToPage("./ListaDuenosVehiculos");
            }
            catch {
                return RedirectToPage("../Error");
            }
        }
    }
}

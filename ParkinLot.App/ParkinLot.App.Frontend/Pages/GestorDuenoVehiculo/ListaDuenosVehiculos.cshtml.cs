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
    public class ListaDuenosVehiculosModel : PageModel
    {
        private readonly IRepositorioDuenoVehiculo repositorioDuenoVehiculo;
        public IEnumerable<DuenoVehiculo> DuenosVehiculos {get; set; }

        public ListaDuenosVehiculosModel(IRepositorioDuenoVehiculo repositorioDuenoVehiculo)
        {
            this.repositorioDuenoVehiculo = repositorioDuenoVehiculo;
        }
        public void OnGet()
        {
            DuenosVehiculos = repositorioDuenoVehiculo.GetAllDuenosVehiculos();
        }
    }
}

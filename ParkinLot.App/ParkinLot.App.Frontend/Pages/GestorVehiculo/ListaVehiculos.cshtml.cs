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
    public class ListaVehiculosModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo;
        public IEnumerable<Vehiculo> Vehiculos {get; set; }

        public ListaVehiculosModel(IRepositorioVehiculo repositorioVehiculo)
        {
            this.repositorioVehiculo = repositorioVehiculo;
        }

        public void OnGet()
        {
            Vehiculos = repositorioVehiculo.GetAllVehiculos();
        }
    }
}

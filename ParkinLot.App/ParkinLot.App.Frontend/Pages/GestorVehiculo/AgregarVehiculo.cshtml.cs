using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ParkinLot.App.Dominio;
using ParkinLot.App.Persistencia;

namespace ParkinLot.App.Frontend.Pages
{
    
    public class AgregarVehiculoModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo;
        private readonly IRepositorioDuenoVehiculo repositorioDuenoVehiculo;
        
        public SelectList duenoVehiculo { get; set; }
        public AgregarVehiculoModel(IRepositorioVehiculo repositorioVehiculo, IRepositorioDuenoVehiculo repositorioDuenoVehiculo)
        {
            this.repositorioVehiculo = repositorioVehiculo;
            this.repositorioDuenoVehiculo = repositorioDuenoVehiculo;
            
            //duenoVehiculo =  new SelectList(repositorioDuenoVehiculo.GetAllDuenosVehiculos(),nameof(duenoVehiculo.Id),nameof(duenoVehiculo.Nombres));

        }
        public void OnGet()
        {
        }
    }
}


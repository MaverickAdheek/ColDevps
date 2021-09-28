using System;
using System.Collections.Generic;

namespace ParkinLot.App.Dominio
{
    public class DuenoVehiculo: Persona
    {
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public List<Vehiculo> Vehiculos { get; set; }
        
    }
}
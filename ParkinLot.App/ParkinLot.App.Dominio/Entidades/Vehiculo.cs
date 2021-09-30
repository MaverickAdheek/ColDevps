using System;

namespace ParkinLot.App.Dominio
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Placa { get; set; }
        public string Defectos { get; set; }
        public TipoVehiculo TipoVehiculo { get; set; }
        public DuenoVehiculo DuenoVehiculo { get; set; } // Se crea una propiedad DuenoVehiculo para poder hacer la conexión entre tablas
    }
}
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
    }
}
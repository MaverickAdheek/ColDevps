using System;

namespace ParkinLot.App.Dominio
{
    public abstract class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Place { get; set; }
        public string Defectos { get; set; }
    }
}
using System;

namespace ParkinLot.App.Dominio
{
    public class EspacioParqueadero
    {
        public int Id { get; set; }
        public TipoEspacio TipoEspacio { get; set; }
        public bool Ocupado { get; set; }
        
    }
}
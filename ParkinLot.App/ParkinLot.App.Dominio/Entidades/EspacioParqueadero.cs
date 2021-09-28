using System;

namespace parkinLot.App.Dominio
{
    public class EspacioParquedero
    {
        public int Id { get; set; }
        public TipoEspacio TipoEspacio { get; set; }
        public bool Ocupado { get; set; }
        
    }
}
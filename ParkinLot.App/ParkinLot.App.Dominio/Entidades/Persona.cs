using System;

namespace parkinLot.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Documento { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}
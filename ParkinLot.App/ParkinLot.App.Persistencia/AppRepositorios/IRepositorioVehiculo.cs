using System.Collections.Generic;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVehiculo
    {
        IEnumerable<Vehiculo> GetAllVehiculos();
        Vehiculo GetVehiculo(string placa);
        Vehiculo AddVehiculo(Vehiculo vehiculo);
        Vehiculo UpdateVehiculo(Vehiculo vehiculo);
        void DeleteVehiculo(string placa);
    }
}
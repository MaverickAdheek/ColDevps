using System.Collections.Generic;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia
{
    public interface IRepositorioDuenoVehiculo
    {
        IEnumerable<DuenoVehiculo> GetAllDuenosVehiculos();
        DuenoVehiculo GetDuenoVehiculo(string documento);
        DuenoVehiculo AddDuenoVehiculo(DuenoVehiculo duenoVehiculo);
        DuenoVehiculo UpdateDuenoVehiculo(DuenoVehiculo duenoVehiculo);
        void DeleteDuenoVehiculo(string documento);
    }
}
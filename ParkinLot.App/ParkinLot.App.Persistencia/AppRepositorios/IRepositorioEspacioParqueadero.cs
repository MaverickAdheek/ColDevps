using System.Collections.Generic;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia
{
    public interface IRepositorioEspacioParqueadero
    {
        IEnumerable<EspacioParqueadero> GetAllEspaciosParqueadero();
        EspacioParqueadero GetEspacioParqueadero(int idEspacioParqueadero);
        EspacioParqueadero AddEspacioParqueadero(EspacioParqueadero espacioParqueadero);
        EspacioParqueadero UpdateEspacioParqueadero(EspacioParqueadero espacioParqueadero);
        void DeleteEspacioParqueadero(int espacioParqueadero);
    }
}
using System.Collections.Generic;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia
{
    public interface IRepositorioAuxiliar
    {
        IEnumerable<Auxiliar> GetAllAuxiliares();
        Auxiliar GetAuxiliar(string codigoEmpleado);
        Auxiliar AddAuxiliar(Auxiliar auxiliar);
        Auxiliar UpdateAuxiliar(Auxiliar auxiliar);
        void DeleteAuxiliar(string codigoEmpleado);
    }
}
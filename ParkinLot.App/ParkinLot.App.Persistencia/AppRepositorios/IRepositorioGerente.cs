using System.Collections.Generic;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia.AppRepositorios
{
    public interface IRepositorioGerente
    {
        IEnumerable<Gerente> GetAllGerentes();
        Gerente GetGerente(string codigoEmpleado);
        Gerente AddGerente(Gerente gerente);
        Gerente UpdateGerente(Gerente gerente);
        void DeleteGerente(string codigoEmpleado);
    }
}
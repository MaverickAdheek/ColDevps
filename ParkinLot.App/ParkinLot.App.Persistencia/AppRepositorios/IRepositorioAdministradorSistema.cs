using System.Collections.Generic;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia
{
    public interface IRepositorioAdministradorSistema
    {
        IEnumerable<AdministradorSistema> GetAllAdministradoresSistema();
        AdministradorSistema GetAdministradorSistema(string codigoEmpleado);
        AdministradorSistema AddAdministradorSistema(AdministradorSistema administradorSistema);
        AdministradorSistema UpdateAdministradorSistema(AdministradorSistema administradorSistema);
        void DeleteAdministradorSistema(string codigoEmpleado);
    }
}
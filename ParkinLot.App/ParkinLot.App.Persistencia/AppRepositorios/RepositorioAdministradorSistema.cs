using System.Collections.Generic;
using System.Linq;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia
{
    public class RepositorioAdministradorSistema : IRepositorioAdministradorSistema
    {

        private readonly AppContexto _appContexto; // Conexión con el contexto
        public RepositorioAdministradorSistema(AppContexto appContext) // Constructor de este repositorio
        {
            this._appContexto = appContext;
        }

        public AdministradorSistema AddAdministradorSistema(AdministradorSistema administradorSistema)
        {
            var administradorSistemaNuevo = _appContexto.AdministradoresSistema.Add(administradorSistema);
            _appContexto.SaveChanges();
            return administradorSistemaNuevo.Entity;
        }

        public void DeleteAdministradorSistema(string codigoEmpleado)
        {
            var administradorSistemaEncontrado = _appContexto.AdministradoresSistema.FirstOrDefault(aS => aS.CodigoEmpleado == codigoEmpleado);
            if (administradorSistemaEncontrado != null)
            {
                _appContexto.AdministradoresSistema.Remove(administradorSistemaEncontrado);
                _appContexto.SaveChanges();
            }
        }

        public AdministradorSistema GetAdministradorSistema(string codigoEmpleado)
        {
            return _appContexto.AdministradoresSistema.FirstOrDefault(aS => aS.CodigoEmpleado == codigoEmpleado);
        }

        public IEnumerable<AdministradorSistema> GetAllAdministradoresSistema()
        {
            return _appContexto.AdministradoresSistema;
        }

        public AdministradorSistema UpdateAdministradorSistema(AdministradorSistema administradorSistema)
        {
            var administradorSistemaEncontrado = _appContexto.AdministradoresSistema.FirstOrDefault(aS => aS.CodigoEmpleado == administradorSistema.CodigoEmpleado);
            if (administradorSistemaEncontrado != null)
            {
                administradorSistemaEncontrado.Nombres = administradorSistema.Nombres;
                administradorSistemaEncontrado.Apellidos = administradorSistema.Apellidos;
                administradorSistemaEncontrado.Documento = administradorSistema.Documento;
                administradorSistemaEncontrado.Usuario = administradorSistema.Usuario;
                administradorSistemaEncontrado.Contrasena = administradorSistema.Contrasena;
                administradorSistemaEncontrado.CodigoEmpleado = administradorSistema.CodigoEmpleado;
                _appContexto.SaveChanges();
            }
            return administradorSistemaEncontrado;
        }
    }
}
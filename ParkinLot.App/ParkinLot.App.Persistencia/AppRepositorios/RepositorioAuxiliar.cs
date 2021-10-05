using System.Collections.Generic;
using System.Linq;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia
{
    public class RepositorioAuxiliar : IRepositorioAuxiliar
    {
        private readonly AppContexto _appContexto; // Conexión con el contexto
        public RepositorioAuxiliar(AppContexto appContext) // Constructor de este repositorio
        {
            this._appContexto = appContext;
        }

        public Auxiliar AddAuxiliar(Auxiliar auxiliar)
        {
            try{
            var auxiliarNuevo = _appContexto.Auxiliares.Add(auxiliar);
            _appContexto.SaveChanges();
            return auxiliarNuevo.Entity;
            }
            catch{
                return null;
            }
        }

        public void DeleteAuxiliar(string codigoEmpleado)
        {
            var auxiliarEncontrado = _appContexto.Auxiliares.FirstOrDefault(a => a.CodigoEmpleado == codigoEmpleado);
            if (auxiliarEncontrado != null)
            {
                _appContexto.Auxiliares.Remove(auxiliarEncontrado);
                _appContexto.SaveChanges();
            }
        }

        public Auxiliar GetAuxiliar(string codigoEmpleado)
        {
            return _appContexto.Auxiliares.FirstOrDefault(a => a.CodigoEmpleado == codigoEmpleado);
        }

        public IEnumerable<Auxiliar> GetAllAuxiliares()
        {
            return _appContexto.Auxiliares;
        }

        public Auxiliar UpdateAuxiliar(Auxiliar auxiliar)
        {
            var auxiliarEncontrado = _appContexto.Auxiliares.FirstOrDefault(a => a.Id == auxiliar.Id);
            if (auxiliarEncontrado != null)
            {
                auxiliarEncontrado.Nombres = auxiliar.Nombres;
                auxiliarEncontrado.Apellidos = auxiliar.Apellidos;
                auxiliarEncontrado.Documento = auxiliar.Documento;
                auxiliarEncontrado.Usuario = auxiliar.Usuario;
                auxiliarEncontrado.Contrasena = auxiliar.Contrasena;
                auxiliarEncontrado.CodigoEmpleado = auxiliar.CodigoEmpleado;
                _appContexto.SaveChanges();
            }
            return auxiliarEncontrado;
        }
    }
}
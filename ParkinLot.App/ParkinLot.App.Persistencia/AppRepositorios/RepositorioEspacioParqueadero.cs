using System.Collections.Generic;
using System.Linq;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia
{
    public class RepositorioEspacioParqueadero : IRepositorioEspacioParqueadero
    {
        private readonly AppContexto _appContexto; // Conexión con el contexto
        public RepositorioEspacioParqueadero(AppContexto appContext) // Constructor de este repositorio
        {
            this._appContexto = appContext;
        }

        public EspacioParqueadero AddEspacioParqueadero(EspacioParqueadero espacioParqueadero)
        {
            var espacioParqueaderoNuevo = _appContexto.EspaciosParqueadero.Add(espacioParqueadero);
            _appContexto.SaveChanges();
            return espacioParqueaderoNuevo.Entity;
        }

        public void DeleteEspacioParqueadero(int idEspacioParqueadero)
        {
            var espacioParqueaderoEncontrado = _appContexto.EspaciosParqueadero.FirstOrDefault(ep => ep.Id == idEspacioParqueadero);
            if (espacioParqueaderoEncontrado != null)
            {
                _appContexto.EspaciosParqueadero.Remove(espacioParqueaderoEncontrado);
                _appContexto.SaveChanges();
            }
        }

        public EspacioParqueadero GetEspacioParqueadero(int idEspacioParqueadero)
        {
            return _appContexto.EspaciosParqueadero.FirstOrDefault(sp => sp.Id == idEspacioParqueadero);
        }

        public IEnumerable<EspacioParqueadero> GetAllEspaciosParqueadero()
        {
            return _appContexto.EspaciosParqueadero;
        }

        public EspacioParqueadero UpdateEspacioParqueadero(EspacioParqueadero espacioParqueadero)
        {
            var espacioParqueaderoEncontrado = _appContexto.EspaciosParqueadero.FirstOrDefault(sp => sp.Id == espacioParqueadero.Id);
            if (espacioParqueaderoEncontrado != null)
            {
                espacioParqueaderoEncontrado.TipoEspacio = espacioParqueadero.TipoEspacio;
                espacioParqueaderoEncontrado.Ocupado = espacioParqueadero.Ocupado;
                _appContexto.SaveChanges();
            }
            return espacioParqueaderoEncontrado;
        }
    }
}
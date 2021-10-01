using System.Collections.Generic;
using System.Linq;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia.AppRepositorios
{
    public class RepositorioDuenoVehiculo : IRepositorioDuenoVehiculo
    {
        private readonly AppContexto _appContexto; // Conexión con el contexto
        public RepositorioDuenoVehiculo(AppContexto appContext) // Constructor de este repositorio
        {
            this._appContexto = appContext;
        }

        public DuenoVehiculo AddDuenoVehiculo(DuenoVehiculo duenoVehiculo)
        {
            var duenoVehiculoNuevo = _appContexto.DuenosVehiculos.Add(duenoVehiculo);
            _appContexto.SaveChanges();
            return duenoVehiculoNuevo.Entity;
        }

        public void DeleteDuenoVehiculo(string documento)
        {
            var duenoVehiculoEncontrado = _appContexto.DuenosVehiculos.FirstOrDefault(dv => dv.Documento == documento);
            if (duenoVehiculoEncontrado != null)
            {
                _appContexto.DuenosVehiculos.Remove(duenoVehiculoEncontrado);
                _appContexto.SaveChanges();
            }
        }

        public DuenoVehiculo GetDuenoVehiculo(string documento)
        {
            return _appContexto.DuenosVehiculos.FirstOrDefault(dv => dv.Documento == documento);
        }

        public IEnumerable<DuenoVehiculo> GetAllDuenosVehiculos()
        {
            return _appContexto.DuenosVehiculos;
        }

        public DuenoVehiculo UpdateDuenoVehiculo(DuenoVehiculo duenoVehiculo)
        {
            var duenoVehiculoEncontrado = _appContexto.DuenosVehiculos.FirstOrDefault(dv => dv.Id == duenoVehiculo.Id);
            if (duenoVehiculoEncontrado != null)
            {
                duenoVehiculoEncontrado.Nombres = duenoVehiculo.Nombres;
                duenoVehiculoEncontrado.Apellidos = duenoVehiculo.Apellidos;
                duenoVehiculoEncontrado.Documento = duenoVehiculo.Documento;
                duenoVehiculoEncontrado.Usuario = duenoVehiculo.Usuario;
                duenoVehiculoEncontrado.Contrasena = duenoVehiculo.Contrasena;
                duenoVehiculoEncontrado.Direccion = duenoVehiculo.Direccion;
                duenoVehiculoEncontrado.Telefono = duenoVehiculo.Telefono;
                duenoVehiculoEncontrado.FechaNacimiento = duenoVehiculo.FechaNacimiento;
                _appContexto.SaveChanges();
            }
            return duenoVehiculoEncontrado;
        }
    }
}
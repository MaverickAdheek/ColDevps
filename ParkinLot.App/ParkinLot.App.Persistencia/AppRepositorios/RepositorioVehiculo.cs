using System.Collections.Generic;
using System.Linq;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia
{
    public class RepositorioVehiculo : IRepositorioVehiculo
    {
        private readonly AppContexto _appContexto; // Conexión con el contexto
        public RepositorioVehiculo(AppContexto appContext) // Constructor de este repositorio
        {
            this._appContexto = appContext;
        }

        public Vehiculo AddVehiculo(Vehiculo vehiculo)
        {
            var vehiculoNuevo = _appContexto.Vehiculos.Add(vehiculo);
            _appContexto.SaveChanges();
            return vehiculoNuevo.Entity;
        }

        public void DeleteVehiculo(string placa)
        {
            var vehiculoEncontrado = _appContexto.Vehiculos.FirstOrDefault(v => v.Placa == placa);
            if (vehiculoEncontrado != null)
            {
                _appContexto.Vehiculos.Remove(vehiculoEncontrado);
                _appContexto.SaveChanges();
            }
        }

        public Vehiculo GetVehiculo(string placa)
        {
            return _appContexto.Vehiculos.FirstOrDefault(v => v.Placa == placa);
        }

        public IEnumerable<Vehiculo> GetAllVehiculos()
        {
            return _appContexto.Vehiculos;
        }

        public Vehiculo UpdateVehiculo(Vehiculo vehiculo)
        {
            var vehiculoEncontrado = _appContexto.Vehiculos.FirstOrDefault(v => v.Id == vehiculo.Id);
            if (vehiculoEncontrado != null)
            {
                vehiculoEncontrado.Marca = vehiculo.Marca;
                vehiculoEncontrado.Modelo = vehiculo.Modelo;
                vehiculoEncontrado.Color = vehiculo.Color;
                vehiculoEncontrado.Placa = vehiculo.Placa;
                vehiculoEncontrado.Defectos = vehiculo.Defectos;
                vehiculoEncontrado.TipoVehiculo = vehiculo.TipoVehiculo;
                vehiculoEncontrado.DuenoVehiculo = vehiculo.DuenoVehiculo;
                _appContexto.SaveChanges();
            }
            return vehiculoEncontrado;
        }
    }
}
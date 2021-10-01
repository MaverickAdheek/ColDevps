using System.Collections.Generic;
using System.Linq;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia.AppRepositorios
{
    public class RepositorioGerente : IRepositorioGerente
    {
        private readonly AppContexto _appContexto; // Conexión con el contexto
        public RepositorioGerente(AppContexto appContext) // Constructor de este repositorio
        {
            this._appContexto = appContext;
        }

        public Gerente AddGerente(Gerente gerente)
        {
            var gerenteNuevo = _appContexto.Gerentes.Add(gerente);
            _appContexto.SaveChanges();
            return gerenteNuevo.Entity;
        }

        public void DeleteGerente(string codigoEmpleado)
        {
            var gerenteEncontrado = _appContexto.Gerentes.FirstOrDefault(g => g.CodigoEmpleado == codigoEmpleado);
            if (gerenteEncontrado != null)
            {
                _appContexto.Gerentes.Remove(gerenteEncontrado);
                _appContexto.SaveChanges();
            }
        }

        public Gerente GetGerente(string codigoEmpleado)
        {
            return _appContexto.Gerentes.FirstOrDefault(g => g.CodigoEmpleado == codigoEmpleado);
        }

        public IEnumerable<Gerente> GetAllGerentes()
        {
            return _appContexto.Gerentes;
        }

        public Gerente UpdateGerente(Gerente gerente)
        {
            var gerenteEncontrado = _appContexto.Gerentes.FirstOrDefault(g => g.Id == gerente.Id);
            if (gerenteEncontrado != null)
            {
                gerenteEncontrado.Nombres = gerente.Nombres;
                gerenteEncontrado.Apellidos = gerente.Apellidos;
                gerenteEncontrado.Documento = gerente.Documento;
                gerenteEncontrado.Usuario = gerente.Usuario;
                gerenteEncontrado.Contrasena = gerente.Contrasena;
                gerenteEncontrado.CodigoEmpleado = gerente.CodigoEmpleado;
                _appContexto.SaveChanges();
            }
            return gerenteEncontrado;
        }
    }
}
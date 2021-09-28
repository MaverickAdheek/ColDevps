using Microsoft.EntityFrameworkCore;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia
{
    public class AppContext : DbContext
    {
        // Creación de los DbSets para cada entidad
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Moto> Motos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<AdministradorSistema> AdministradoresSistema { get; set; }
        public DbSet<DuenhoVehiculo> DuenosVehiculos { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Auxiliar> Auxiliares { get; set; }
        public DbSet<Espacio> Espacios { get; set; }
        public DbSet<Parqueadero> Parqueaderos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<UsoEspacio> UsoEspacios { get; set; }

        /* Método para la configuración de la conexión con la base de datos. 
        La base de datos tiene el nombre de ParkinLot.Data */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.
                UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =ParkinLot.Data");
            }
        }
    }
}
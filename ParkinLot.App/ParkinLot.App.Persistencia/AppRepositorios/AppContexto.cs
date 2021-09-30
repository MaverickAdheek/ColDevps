using Microsoft.EntityFrameworkCore;
using ParkinLot.App.Dominio;

namespace ParkinLot.App.Persistencia
{
    public class AppContexto : DbContext
    {
        // Creación de los DbSets para cada entidad
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<AdministradorSistema> AdministradoresSistema { get; set; }
        public DbSet<DuenoVehiculo> DuenosVehiculos { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Auxiliar> Auxiliares { get; set; }
        public DbSet<EspacioParqueadero> EspaciosParqueadero { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

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

        // Este método permite que campos determinados dentro de la base de datos sean únicos
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Se hacen únicos los capos de CodigoEmpleado para AdministradorSistema, Gerente y Auxiliar
            builder.Entity<AdministradorSistema>()
                .HasIndex(u => u.CodigoEmpleado)
                .IsUnique();
            builder.Entity<Gerente>()
                .HasIndex(u => u.CodigoEmpleado)
                .IsUnique();
            builder.Entity<Auxiliar>()
                .HasIndex(u => u.CodigoEmpleado)
                .IsUnique();
        }
    }
}
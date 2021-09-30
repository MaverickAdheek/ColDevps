using System;
using ParkinLot.App.Dominio;
using ParkinLot.App.Persistencia;

namespace ParkinLot.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            AppContexto _appContexto = new AppContexto(); // Se crea conexión con la base de datos a través del AppContexto

            Console.WriteLine("Ingrese 1 si desea agregar los datos: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                AdministradorSistema objAdministradorSistema = new AdministradorSistema()
                {
                    Nombres = "Leonardo",
                    Apellidos = "Morales Rodríguez",
                    Documento = "123456",
                    Usuario = "lemo12",
                    Contrasena = "qwe!@#",
                    CodigoEmpleado = "001"
                };
                _appContexto.Add(objAdministradorSistema);

                Gerente objGerente = new Gerente()
                {
                    Nombres = "Eduardo",
                    Apellidos = "Hernández",
                    Documento = "987654",
                    Usuario = "edHe98",
                    Contrasena = "poi*()",
                    CodigoEmpleado = "002"
                };
                _appContexto.Add(objGerente);

                Auxiliar objAuxiliar = new Auxiliar()
                {
                    Nombres = "César",
                    Apellidos = "Martínez",
                    Documento = "147852",
                    Usuario = "cema14",
                    Contrasena = "zxc#$%",
                    CodigoEmpleado = "003"
                };
                _appContexto.Add(objAuxiliar);

                DuenoVehiculo objDuenoVehiculo = new DuenoVehiculo()
                {
                    Nombres = "Wilmar",
                    Apellidos = "Arias",
                    Documento = "369258",
                    Usuario = "wiar36",
                    Contrasena = "mnb<>?",
                    Direccion = "Carrera 30 No 45-17",
                    Telefono = "302516",
                    FechaNacimiento = new DateTime(1990, 04, 12),
                };
                _appContexto.Add(objDuenoVehiculo);

                Vehiculo objVehiculo = new Vehiculo()
                {
                    Marca = "Chevrolet",
                    Modelo = "Blazer RS - 2020",
                    Color = "Rojo",
                    Placa = "BNM-145",
                    Defectos = "Ninguno",
                    TipoVehiculo = TipoVehiculo.Carro,
                    DuenoVehiculo = objDuenoVehiculo
                };
                _appContexto.Add(objVehiculo);

                EspacioParqueadero objEspacioParqueadero = new EspacioParqueadero()
                {
                    TipoEspacio = TipoEspacio.Carro,
                    Ocupado = false
                };
                _appContexto.Add(objEspacioParqueadero);

                Reserva objReserva = new Reserva()
                {
                    FechaReserva = new DateTime(2021, 09, 28),
                    HoraInicio = new DateTime(2021, 09, 29, 8, 0, 0),
                    HoraFin = new DateTime(2021, 09, 29, 17, 0, 0),
                    Vehiculo = objVehiculo,
                    EspacioParquedero = objEspacioParqueadero
                };
                _appContexto.Add(objReserva);
                _appContexto.SaveChanges();
            }
        }
    }
}

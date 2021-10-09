using System;
using ParkinLot.App.Dominio;
using ParkinLot.App.Persistencia;
<<<<<<< HEAD
//using ParkinLot.App.Persistencia.AppRepositorios;
=======
>>>>>>> eace1d9e3fbe02c4b220d5303466da979ca7bfa7

namespace ParkinLot.App.Consola
{
    class Program
    {
        // private static NombreIRepositorio _nombreRepositorio = new NombreRespositorio(new Persistencia.AppContexto());
        static void Main(string[] args)
        {
<<<<<<< HEAD
            AppContexto _appContexto = new AppContexto(); // Se crea conexión con la base de datos a través del AppContexto
=======
            // AppContexto _appContexto = new AppContexto(); // Se crea conexión con la base de datos a través del AppContexto
>>>>>>> eace1d9e3fbe02c4b220d5303466da979ca7bfa7

            int opcion = 0;
            while (opcion != -1)
            {
                Console.WriteLine("Seleccione una opción: ");
                Console.WriteLine("1. Ingrese un Auxiliar.");
                Console.WriteLine("2. Consulte un Auxiliar");
                Console.WriteLine("3. Escriba -1 para salir.");
                opcion = Convert.ToInt32(Console.ReadLine());

                IRepositorioAuxiliar _repoAuxiliar = new RepositorioAuxiliar(new AppContexto());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese los nombres del auxiliar:");
                        string nombres = Console.ReadLine();

                        Console.WriteLine("Ingreso los apellidos del auxiliar:");
                        string apellidos = Console.ReadLine();

                        Console.WriteLine("Ingrese el número de cédula del auxiliar:");
                        string documento = Console.ReadLine();

                        Console.WriteLine("Ingrese el usuario del auxiliar:");
                        string usuario = Console.ReadLine();

                        Console.WriteLine("Ingrese la contraseña del auxiliar:");
                        string contrasena = Console.ReadLine();

                        Console.WriteLine("Ingrese el código del empleado:");
                        string codigo = Console.ReadLine();

                        Auxiliar objAuxiliar = new Auxiliar()
                        {
                            Nombres = nombres,
                            Apellidos = apellidos,
                            Documento = documento,
                            Usuario = usuario,
                            Contrasena = contrasena,
                            CodigoEmpleado = codigo
                        };

                        var respuesta = _repoAuxiliar.AddAuxiliar(objAuxiliar);
                        if (respuesta == null)
                        {
                            Console.WriteLine("Ha intentado agregar un auxiliar con un código que ya existe.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el código del auxiliar que busca:");
                        string codigoBusqueda = Console.ReadLine();
                        var auxiliarEncontrado = _repoAuxiliar.GetAuxiliar(codigoBusqueda);
                        Console.WriteLine(auxiliarEncontrado.Nombres + " " + auxiliarEncontrado.CodigoEmpleado);
                        break;
                }

                /*AdministradorSistema objAdministradorSistema = new AdministradorSistema()
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
                    EspacioParqueadero = objEspacioParqueadero
                };
                _appContexto.Add(objReserva);
                _appContexto.SaveChanges();*/

            }
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkinLot.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EspaciosParqueadero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoEspacio = table.Column<int>(type: "int", nullable: false),
                    Ocupado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspaciosParqueadero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Usuario = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdministradorSistema_CodigoEmpleado = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Auxiliar_CodigoEmpleado = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CodigoEmpleado = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Placa = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Defectos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoVehiculo = table.Column<int>(type: "int", nullable: false),
                    DuenoVehiculoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Personas_DuenoVehiculoId",
                        column: x => x.DuenoVehiculoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaReserva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: true),
                    EspacioParqueaderoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservas_EspaciosParqueadero_EspacioParqueaderoId",
                        column: x => x.EspacioParqueaderoId,
                        principalTable: "EspaciosParqueadero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservas_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_AdministradorSistema_CodigoEmpleado",
                table: "Personas",
                column: "AdministradorSistema_CodigoEmpleado",
                unique: true,
                filter: "[AdministradorSistema_CodigoEmpleado] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Auxiliar_CodigoEmpleado",
                table: "Personas",
                column: "Auxiliar_CodigoEmpleado",
                unique: true,
                filter: "[Auxiliar_CodigoEmpleado] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_CodigoEmpleado",
                table: "Personas",
                column: "CodigoEmpleado",
                unique: true,
                filter: "[CodigoEmpleado] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Documento",
                table: "Personas",
                column: "Documento",
                unique: true,
                filter: "[Documento] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Usuario",
                table: "Personas",
                column: "Usuario",
                unique: true,
                filter: "[Usuario] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EspacioParqueaderoId",
                table: "Reservas",
                column: "EspacioParqueaderoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_VehiculoId",
                table: "Reservas",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_DuenoVehiculoId",
                table: "Vehiculos",
                column: "DuenoVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_Placa",
                table: "Vehiculos",
                column: "Placa",
                unique: true,
                filter: "[Placa] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "EspaciosParqueadero");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkinLot.App.Persistencia;

namespace ParkinLot.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210930000914_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ParkinLot.App.Dominio.EspacioParqueadero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ocupado")
                        .HasColumnType("bit");

                    b.Property<int>("TipoEspacio")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EspaciosParqueadero");
                });

            modelBuilder.Entity("ParkinLot.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("ParkinLot.App.Dominio.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EspacioParquederoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaReserva")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraInicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EspacioParquederoId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("ParkinLot.App.Dominio.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Defectos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DuenoVehiculoId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoVehiculo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DuenoVehiculoId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("ParkinLot.App.Dominio.AdministradorSistema", b =>
                {
                    b.HasBaseType("ParkinLot.App.Dominio.Persona");

                    b.Property<string>("CodigoEmpleado")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("AdministradorSistema_CodigoEmpleado");

                    b.HasIndex("CodigoEmpleado")
                        .IsUnique()
                        .HasFilter("[AdministradorSistema_CodigoEmpleado] IS NOT NULL");

                    b.HasDiscriminator().HasValue("AdministradorSistema");
                });

            modelBuilder.Entity("ParkinLot.App.Dominio.Auxiliar", b =>
                {
                    b.HasBaseType("ParkinLot.App.Dominio.Persona");

                    b.Property<string>("CodigoEmpleado")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Auxiliar_CodigoEmpleado");

                    b.HasIndex("CodigoEmpleado")
                        .IsUnique()
                        .HasFilter("[Auxiliar_CodigoEmpleado] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Auxiliar");
                });

            modelBuilder.Entity("ParkinLot.App.Dominio.DuenoVehiculo", b =>
                {
                    b.HasBaseType("ParkinLot.App.Dominio.Persona");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("DuenoVehiculo");
                });

            modelBuilder.Entity("ParkinLot.App.Dominio.Gerente", b =>
                {
                    b.HasBaseType("ParkinLot.App.Dominio.Persona");

                    b.Property<string>("CodigoEmpleado")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("CodigoEmpleado")
                        .IsUnique()
                        .HasFilter("[CodigoEmpleado] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Gerente");
                });

            modelBuilder.Entity("ParkinLot.App.Dominio.Reserva", b =>
                {
                    b.HasOne("ParkinLot.App.Dominio.EspacioParqueadero", "EspacioParquedero")
                        .WithMany()
                        .HasForeignKey("EspacioParquederoId");

                    b.HasOne("ParkinLot.App.Dominio.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("VehiculoId");

                    b.Navigation("EspacioParquedero");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("ParkinLot.App.Dominio.Vehiculo", b =>
                {
                    b.HasOne("ParkinLot.App.Dominio.DuenoVehiculo", null)
                        .WithMany("Vehiculos")
                        .HasForeignKey("DuenoVehiculoId");
                });

            modelBuilder.Entity("ParkinLot.App.Dominio.DuenoVehiculo", b =>
                {
                    b.Navigation("Vehiculos");
                });
#pragma warning restore 612, 618
        }
    }
}

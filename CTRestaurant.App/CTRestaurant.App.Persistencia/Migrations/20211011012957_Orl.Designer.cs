﻿// <auto-generated />
using System;
using CTRestaurant.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CTRestaurant.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211011012957_Orl")]
    partial class Orl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CTRestaurant.App.Dominio.Contagiado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FechaDiagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PeriodoAislamiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sintomas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contagiados");
                });

            modelBuilder.Entity("CTRestaurant.App.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<int>("estadoCovid")
                        .HasColumnType("int");

                    b.Property<int>("identificacion")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("CTRestaurant.App.Dominio.Restaurante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Aforo")
                        .HasColumnType("int");

                    b.Property<int>("CantidadMesas")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("PuestosPorMesa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Restaurante");
                });

            modelBuilder.Entity("CTRestaurant.App.Dominio.Turno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Clienteid")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioAsistencia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Menu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Clienteid");

                    b.ToTable("Turno");
                });

            modelBuilder.Entity("CTRestaurant.App.Dominio.Administrativo", b =>
                {
                    b.HasBaseType("CTRestaurant.App.Dominio.Persona");

                    b.Property<string>("Dependencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oficina")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Administrativo");
                });

            modelBuilder.Entity("CTRestaurant.App.Dominio.Estudiante", b =>
                {
                    b.HasBaseType("CTRestaurant.App.Dominio.Persona");

                    b.Property<string>("Programa")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("CTRestaurant.App.Dominio.PersonalAseo", b =>
                {
                    b.HasBaseType("CTRestaurant.App.Dominio.Persona");

                    b.Property<int>("Turno_servcio_aseo")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("PersonalAseo");
                });

            modelBuilder.Entity("CTRestaurant.App.Dominio.PersonalCocina", b =>
                {
                    b.HasBaseType("CTRestaurant.App.Dominio.Persona");

                    b.Property<int>("Turno_servcio_cocina")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("PersonalCocina");
                });

            modelBuilder.Entity("CTRestaurant.App.Dominio.Profesor", b =>
                {
                    b.HasBaseType("CTRestaurant.App.Dominio.Persona");

                    b.Property<string>("Cubiculo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facultad")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Profesor");
                });

            modelBuilder.Entity("CTRestaurant.App.Dominio.Turno", b =>
                {
                    b.HasOne("CTRestaurant.App.Dominio.Persona", "Cliente")
                        .WithMany()
                        .HasForeignKey("Clienteid");

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}

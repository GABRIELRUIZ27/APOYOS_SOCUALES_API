﻿// <auto-generated />
using System;
using APOYOS_SOCIALES;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APOYOSSOCIALES.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240507021234_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("APOYOS_SOCIALES.Entities.ActiveToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("TokenId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Activetokens");
                });

            modelBuilder.Entity("APOYOS_SOCIALES.Entities.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("APOYOS_SOCIALES.Entities.Claim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("ClaimValue")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("APOYOS_SOCIALES.Entities.Comunidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Comunidades");
                });

            modelBuilder.Entity("APOYOS_SOCIALES.Entities.ProgramaSocial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Estatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Programassociales");
                });

            modelBuilder.Entity("APOYOS_SOCIALES.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreRol")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Rols");
                });

            modelBuilder.Entity("APOYOS_SOCIALES.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AreaId")
                        .HasColumnType("int");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Estatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("RolId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("APOYOS_SOCIALES.Entities.Claim", b =>
                {
                    b.HasOne("APOYOS_SOCIALES.Entities.Rol", "Rol")
                        .WithMany("Claims")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("APOYOS_SOCIALES.Entities.Usuario", b =>
                {
                    b.HasOne("APOYOS_SOCIALES.Entities.Area", "Area")
                        .WithMany("Usuarios")
                        .HasForeignKey("AreaId");

                    b.HasOne("APOYOS_SOCIALES.Entities.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("APOYOS_SOCIALES.Entities.Area", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("APOYOS_SOCIALES.Entities.Rol", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia.Data;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(SicerWebApiContext))]
    [Migration("20230816190002_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Entities.Ciudad", b =>
                {
                    b.Property<string>("PKNombreCiudad")
                        .HasMaxLength(85)
                        .HasColumnType("varchar")
                        .HasColumnName("PKCiudad");

                    b.Property<string>("DepartamentoFK")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar")
                        .HasColumnName("Departamento_FK");

                    b.HasKey("PKNombreCiudad");

                    b.HasIndex("DepartamentoFK");

                    b.ToTable("Ciudad", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Departamento", b =>
                {
                    b.Property<string>("PKNombreDepartamento")
                        .HasMaxLength(40)
                        .HasColumnType("varchar")
                        .HasColumnName("Departamento_FK");

                    b.Property<string>("PaisFK")
                        .IsRequired()
                        .HasMaxLength(85)
                        .HasColumnType("varchar")
                        .HasColumnName("Pais_FK");

                    b.HasKey("PKNombreDepartamento");

                    b.HasIndex("PaisFK");

                    b.ToTable("Departamento", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Direccion", b =>
                {
                    b.Property<string>("PKDireccion")
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("PKDireccion");

                    b.Property<string>("Letra")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("varchar");

                    b.Property<string>("LetraVS")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar")
                        .HasColumnName("LetraViaSecundaria");

                    b.Property<int>("NroDireccion")
                        .HasColumnType("int")
                        .HasColumnName("NroDireccion");

                    b.Property<int>("NroViaSecundaria")
                        .HasColumnType("int")
                        .HasColumnName("NroViaSecundaria");

                    b.Property<long>("PersonaFK")
                        .HasColumnType("bigint")
                        .HasColumnName("Persona_FK");

                    b.Property<string>("SufijoCardinal")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar")
                        .HasColumnName("SufijoCardinal");

                    b.Property<string>("SufijoCardinalVS")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar")
                        .HasColumnName("SufijoCardinalVS");

                    b.Property<string>("TipoViaFK")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar")
                        .HasColumnName("TipoVia_FK");

                    b.HasKey("PKDireccion");

                    b.HasIndex("PersonaFK");

                    b.HasIndex("TipoViaFK");

                    b.ToTable("Direccion", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Genero", b =>
                {
                    b.Property<string>("PKNombreGenero")
                        .HasMaxLength(25)
                        .HasColumnType("varchar")
                        .HasColumnName("Genero_PK");

                    b.HasKey("PKNombreGenero");

                    b.ToTable("Genero", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Matricula", b =>
                {
                    b.Property<long>("PersonaFK")
                        .HasColumnType("bigint")
                        .HasColumnName("Persona_FK");

                    b.Property<string>("SalonFK")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar")
                        .HasColumnName("Salon_FK");

                    b.HasKey("PersonaFK");

                    b.HasIndex("SalonFK");

                    b.ToTable("Matricula", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Pais", b =>
                {
                    b.Property<string>("PKNombrePais")
                        .HasMaxLength(85)
                        .HasColumnType("varchar")
                        .HasColumnName("Pais_FK");

                    b.HasKey("PKNombrePais");

                    b.ToTable("Pais", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Persona", b =>
                {
                    b.Property<long>("PKCedula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Cedula_PK");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("Apellidos");

                    b.Property<string>("CiudadFK")
                        .IsRequired()
                        .HasMaxLength(85)
                        .HasColumnType("varchar")
                        .HasColumnName("Ciudad_FK");

                    b.Property<string>("GeneroFK")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar")
                        .HasColumnName("Genero_FK");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("Nombres");

                    b.Property<string>("TipoDocumentoFK")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("TipoDeDocumento_FK");

                    b.Property<string>("TipoPersonaFK")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar")
                        .HasColumnName("TipoPersona_FK");

                    b.HasKey("PKCedula");

                    b.HasIndex("CiudadFK");

                    b.HasIndex("GeneroFK");

                    b.HasIndex("TipoDocumentoFK");

                    b.HasIndex("TipoPersonaFK");

                    b.ToTable("Persona", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Salon", b =>
                {
                    b.Property<string>("PKNombreSalon")
                        .HasMaxLength(25)
                        .HasColumnType("varchar")
                        .HasColumnName("PKSalon");

                    b.Property<int>("Capacidad")
                        .HasColumnType("int")
                        .HasColumnName("Capacidad");

                    b.HasKey("PKNombreSalon");

                    b.ToTable("Salon", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.TipoDocumento", b =>
                {
                    b.Property<string>("PKNombreTipo")
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("PKNombreTipo");

                    b.HasKey("PKNombreTipo");

                    b.ToTable("TipoDeDocumento", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.TipoPersona", b =>
                {
                    b.Property<string>("PKTipoPersona")
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("PKTipoPersona");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("Descripcion");

                    b.HasKey("PKTipoPersona");

                    b.ToTable("TipoPersona", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.TipoVia", b =>
                {
                    b.Property<string>("PKNombreTipoVia")
                        .HasMaxLength(25)
                        .HasColumnType("varchar")
                        .HasColumnName("PKNombreTipoVia");

                    b.Property<string>("Abreviatura")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar")
                        .HasColumnName("Abreviatura");

                    b.HasKey("PKNombreTipoVia");

                    b.ToTable("TipoVia", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.TrainerSalon", b =>
                {
                    b.Property<long>("PersonaFK")
                        .HasColumnType("bigint")
                        .HasColumnName("Persona_FK");

                    b.Property<string>("SalonFK")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar")
                        .HasColumnName("Salon_FK");

                    b.HasKey("PersonaFK");

                    b.HasIndex("SalonFK");

                    b.ToTable("TrainerSalon", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Ciudad", b =>
                {
                    b.HasOne("Dominio.Entities.Departamento", "Departamentos")
                        .WithMany("Ciudades")
                        .HasForeignKey("DepartamentoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Dominio.Entities.Departamento", b =>
                {
                    b.HasOne("Dominio.Entities.Pais", "Paises")
                        .WithMany("Departamentos")
                        .HasForeignKey("PaisFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paises");
                });

            modelBuilder.Entity("Dominio.Entities.Direccion", b =>
                {
                    b.HasOne("Dominio.Entities.Persona", "Personas")
                        .WithMany("Direcciones")
                        .HasForeignKey("PersonaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.TipoVia", "TipoDeVias")
                        .WithMany("Direcciones")
                        .HasForeignKey("TipoViaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personas");

                    b.Navigation("TipoDeVias");
                });

            modelBuilder.Entity("Dominio.Entities.Matricula", b =>
                {
                    b.HasOne("Dominio.Entities.Persona", "Personas")
                        .WithMany("Matriculas")
                        .HasForeignKey("PersonaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Salon", "Salones")
                        .WithMany("Matriculas")
                        .HasForeignKey("SalonFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personas");

                    b.Navigation("Salones");
                });

            modelBuilder.Entity("Dominio.Entities.Persona", b =>
                {
                    b.HasOne("Dominio.Entities.Ciudad", "Ciudades")
                        .WithMany("Personas")
                        .HasForeignKey("CiudadFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Genero", "Generos")
                        .WithMany("Personas")
                        .HasForeignKey("GeneroFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.TipoDocumento", "TiposDeDocumentos")
                        .WithMany("Personas")
                        .HasForeignKey("TipoDocumentoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.TipoPersona", "TipoDePersonas")
                        .WithMany("Personas")
                        .HasForeignKey("TipoPersonaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudades");

                    b.Navigation("Generos");

                    b.Navigation("TipoDePersonas");

                    b.Navigation("TiposDeDocumentos");
                });

            modelBuilder.Entity("Dominio.Entities.TrainerSalon", b =>
                {
                    b.HasOne("Dominio.Entities.Persona", "Personas")
                        .WithMany("TrainersDeSalones")
                        .HasForeignKey("PersonaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Salon", "Salones")
                        .WithMany("TrainersDeSalones")
                        .HasForeignKey("SalonFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personas");

                    b.Navigation("Salones");
                });

            modelBuilder.Entity("Dominio.Entities.Ciudad", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Dominio.Entities.Genero", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Dominio.Entities.Persona", b =>
                {
                    b.Navigation("Direcciones");

                    b.Navigation("Matriculas");

                    b.Navigation("TrainersDeSalones");
                });

            modelBuilder.Entity("Dominio.Entities.Salon", b =>
                {
                    b.Navigation("Matriculas");

                    b.Navigation("TrainersDeSalones");
                });

            modelBuilder.Entity("Dominio.Entities.TipoDocumento", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Entities.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Entities.TipoVia", b =>
                {
                    b.Navigation("Direcciones");
                });
#pragma warning restore 612, 618
        }
    }
}

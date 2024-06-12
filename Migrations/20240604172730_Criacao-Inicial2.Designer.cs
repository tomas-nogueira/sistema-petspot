﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrackIt.Models;

#nullable disable

namespace TrackIt.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240604172730_Criacao-Inicial2")]
    partial class CriacaoInicial2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrackIt.Models.Animals", b =>
                {
                    b.Property<int>("AnimalsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AnimalsId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimalsId"));

                    b.Property<string>("AnimalCor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AnimalCor");

                    b.Property<DateTime>("AnimalDtDesaparecimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("AnimalDtDesaparecimento");

                    b.Property<DateTime>("AnimalDtEncontro")
                        .HasColumnType("datetime2")
                        .HasColumnName("AnimalDtEncontro");

                    b.Property<string>("AnimalFoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AnimalFoto");

                    b.Property<string>("AnimalNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AnimalNome");

                    b.Property<string>("AnimalObservacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AnimalObservacao");

                    b.Property<string>("AnimalRaca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AnimalRaca");

                    b.Property<string>("AnimalSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AnimalSexo");

                    b.Property<byte>("AnimalStatus")
                        .HasColumnType("tinyint")
                        .HasColumnName("AnimalStatus");

                    b.Property<string>("AnimalTipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AnimalTipo");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("AnimalsId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("TrackIt.Models.Observacoes", b =>
                {
                    b.Property<int>("ObservacoesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ObservacoesId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObservacoesId"));

                    b.Property<int>("AnimalsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ObservacoesData")
                        .HasColumnType("datetime2")
                        .HasColumnName("ObservacoesData");

                    b.Property<string>("ObservacoesDescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacoesDescricao");

                    b.Property<string>("ObservacoesLocal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacoesLocal");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ObservacoesId");

                    b.HasIndex("AnimalsId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Observacoes");
                });

            modelBuilder.Entity("TrackIt.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("UsuarioEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioEmail");

                    b.Property<string>("UsuarioNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioNome");

                    b.Property<string>("UsuarioSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioSenha");

                    b.Property<string>("UsuarioTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioTelefone");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("TrackIt.Models.Animals", b =>
                {
                    b.HasOne("TrackIt.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("TrackIt.Models.Observacoes", b =>
                {
                    b.HasOne("TrackIt.Models.Animals", "Animals")
                        .WithMany()
                        .HasForeignKey("AnimalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackIt.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animals");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
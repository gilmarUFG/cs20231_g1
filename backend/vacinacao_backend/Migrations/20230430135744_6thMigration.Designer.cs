﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using vacinacao_backend.Repositories;

#nullable disable

namespace vacinacao_backend.Migrations
{
    [DbContext(typeof(VacinacaoContext))]
    [Migration("20230430135744_6thMigration")]
    partial class _6thMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AlergiaUsuario", b =>
                {
                    b.Property<int>("AlergiasId")
                        .HasColumnType("integer");

                    b.Property<int>("UsuariosId")
                        .HasColumnType("integer");

                    b.HasKey("AlergiasId", "UsuariosId");

                    b.HasIndex("UsuariosId");

                    b.ToTable("AlergiaUsuario");
                });

            modelBuilder.Entity("vacinacao_backend.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DataSituacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Observacoes")
                        .HasColumnType("text");

                    b.Property<int>("Situacao")
                        .HasColumnType("integer");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("integer");

                    b.Property<int>("VacinaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("VacinaId");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("vacinacao_backend.Models.Alergia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("VacinaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VacinaId")
                        .IsUnique();

                    b.ToTable("Alergias");
                });

            modelBuilder.Entity("vacinacao_backend.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Numero")
                        .HasColumnType("integer");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Setor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<char>("Sexo")
                        .HasColumnType("character(1)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("vacinacao_backend.Models.Vacina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Doses")
                        .HasColumnType("integer");

                    b.Property<int?>("Intervalo")
                        .HasColumnType("integer");

                    b.Property<int?>("Periodicidade")
                        .HasColumnType("integer");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Vacinas");
                });

            modelBuilder.Entity("AlergiaUsuario", b =>
                {
                    b.HasOne("vacinacao_backend.Models.Alergia", null)
                        .WithMany()
                        .HasForeignKey("AlergiasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vacinacao_backend.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuariosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("vacinacao_backend.Models.Agenda", b =>
                {
                    b.HasOne("vacinacao_backend.Models.Usuario", "Usuario")
                        .WithMany("Agendamentos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vacinacao_backend.Models.Vacina", "Vacina")
                        .WithMany("Agendamentos")
                        .HasForeignKey("VacinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");

                    b.Navigation("Vacina");
                });

            modelBuilder.Entity("vacinacao_backend.Models.Alergia", b =>
                {
                    b.HasOne("vacinacao_backend.Models.Vacina", "Vacina")
                        .WithOne()
                        .HasForeignKey("vacinacao_backend.Models.Alergia", "VacinaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Vacina");
                });

            modelBuilder.Entity("vacinacao_backend.Models.Usuario", b =>
                {
                    b.Navigation("Agendamentos");
                });

            modelBuilder.Entity("vacinacao_backend.Models.Vacina", b =>
                {
                    b.Navigation("Agendamentos");
                });
#pragma warning restore 612, 618
        }
    }
}

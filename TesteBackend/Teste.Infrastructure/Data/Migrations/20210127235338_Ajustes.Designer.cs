﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Teste.Infrastructure.Data.Context;

namespace Teste.Infrastructure.Data.Migrations
{
    [DbContext(typeof(TesteBackendContext))]
    [Migration("20210127235338_Ajustes")]
    partial class Ajustes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Teste.Domain.Entities.Proprietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.HasKey("Id");

                    b.ToTable("Proprietarios");
                });

            modelBuilder.Entity("Teste.Domain.Entities.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<int?>("ProprietarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("Teste.Domain.Entities.Veiculo", b =>
                {
                    b.HasOne("Teste.Domain.Entities.Proprietario", "Proprietario")
                        .WithMany("Veiculos")
                        .HasForeignKey("ProprietarioId");

                    b.Navigation("Proprietario");
                });

            modelBuilder.Entity("Teste.Domain.Entities.Proprietario", b =>
                {
                    b.Navigation("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}

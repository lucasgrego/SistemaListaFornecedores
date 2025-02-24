﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaListaFornecedores.Data;

#nullable disable

namespace SistemaListaFornecedores.Migrations
{
    [DbContext(typeof(SistemaListaFornecedoresDBContext))]
    [Migration("20241106021216_InicandoDB")]
    partial class InicandoDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistemaListaFornecedores.Models.EmpresaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CNPJ")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<string>("NomeEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RamoAtividade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("SistemaListaFornecedores.Models.FornecedoresModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("RamoAtividade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("SistemaListaFornecedores.Models.EmpresaModel", b =>
                {
                    b.HasOne("SistemaListaFornecedores.Models.FornecedoresModel", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId");

                    b.Navigation("Fornecedor");
                });
#pragma warning restore 612, 618
        }
    }
}

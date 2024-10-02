﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisualEssence.Infrastructure.Context;

#nullable disable

namespace VisualEssence.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241002025704_gamechangefilter2")]
    partial class gamechangefilter2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VisualEssence.Domain.Models.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Assunto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DataEnvio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.CriancaInst", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cns")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("DataNascimento")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("IdSala")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NomeResp")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<Guid?>("SalaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Tel1")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Tel2")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<Guid>("UserInstId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdSala");

                    b.HasIndex("SalaId");

                    b.HasIndex("UserInstId");

                    b.ToTable("CriancaInst");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.CriancaPais", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CriancaPais");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.Jogada.JogadaInst", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CriancaInstId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataJogo")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdCrianca")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("JogoId")
                        .HasColumnType("int");

                    b.Property<string>("NomeJogo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pontuacao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CriancaInstId");

                    b.HasIndex("IdCrianca");

                    b.HasIndex("JogoId");

                    b.ToTable("JogadaInst");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.Jogada.JogadaPais", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CriancaPaisId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataJogo")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdCrianca")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IdJogo")
                        .HasColumnType("int");

                    b.Property<int>("Pontuacao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CriancaPaisId");

                    b.HasIndex("IdCrianca");

                    b.ToTable("JogadaPais");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Jogo");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.Sala", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacidade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.UserInst", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("NomeInst")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte[]>("SenhaHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SenhaSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("UserInst");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.UserPais", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte[]>("SenhaHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SenhaSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("UserPais");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.CriancaInst", b =>
                {
                    b.HasOne("VisualEssence.Domain.Models.Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("IdSala")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("VisualEssence.Domain.Models.Sala", null)
                        .WithMany("CriancaInst")
                        .HasForeignKey("SalaId");

                    b.HasOne("VisualEssence.Domain.Models.UserInst", "UserInst")
                        .WithMany("Criancas")
                        .HasForeignKey("UserInstId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sala");

                    b.Navigation("UserInst");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.Jogada.JogadaInst", b =>
                {
                    b.HasOne("VisualEssence.Domain.Models.CriancaInst", null)
                        .WithMany("JogadaInst")
                        .HasForeignKey("CriancaInstId");

                    b.HasOne("VisualEssence.Domain.Models.CriancaInst", "CriancaInst")
                        .WithMany()
                        .HasForeignKey("IdCrianca")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("VisualEssence.Domain.Models.Jogo", null)
                        .WithMany("Jogadas")
                        .HasForeignKey("JogoId");

                    b.Navigation("CriancaInst");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.Jogada.JogadaPais", b =>
                {
                    b.HasOne("VisualEssence.Domain.Models.CriancaPais", null)
                        .WithMany("JogadaPais")
                        .HasForeignKey("CriancaPaisId");

                    b.HasOne("VisualEssence.Domain.Models.CriancaPais", "CriancaPais")
                        .WithMany()
                        .HasForeignKey("IdCrianca")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CriancaPais");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.CriancaInst", b =>
                {
                    b.Navigation("JogadaInst");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.CriancaPais", b =>
                {
                    b.Navigation("JogadaPais");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.Jogo", b =>
                {
                    b.Navigation("Jogadas");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.Sala", b =>
                {
                    b.Navigation("CriancaInst");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.UserInst", b =>
                {
                    b.Navigation("Criancas");
                });
#pragma warning restore 612, 618
        }
    }
}

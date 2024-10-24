﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisualEssence.Infrastructure.Data;

#nullable disable

namespace VisualEssence.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
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
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("DataEnvio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Contato", (string)null);
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Foto")
                        .HasColumnType("TEXT");

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
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

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

                    b.HasIndex("UserInstId");

                    b.ToTable("CriancaInst", (string)null);
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
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("UserPaisId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserPaisId");

                    b.ToTable("CriancaPais", (string)null);
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

                    b.Property<string>("NomeJogo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Pontuacao")
                        .HasColumnType("int");

                    b.Property<Guid>("UserInstId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CriancaInstId");

                    b.HasIndex("IdCrianca");

                    b.HasIndex("UserInstId");

                    b.ToTable("JogadaInst", (string)null);
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.Jogada.JogadaPais", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataJogo")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdCrianca")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeJogo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Pontuacao")
                        .HasColumnType("int");

                    b.Property<Guid>("UserPaisId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdCrianca");

                    b.HasIndex("UserPaisId");

                    b.ToTable("JogadaPais", (string)null);
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
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("UserInstId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserInstId");

                    b.ToTable("Sala", (string)null);
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.UserInst", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("NomeInst")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("SenhaHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SenhaSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("UserInst", (string)null);
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.UserPais", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("SenhaHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SenhaSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("UserPais", (string)null);
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.CriancaInst", b =>
                {
                    b.HasOne("VisualEssence.Domain.Models.Sala", "Sala")
                        .WithMany("CriancaInst")
                        .HasForeignKey("IdSala")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VisualEssence.Domain.Models.UserInst", "UserInst")
                        .WithMany("Criancas")
                        .HasForeignKey("UserInstId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Sala");

                    b.Navigation("UserInst");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.CriancaPais", b =>
                {
                    b.HasOne("VisualEssence.Domain.Models.UserPais", "UserPais")
                        .WithMany("Criancas")
                        .HasForeignKey("UserPaisId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("UserPais");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.Jogada.JogadaInst", b =>
                {
                    b.HasOne("VisualEssence.Domain.Models.CriancaInst", null)
                        .WithMany("JogadaInst")
                        .HasForeignKey("CriancaInstId");

                    b.HasOne("VisualEssence.Domain.Models.CriancaInst", "CriancaInst")
                        .WithMany()
                        .HasForeignKey("IdCrianca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisualEssence.Domain.Models.UserInst", "UserInst")
                        .WithMany("Jogadas")
                        .HasForeignKey("UserInstId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CriancaInst");

                    b.Navigation("UserInst");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.Jogada.JogadaPais", b =>
                {
                    b.HasOne("VisualEssence.Domain.Models.CriancaPais", "CriancaPais")
                        .WithMany("JogadaPais")
                        .HasForeignKey("IdCrianca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisualEssence.Domain.Models.UserPais", "UserPais")
                        .WithMany("Jogadas")
                        .HasForeignKey("UserPaisId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CriancaPais");

                    b.Navigation("UserPais");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.Sala", b =>
                {
                    b.HasOne("VisualEssence.Domain.Models.UserInst", "UserInst")
                        .WithMany("Salas")
                        .HasForeignKey("UserInstId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("UserInst");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.CriancaInst", b =>
                {
                    b.Navigation("JogadaInst");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.CriancaPais", b =>
                {
                    b.Navigation("JogadaPais");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.Sala", b =>
                {
                    b.Navigation("CriancaInst");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.UserInst", b =>
                {
                    b.Navigation("Criancas");

                    b.Navigation("Jogadas");

                    b.Navigation("Salas");
                });

            modelBuilder.Entity("VisualEssence.Domain.Models.UserPais", b =>
                {
                    b.Navigation("Criancas");

                    b.Navigation("Jogadas");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using CRUDJunior.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUDJunior.Migrations
{
    [DbContext(typeof(CrudeContext))]
    [Migration("20230805210908_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("CRUDJunior.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Id");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("DATETIME")
                        .HasColumnName("DataNascimento");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("Imagem");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Aluno", (string)null);
                });

            modelBuilder.Entity("CRUDJunior.Models.Assinatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Id");

                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssinaturaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("DATETIME")
                        .HasColumnName("DataCriacao");

                    b.Property<bool>("Expirada")
                        .HasColumnType("BIT")
                        .HasColumnName("Expirada");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("DATETIME")
                        .HasColumnName("Inicio");

                    b.Property<DateTime>("Termino")
                        .HasColumnType("DATETIME")
                        .HasColumnName("Termino");

                    b.HasKey("Id");

                    b.HasIndex("AssinaturaId");

                    b.ToTable("Assinatura", (string)null);
                });

            modelBuilder.Entity("CRUDJunior.Models.Aluno", b =>
                {
                    b.OwnsOne("CRUDJunior.Models.ValueObject.Documento", "CPF", b1 =>
                        {
                            b1.Property<int>("AlunoId")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("Id")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("TEXT")
                                .HasColumnName("CPF");

                            b1.HasKey("AlunoId");

                            b1.ToTable("Aluno");

                            b1.WithOwner()
                                .HasForeignKey("AlunoId");
                        });

                    b.OwnsOne("CRUDJunior.Models.ValueObject.Nome", "NomeCompleto", b1 =>
                        {
                            b1.Property<int>("AlunoId")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("Id")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("PrimeiroNome")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("TEXT")
                                .HasColumnName("PrimeiroNome");

                            b1.Property<string>("UltimoNome")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("TEXT")
                                .HasColumnName("UltimoNome");

                            b1.HasKey("AlunoId");

                            b1.ToTable("Aluno");

                            b1.WithOwner()
                                .HasForeignKey("AlunoId");
                        });

                    b.Navigation("CPF")
                        .IsRequired();

                    b.Navigation("NomeCompleto")
                        .IsRequired();
                });

            modelBuilder.Entity("CRUDJunior.Models.Assinatura", b =>
                {
                    b.HasOne("CRUDJunior.Models.Aluno", "Aluno")
                        .WithMany("Assinaturas")
                        .HasForeignKey("AssinaturaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Aluno");
                });

            modelBuilder.Entity("CRUDJunior.Models.Aluno", b =>
                {
                    b.Navigation("Assinaturas");
                });
#pragma warning restore 612, 618
        }
    }
}

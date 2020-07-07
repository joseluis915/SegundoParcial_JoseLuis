﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SegundoParcial_JoseLuis.DAL;

namespace SegundoParcial_JoseLuis.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200707025035_Migracion_Inicial")]
    partial class Migracion_Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("SegundoParcial_JoseLuis.Entidades.Proyectos", b =>
                {
                    b.Property<int>("ProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.HasKey("ProyectoId");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("SegundoParcial_JoseLuis.Entidades.ProyectosDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Requerimiento")
                        .HasColumnType("TEXT");

                    b.Property<int>("TareaId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Tiempo")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoId");

                    b.HasIndex("TareaId");

                    b.ToTable("ProyectosDetalle");
                });

            modelBuilder.Entity("SegundoParcial_JoseLuis.Entidades.Tareas", b =>
                {
                    b.Property<int>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TipoTarea")
                        .HasColumnType("TEXT");

                    b.HasKey("TareaId");

                    b.ToTable("Tareas");

                    b.HasData(
                        new
                        {
                            TareaId = 1,
                            TipoTarea = "Analisis"
                        },
                        new
                        {
                            TareaId = 2,
                            TipoTarea = "Diseño"
                        },
                        new
                        {
                            TareaId = 3,
                            TipoTarea = "Programación"
                        },
                        new
                        {
                            TareaId = 4,
                            TipoTarea = "Prueba"
                        });
                });

            modelBuilder.Entity("SegundoParcial_JoseLuis.Entidades.ProyectosDetalle", b =>
                {
                    b.HasOne("SegundoParcial_JoseLuis.Entidades.Proyectos", null)
                        .WithMany("Detalle")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SegundoParcial_JoseLuis.Entidades.Tareas", "Tipo")
                        .WithMany()
                        .HasForeignKey("TareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

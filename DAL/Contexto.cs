using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SegundoParcial_JoseLuis.Entidades;

namespace SegundoParcial_JoseLuis.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Proyectos> Proyectos { get; set; }
        public DbSet<Tareas> Tareas { get; set; }

        //——————————————————————————————————————————————————————————————————————————————————————
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Data\ProyectoTareas_DB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tareas>().HasData(new Tareas { TareaId = 1, TipoTarea = "Analisis", Requerimiento = "Analizar la opción de clientes", Tiempo = 120 });
            modelBuilder.Entity<Tareas>().HasData(new Tareas { TareaId = 2, TipoTarea = "Diseño", Requerimiento = "Hacer un diseño excelente", Tiempo = 60 });
            modelBuilder.Entity<Tareas>().HasData(new Tareas { TareaId = 3, TipoTarea = "Programación", Requerimiento = "Programar todo el registro", Tiempo = 240 });
            modelBuilder.Entity<Tareas>().HasData(new Tareas { TareaId = 4, TipoTarea = "Prueba", Requerimiento = "Probar con mucho cuidado", Tiempo = 30 });
        }
    }
}
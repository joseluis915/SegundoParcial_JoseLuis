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
            modelBuilder.Entity<Tareas>().HasData(new Tareas { TareaId = 1, TipoTarea = "Analisis" });
            modelBuilder.Entity<Tareas>().HasData(new Tareas { TareaId = 2, TipoTarea = "Diseño" });
            modelBuilder.Entity<Tareas>().HasData(new Tareas { TareaId = 3, TipoTarea = "Programación" });
            modelBuilder.Entity<Tareas>().HasData(new Tareas { TareaId = 4, TipoTarea = "Prueba" });
        }
    }
}
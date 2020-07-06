using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;


namespace SegundoParcial_JoseLuis.DAL
{
    public class Contexto : DbContext
    {


        //——————————————————————————————————————————————————————————————————————————————————————
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}

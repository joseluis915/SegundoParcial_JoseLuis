using System;
using System.Collections.Generic;
using System.Text;
//Using agregados
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SegundoParcial_JoseLuis.DAL;
using SegundoParcial_JoseLuis.Entidades;

namespace SegundoParcial_JoseLuis.BLL
{
    public class TareasBLL
    {
        public static List<Tareas> GetTareas()
        {
            List<Tareas> tareas = new List<Tareas>();
            Contexto contexto = new Contexto();

            try
            {
                tareas = contexto.Tareas.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tareas;
        }
    }
}
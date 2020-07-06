using SegundoParcial_JoseLuis.DAL;
using SegundoParcial_JoseLuis.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SegundoParcial_JoseLuis.BLL
{
    public class TareasBLL
    {
        //——————————————————————————————————————————————[ GetList ]——————————————————————————————————————————————
        public static List<Tareas> GetList()
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
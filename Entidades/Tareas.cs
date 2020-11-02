using System;
using System.Collections.Generic;
using System.Text;
//Using agregados
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SegundoParcial_JoseLuis.Entidades
{
    public class Tareas
    {
        [Key]
        public int TareaId { get; set; }
        public string TipoTarea { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
//Using agregados
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SegundoParcial_JoseLuis.Entidades
{
    public class ProyectosDetalle
    {
        [Key]
        public int ProyectosDetalleId { get; set; }
        public int ProyectoId { get; set; }
        public int TareaId { get; set; }
        public string Requerimiento { get; set; }
        public double Tiempo { get; set; }

        //———————————————————————————[ ForeingKeys ]———————————————————————————
        [ForeignKey("TareaId")]
        public Tareas tareas { get; set; } = new Tareas();
    }
}
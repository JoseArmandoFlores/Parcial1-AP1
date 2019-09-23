using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_AP1.Entidades
{
    public class Evaluaciones
    {
        [Key]
        public int EvaluacionID { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Valor { get; set; }
        public decimal Logrado { get; set; }
        public decimal Perdido { get; set; }
        public int Pronostico { get; set; }
    }
}

using Parcial1_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_AP1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Evaluaciones> Evaluacion { get; set; }
        public Contexto() : base("ConStr") { }
    }
}

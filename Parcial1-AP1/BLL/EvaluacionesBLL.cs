using Parcial1_AP1.DAL;
using Parcial1_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_AP1.BLL
{
    public class EvaluacionesBLL
    {
        public static bool Guardar(Evaluaciones evaluacion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Evaluacion.Add(evaluacion) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Evaluaciones evaluacion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(evaluacion).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Evaluacion.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Evaluaciones Buscar(int id)
        {
            Contexto db = new Contexto();
            Evaluaciones evaluacion = new Evaluaciones();
            try
            {
               evaluacion= db.Evaluacion.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return evaluacion;
        }
        
        public static bool Pronosticar(Evaluaciones evaluacion)
        {
            bool paso = false;

            decimal op = ((evaluacion.Logrado / evaluacion.Valor) * 100);
            decimal porciento = 100 - op;
            if (porciento < 25)
            {
                evaluacion.Pronostico = 0;
                paso = true;
            }
            else if (porciento >= 25 && porciento <= 30)
            {
                evaluacion.Pronostico = 1;
                paso = true;
            }
            else if (porciento > 25)
            {
                evaluacion.Pronostico = 2;
                paso = true;
            }
            return paso;
        }

        public static List<Evaluaciones> GetList(Expression<Func<Evaluaciones, bool>> evaluacion)
        {
            var lista = new List<Evaluaciones>();
            var db = new Contexto();
            try
            {
                lista = db.Evaluacion.Where(evaluacion).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;
        }
    }
}

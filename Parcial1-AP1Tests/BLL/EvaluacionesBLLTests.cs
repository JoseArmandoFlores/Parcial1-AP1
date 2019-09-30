using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial1_AP1.BLL;
using Parcial1_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_AP1.BLL.Tests
{
    [TestClass()]
    public class EvaluacionesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Evaluaciones evaluacion = new Evaluaciones();
            evaluacion.EvaluacionID = 0;
            evaluacion.Nombre = "Jose Armando";
            evaluacion.Valor = 31;
            evaluacion.Logrado = 31;
            evaluacion.Fecha = DateTime.Parse("28/01/2001");

            paso = EvaluacionesBLL.Guardar(evaluacion);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Evaluaciones evaluacion = new Evaluaciones();
            evaluacion.EvaluacionID = 20;
            evaluacion.Nombre = "Jose Armando";
            evaluacion.Valor = 31;
            evaluacion.Logrado = 29;
            evaluacion.Fecha = DateTime.Parse("28/01/2001");

            paso = EvaluacionesBLL.Modificar(evaluacion);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Evaluaciones evaluacion = new Evaluaciones();
            evaluacion.EvaluacionID = 20;

            paso = EvaluacionesBLL.Eliminar(evaluacion.EvaluacionID);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Evaluaciones evaluacion = new Evaluaciones();
            evaluacion = EvaluacionesBLL.Buscar(16);
            Assert.AreEqual(evaluacion != null, true);
        }

        [TestMethod()]
        public void PronosticarTest()
        {
            bool paso;
            Evaluaciones evaluacion = new Evaluaciones();
            evaluacion.EvaluacionID = 20;
            evaluacion.Nombre = "Jose Armando";
            evaluacion.Valor = 31;
            evaluacion.Logrado = 29;
            evaluacion.Fecha = DateTime.Parse("28/01/2001");

            paso = EvaluacionesBLL.Pronosticar(evaluacion);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}
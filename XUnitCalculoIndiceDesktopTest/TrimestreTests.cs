using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Proyecto_Tecnicas;

namespace XUnitCalculoIndiceDesktopTest
{
    public class TrimestreTests
    {
        public List<Asignatura> _asignaturas;

        public TrimestreTests()
        {
            List<Asignatura> asignaturas = new List<Asignatura>();
            asignaturas.Add(new Asignatura() { Clave = "IDS-345", Credito = 4, Nombre = "Test1", Nota = 81 });
            asignaturas.Add(new Asignatura() { Clave = "IDS-324", Credito = 4, Nombre = "Test2", Nota = 71 });
            asignaturas.Add(new Asignatura() { Clave = "IDS-257", Credito = 4, Nombre = "Test3", Nota = 91 });
            asignaturas.Add(new Asignatura() { Clave = "IDS-333", Credito = 4, Nombre = "Test4", Nota = 86 });
            _asignaturas = asignaturas;
        }

        [Fact]
        public void AgregarAsignatura_Completes_Without_Exception_and_Returns_True()
        {
            Trimestre testTrim = new Trimestre();

            Asignatura expected = new Asignatura { Clave = "IDS-332", Credito = 4, Nombre = "Ingenieria de Factores Humanos", Nota = 88 };

            bool returned = testTrim.AgregarAsignatura(expected);

            Assert.Contains(expected, testTrim.Asignaturas);
            Assert.True(returned);
        }

        [Fact]
        public void BuscarAsignatura_Returns_Clave_Correctly()
        {
            Trimestre testTrim = new Trimestre();
            testTrim.Asignaturas = _asignaturas;

            int expected = 2;

            int returned = testTrim.BuscarAsignatura("IDS-257");

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void CalcularIndiceTrimestral_Calculates_Indice_Correctly() 
        {
            Trimestre testTrim = new Trimestre();
            testTrim.Asignaturas = _asignaturas;

            double expected = 3;

            double returned = testTrim.CalcularIndiceTrimestral();

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void CalcularPonderacion_Calculates_Ponderacion_Correctly()
        {
            Trimestre testTrim = new Trimestre();
            testTrim.Asignaturas = _asignaturas;

            double expected = 48;

            double returned = testTrim.CalcularPonderacion();

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void CalcularCreditos_Calculates_Sum_Correctly()
        {
            Trimestre testTrim = new Trimestre();
            testTrim.Asignaturas = _asignaturas;

            double expected = 16;

            double returned = testTrim.CalcularCreditos();
            
            Assert.Equal(expected, returned);
        }

    }
}

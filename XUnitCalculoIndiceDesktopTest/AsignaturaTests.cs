using System;
using Xunit;
using Proyecto_Tecnicas;
using System.Collections.Generic;

namespace XUnitCalculoIndiceDesktopTest
{
    public class AsignaturaTests
    {
        public AsignaturaTests()
        {
            List<Asignatura> asignaturas = new List<Asignatura>();
            asignaturas.Add(new Asignatura { Clave = "IDS-321", Credito = 3, Nombre = "Test", Nota = 92 });
            // asignacion de datos de asigantura
            Asignatura.Asignaturas = asignaturas;
        }

        [Fact]
        public void AgregarAsignatura_Completes_Without_Exception_and_Returns_True()
        {
            Asignatura testAsig = new Asignatura { Clave = "IDS-332", Credito = 4, Nombre = "Ingenieria de Factores Humanos", Nota = 88 };

            bool returned = testAsig.AgregarAsignatura();

            Assert.Contains(testAsig, Asignatura.Asignaturas);
            Assert.True(returned);
        }

        [Fact]
        public void BorrarAsignatura_Completes_Without_Exception_and_Returns_True()
        {
            Asignatura testAsig = new Asignatura { Clave = "IDS-321", Credito = 3, Nombre = "Test", Nota = 92 };

            bool returned = Asignatura.BorrarAsignatura("IDS-321");

            Assert.DoesNotContain(testAsig, Asignatura.Asignaturas);
            Assert.True(returned);
        }

        [Fact]
        public void toString_Returns_Correctly_Formatted()
        {
            Asignatura testAsig = new Asignatura { Clave = "IDS-321", Credito = 3, Nombre = "Test", Nota = 92 };

            string returned = testAsig.toString();

            Assert.Equal("IDS-321                                        Test                    3", returned);
        }

        [Fact]
        public void BuscarAsignatura_Returns_Correct_Index()
        {
            string clave = "IDS-321";

            int expected = 0;

            int returned = Asignatura.BuscarAsignatura(clave);

            Assert.Equal(expected, returned);
        }

    }
}

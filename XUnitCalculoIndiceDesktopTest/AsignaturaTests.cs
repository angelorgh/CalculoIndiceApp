using System;
using Xunit;
using Proyecto_Tecnicas;
using System.Collections.Generic;

namespace XUnitCalculoIndiceDesktopTest
{
    public class AsignaturaTests
    {
        public static List<Trimestre> _trimestres;


        public AsignaturaTests()
        {
            List<Asignatura> asignaturas = new List<Asignatura>();
            asignaturas.Add(new Asignatura { Clave = "IDS321", Credito = 3, Nombre = "Test", Nota = 92 });
            // asignacion de datos de asigantura
            Asignatura.Asignaturas = asignaturas;
        }

        [Fact]
        public void AgregarAsignatura_Completes_Without_Exception()
        {
            Asignatura testAsig = new Asignatura { Clave = "IDS-332", Credito = 4, Nombre = "Ingenieria de Factores Humanos", Nota = 88 };

            bool returned = testAsig.AgregarAsignatura();

            Assert.Contains(testAsig, Asignatura.Asignaturas);
            Assert.True(returned);
        }


    }
}

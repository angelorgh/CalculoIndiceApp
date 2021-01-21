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
            asignaturas.Add(new Asignatura { Clave = "IDS321", Credito = 3, Nombre = "Test", Nota = 92 });
            // asignacion de datos de asigantura
            Asignatura.Asignaturas = asignaturas;
        }

        [Fact]
        public void Test1()
        {
            List<Asignatura> test = Asignatura.Asignaturas;
        }
    }
}

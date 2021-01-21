using Proyecto_Tecnicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitCalculoIndiceDesktopTest
{
    public class ProfesorTests
    {
        public ProfesorTests()
        {
            List<Profesor> profesores = new List<Profesor>();
            profesores.Add(new Profesor { ID = "1096879", Nombre = "Gabriel Santana" });
            Profesor.Profesores = profesores;
        }
        [Fact]
        public void AgregarProfesor_Completes_WithoutException()
        {
            Profesor profesor = new Profesor("1096880", "Angelo Gonzalez");
            Assert.True(profesor.AgregarProfesor());
        }
        [Fact]
        public void BuscarProfesor_Returns_CorrectIndex()
        {
            Int16 expected = 0;
            Assert.Equal(expected, Profesor.BuscarProfesor("1096879"));
        }
        [Fact]
        public void BorrarProfesor_Completes_WithoutException()
        {
            Profesor testProfesor = new Profesor { ID = "1096879", Nombre = "Gabriel Santana" };
            Assert.True(Profesor.BorrarProfesor("1096879"));
            Assert.DoesNotContain(testProfesor, Profesor.Profesores);
        }
    }
}

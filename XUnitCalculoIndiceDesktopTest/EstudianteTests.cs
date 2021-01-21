using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Tecnicas;
using Xunit;

namespace XUnitCalculoIndiceDesktopTest
{
    public class EstudianteTests
    {
        public static List<Estudiante> estudiantes;

        public EstudianteTests()
        {
            EstudianteTests.estudiantes.Add(new Estudiante { Carrera = "Ingenieria Software", Honores = "Magna Cum Laude", ID = "1085855", IndiceGeneral = 3.54, Nombre = "Gabriel", Trimestres = null });
            Estudiante.Estudiantes = EstudianteTests.estudiantes;
        }

        [Fact]
        public void AgregarEstudiante_Completes_Without_Exception()
        {
            Estudiante estudiante = new Estudiante("1085855", "Gabriel", "Psicologia");
            Assert.True(estudiante.AgregarEstudiante());
            Assert.Contains(estudiante, Estudiante.Estudiantes);
            
        }
    }
}

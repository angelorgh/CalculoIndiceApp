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
       
        public EstudianteTests()
        {
            List<Asignatura> asignaturas = new List<Asignatura>();
           // List<Trimestre> trimestres = new List<Trimestre>();
            List<Estudiante> estudiantes = new List<Estudiante>();
           // asignaturas.Add(new Asignatura { Clave = "IDS-332", Credito = 5, Nombre = "Lab.Test", Nota = 90 });
            //trimestres.Add(new Trimestre { Asignaturas = asignaturas, añoFin = "2020", añoInicio = "2020", ID = "1", IndiceTrim = 3.54, Meses = "Agosto-Noviembre"});
            estudiantes.Add(new Estudiante { Carrera = "Ingenieria Software", ID = "1085855", Nombre = "Gabriel", Honores ="Magna Cum Laude", IndiceGeneral = 3.54});
            Estudiante.Estudiantes = estudiantes;
            
            
        }

        [Fact]
        public void AgregarEstudiante_Completes_Without_Exception()
        {
            Estudiante estudiante = new Estudiante("1085855", "Gabriel", "Psicologia");
            Assert.True(estudiante.AgregarEstudiante());
            Assert.Contains(estudiante, Estudiante.Estudiantes);
        }
        [Fact]
        public void BorrarEstudiantes_Completes_Without_Exception()
        {
            Estudiante testEstudiante = new Estudiante { Carrera = "Ingenieria Software", ID = "1085855", Nombre = "Gabriel", Honores = "Magna Cum Laude", IndiceGeneral = 3.54 };
            Assert.True(Estudiante.BorrarEstudiante("1085855"));
            Assert.DoesNotContain(testEstudiante, Estudiante.Estudiantes);
        }
        [Fact]
        public void AgregarTrimestre_Completes_Without_Exception()
        {

        }

    }
}

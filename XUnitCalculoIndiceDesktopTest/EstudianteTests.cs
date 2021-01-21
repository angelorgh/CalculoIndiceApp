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
            //List<Asignatura> asignaturas = new List<Asignatura>();
            // List<Trimestre> trimestres = new List<Trimestre>();
            List<Estudiante> estudiantes = new List<Estudiante>();
            // asignaturas.Add(new Asignatura { Clave = "IDS-332", Credito = 5, Nombre = "Lab.Test", Nota = 90 });
            //trimestres.Add(new Trimestre { Asignaturas = asignaturas, añoFin = "2020", añoInicio = "2020", ID = "1", IndiceTrim = 3.54, Meses = "Agosto-Noviembre"});
            estudiantes.Add(new Estudiante { Carrera = "Ingenieria Software", ID = "1085855", Nombre = "Gabriel", Honores = "Magna Cum Laude", IndiceGeneral = 3.54 });
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
            List<Asignatura> asignaturas = new List<Asignatura>();
            asignaturas.Add(new Asignatura { Clave = "IDS-332", Credito = 5, Nombre = "Lab.Test", Nota = 90 });
            Trimestre trimestre = new Trimestre { Asignaturas = asignaturas, añoFin = "2020", añoInicio = "2020", ID = "1", IndiceTrim = 3.54, Meses = "Agosto-Noviembre" };
            Estudiante testEstudiante = new Estudiante { Carrera = "Ingenieria Software", ID = "1085855", Nombre = "Gabriel", Honores = "Magna Cum Laude", IndiceGeneral = 3.54 };
            Assert.True(testEstudiante.AgregarTrimestre(trimestre));

        }
        [Fact]
        public void BorrarTrimestre_Completes_Without_Exception()
        {
            List<Asignatura> asignaturas = new List<Asignatura>();
            asignaturas.Add(new Asignatura { Clave = "IDS-332", Credito = 5, Nombre = "Lab.Test", Nota = 90 });
            Trimestre trimestre = new Trimestre { Asignaturas = asignaturas, añoFin = "2020", añoInicio = "2020", ID = "1", IndiceTrim = 3.54, Meses = "Agosto-Noviembre" };
            Estudiante testEstudiante = new Estudiante { Carrera = "Ingenieria Software", ID = "1085855", Nombre = "Gabriel", Honores = "Magna Cum Laude", IndiceGeneral = 3.54 };
            Assert.True(testEstudiante.BorrarTrimestre("1"));
            // Assert.DoesNotContain(trimestre, Es)
        }
        [Fact]
        public void BuscarEstudiante_Returns_CorrectIndex()
        {
            String testIndex = "1085855";
            Int16 expected = 0;

            Assert.Equal(expected, Estudiante.BuscarEstudiante(testIndex));
        }
        [Fact]
        public void BuscarTrimestre_Returns_CorrectIndex()
        {
            String testIndex = "1085855";
            Int16 expected = 0;

            Assert.Equal(expected, Estudiante.BuscarEstudiante(testIndex));
        }
        [Fact]
        public void CalcularIndiceGeneral_Returns_ExpectedValue()
        {
            Asignatura Test1 = new Asignatura { Clave = "IDS-001", Credito = 4, Nombre = "Test1", Nota = 81 };
            Asignatura Test2 = new Asignatura { Clave = "IDS-002", Credito = 4, Nombre = "Test2", Nota = 71 };
            Asignatura Test3 = new Asignatura { Clave = "IDS-003", Credito = 4, Nombre = "Test3", Nota = 91 };
            Asignatura Test4 = new Asignatura { Clave = "IDS-004", Credito = 4, Nombre = "Test4", Nota = 86 };
            Asignatura Test5 = new Asignatura { Clave = "IDS-005", Credito = 4, Nombre = "Test5", Nota = 90 };
            Asignatura Test6 = new Asignatura { Clave = "IDS-006", Credito = 5, Nombre = "Test6", Nota = 85 };
            Asignatura Test7 = new Asignatura { Clave = "IDS-007", Credito = 4, Nombre = "Test7", Nota = 91 };
            Asignatura Test8 = new Asignatura { Clave = "IDS-008", Credito = 4, Nombre = "Test8", Nota = 86 };
            Estudiante estudiante = new Estudiante("1085855", "Gabriel", "Ingenieria Software");
            estudiante.AgregarTrimestre(new Trimestre { Asignaturas = new List<Asignatura> { Test1, Test2, Test3, Test4 }, añoFin = "2020", añoInicio = "2020", Meses = "Febrero-Abril" });
            estudiante.AgregarTrimestre(new Trimestre { Asignaturas = new List<Asignatura> { Test5, Test6, Test7, Test8 }, añoFin = "2020", añoInicio = "2020", Meses = "Agosto-Noviembre" });

            Double expected = 3.24;
            Assert.Equal(expected, estudiante.CalcularIndiceGeneral());
        }

        [Fact]
        public void CompareTo_Returns_ExpectedValue()
        {
            Asignatura Test1 = new Asignatura { Clave = "IDS-001", Credito = 4, Nombre = "Test1", Nota = 81 };
            Asignatura Test2 = new Asignatura { Clave = "IDS-002", Credito = 4, Nombre = "Test2", Nota = 71 };
            Asignatura Test3 = new Asignatura { Clave = "IDS-003", Credito = 4, Nombre = "Test3", Nota = 91 };
            Asignatura Test4 = new Asignatura { Clave = "IDS-004", Credito = 4, Nombre = "Test4", Nota = 86 };
            Asignatura Test5 = new Asignatura { Clave = "IDS-005", Credito = 4, Nombre = "Test5", Nota = 90 };
            Asignatura Test6 = new Asignatura { Clave = "IDS-006", Credito = 5, Nombre = "Test6", Nota = 85 };
            Asignatura Test7 = new Asignatura { Clave = "IDS-007", Credito = 4, Nombre = "Test7", Nota = 91 };
            Asignatura Test8 = new Asignatura { Clave = "IDS-008", Credito = 4, Nombre = "Test8", Nota = 86 };
            Estudiante estudiante = new Estudiante("1085855", "Gabriel", "Ingenieria Software");
            estudiante.AgregarTrimestre(new Trimestre { Asignaturas = new List<Asignatura> { Test1, Test2, Test3, Test4 }, añoFin = "2020", añoInicio = "2020", Meses = "Febrero-Abril" });
            estudiante.AgregarTrimestre(new Trimestre { Asignaturas = new List<Asignatura> { Test5, Test6, Test7, Test8 }, añoFin = "2020", añoInicio = "2020", Meses = "Agosto-Noviembre" });

            Int16 expected = -1;
            Assert.Equal(expected, estudiante.CompareTo(Estudiante.Estudiantes[0]));
        }
    }
}

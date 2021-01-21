using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Proyecto_Tecnicas
{
    public class Asignatura : ISerializable
    {
        public string Clave;
        public string Nombre;
        public int Credito;
        public static List<Asignatura> Asignaturas = new List<Asignatura>();
        public int Nota;

        public Asignatura() { }

        public Asignatura(string Clave, string Nombre, int Credito)
        {
            this.Clave = Clave;
            this.Nombre = Nombre;
            this.Credito = Credito;
        }

        public bool AgregarAsignatura()
        {
            try
            {
                Asignaturas.Add(this);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool BorrarAsignatura(string clave)
        {
            try
            {
                Asignatura.Asignaturas.RemoveAll(r => r.Clave == clave);
                for (int i = 0; i < Estudiante.Estudiantes.Count; i++)
                {
                    for (int j = 0; j < Estudiante.Estudiantes[i].Trimestres.Count; j++)
                    {
                        Estudiante.Estudiantes[i].Trimestres[j].Asignaturas.RemoveAll(r => r.Clave == clave);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public string toString()
        {
            string s = String.Format("{0, -10} {1, 40} {2, 20}", this.Clave, this.Nombre, this.Credito);
            return s;
        }

        public static int BuscarAsignatura(string clave)
        {
            int index = Asignatura.Asignaturas.FindIndex(r => r.Clave == clave);
            return index;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Clave", Clave);
            info.AddValue("Nombre", Nombre);
            info.AddValue("Credito", Credito);
            info.AddValue("Nota", Nota);
        }
        public Asignatura(SerializationInfo info, StreamingContext context)
        {
            Clave = (string)info.GetValue("Clave", typeof(string));
            Nombre = (string)info.GetValue("Nombre", typeof(string));
            Credito = (int)info.GetValue("Credito", typeof(int));
            Nota = (int)info.GetValue("IndiceGeneral", typeof(int));
        }
    }
}

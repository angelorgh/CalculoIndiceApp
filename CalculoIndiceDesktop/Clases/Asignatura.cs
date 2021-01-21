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

        //private string clave;
        //public string Clave
        //{
        //    get
        //    {
        //        return this.clave;
        //    }
        //    set
        //    {
        //        this.clave = value;
        //    }
        //}

        //private string nombre;
        //public string Nombre
        //{
        //    get
        //    {
        //        return this.nombre;
        //    }
        //    set
        //    {
        //        this.nombre = value;
        //    }
        //}

        //private int credito;
        //public int Credito
        //{
        //    get
        //    {
        //        return this.credito;
        //    }
        //    set
        //    {
        //        this.credito = value;
        //    }
        //}

        //private int nota;
        //public int Nota
        //{
        //    get
        //    {
        //        return this.nota;
        //    }
        //    set
        //    {
        //        this.nota = value;
        //    }
        //}

        //public static List<Asignatura> Asignaturas = new List<Asignatura>();

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

        public static void BorrarAsignatura(string clave)
        {
            Asignatura.Asignaturas.RemoveAll(r=> r.Clave == clave);
            for (int i = 0; i < Estudiante.Estudiantes.Count; i++)
            {
                for (int j = 0; j < Estudiante.Estudiantes[i].Trimestres.Count; j++)
                {
                    Estudiante.Estudiantes[i].Trimestres[j].Asignaturas.RemoveAll(r=> r.Clave == clave);
                }
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

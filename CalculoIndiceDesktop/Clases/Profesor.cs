using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Proyecto_Tecnicas 
{
    public class Profesor : ISerializable
    {
        public string ID;
        public string Nombre;
        public static List<Profesor> Profesores = new List<Profesor>();

        //private string id;
        //public string ID
        //{
        //    get
        //    {
        //        return this.ID;
        //    }
        //    set
        //    {
        //        this.id = value;
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

        //public static List<Profesor> Profesores = new List<Profesor>();

        public Profesor() { }

        public Profesor(string ID, string Nombre)
        {
            this.ID = ID;
            this.Nombre = Nombre;
        }
        public bool AgregarProfesor()
        {
            try
            {
                Profesores.Add(this);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static bool BorrarProfesor(string ID)
        {
            try
            {
                Profesor.Profesores.RemoveAll(r => r.ID == ID);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static int BuscarProfesor(string ID)
        {
            int index = Profesor.Profesores.FindIndex(r => r.ID == ID);
            return index;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", ID);
            info.AddValue("Nombre", Nombre);
        }

        public Profesor(SerializationInfo info, StreamingContext context)
        {
            ID = (string)info.GetValue("ID", typeof(string));
            Nombre = (string)info.GetValue("Nombre", typeof(string));
        }
    }
}

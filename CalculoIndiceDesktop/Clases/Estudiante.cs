using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace Proyecto_Tecnicas
{
    public class Estudiante : ISerializable, IComparable<Estudiante>
    {
        public string ID;
        public string Nombre;
        public string Carrera;
        public static List<Estudiante> Estudiantes = new List<Estudiante>();
        public List<Trimestre> Trimestres = new List<Trimestre>();
        public double IndiceGeneral;
        public string Honores;

        //private string id;
        //public string ID
        //{
        //    get
        //    {
        //        return this.id;
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

        //private string carrera;
        //public string Carrera
        //{
        //    get
        //    {
        //        return this.carrera;
        //    }
        //    set
        //    {
        //        this.carrera = value;
        //    }
        //}


        //private double indiceGeneral;
        //public double IndiceGeneral
        //{
        //    get
        //    {
        //        return this.indiceGeneral;
        //    }
        //    set
        //    {
        //        this.indiceGeneral = value;
        //    }
        //}

        //private string honores;
        //public string Honores
        //{
        //    get
        //    {
        //        return this.honores;
        //    }
        //    set
        //    {
        //        this.honores = value;
        //    }
        //}

        //public static List<Estudiante> Estudiantes = new List<Estudiante>();
        //public List<Trimestre> Trimestres = new List<Trimestre>();
        public Estudiante() { }

        public Estudiante(string ID, string Nombre, string Carrera)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Carrera = Carrera;
        }
        public bool AgregarEstudiante()
        {
            try
            {
                Estudiantes.Add(this);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            
        }

        public static bool BorrarEstudiante(string ID)
        {
            try
            {
                Estudiante.Estudiantes.RemoveAll(r => r.ID == ID);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
           
        }

        public bool AgregarTrimestre(Trimestre trimestre)
        {
            try
            {
                this.Trimestres.Add(trimestre);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            
        }

        public bool BorrarTrimestre(string guid)
        {
            try
            {
                this.Trimestres.RemoveAll(r => r.ID == guid);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


        public string toString()
        {
            string s = String.Format("{0, -10}{1, 40}{2, 20}", this.ID, this.Nombre, this.Carrera);
            return s;
        }

        public static int BuscarEstudiante(string ID)
        {
            int index = Estudiante.Estudiantes.FindIndex(r => r.ID == ID);
            return index;
        }

        public int BuscarTrimestre(string ID)
        {
            int index = this.Trimestres.FindIndex(r => r.ID == ID);
            return index;
        }

        public double CalcularIndiceGeneral()
        {
            double indiceGeneral = 0;
            double ponderacionGeneral = 0;
            double creditosTotal = 0;
            foreach (var trim in this.Trimestres)
            {
                ponderacionGeneral += trim.CalcularPonderacion();
                creditosTotal += trim.CalcularCreditos();
            }

            indiceGeneral = ponderacionGeneral / creditosTotal;
            indiceGeneral = Math.Round(indiceGeneral, 1);
            this.IndiceGeneral = indiceGeneral;
            CheckearHonores();
            return this.IndiceGeneral;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", ID);
            info.AddValue("Nombre", Nombre);
            info.AddValue("Carrera", Carrera);
            info.AddValue("IndiceGeneral", IndiceGeneral);
            info.AddValue("Trimestres", Trimestres);
            info.AddValue("Honores", Honores);

        }

        public Estudiante(SerializationInfo info, StreamingContext context)
        {
            ID = (string)info.GetValue("ID", typeof(string));
            Nombre = (string)info.GetValue("Nombre", typeof(string));
            Carrera = (string)info.GetValue("Carrera", typeof(string));
            IndiceGeneral = (double)info.GetValue("IndiceGeneral", typeof(double));
            Trimestres = (List<Trimestre>)info.GetValue("Trimestres", typeof(List<Trimestre>));
            Honores = (string)info.GetValue("Honores", typeof(string));
        }

        public static bool CheckearHonores()
        {
            try
            {
                for (int i = 0; i < Estudiante.Estudiantes.Count; i++)
                {
                    if (Estudiante.Estudiantes[i].IndiceGeneral >= 3.8 && Estudiante.Estudiantes[i].IndiceGeneral <= 4)
                    {
                        Estudiante.Estudiantes[i].Honores = "Summa Cum Laude";
                    }
                    else if (Estudiante.Estudiantes[i].IndiceGeneral >= 3.5 && Estudiante.Estudiantes[i].IndiceGeneral <= 3.7)
                    {
                        Estudiante.Estudiantes[i].Honores = "Magna Cum Laude";
                    }
                    else if (Estudiante.Estudiantes[i].IndiceGeneral >= 3.2 && Estudiante.Estudiantes[i].IndiceGeneral <= 3.4)
                    {
                        Estudiante.Estudiantes[i].Honores = "Cum Laude";
                    }
                    else
                    {
                        Estudiante.Estudiantes[i].Honores = "Sin Honores";
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
           
        }

        public int CompareTo(Estudiante other)
        {
            if (this.IndiceGeneral > other.IndiceGeneral)
                return 1;

            else if (this.IndiceGeneral < other.IndiceGeneral)
                return -1;
            else
                return 0;

        }
    }
}

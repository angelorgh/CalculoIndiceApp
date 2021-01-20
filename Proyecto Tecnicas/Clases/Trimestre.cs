using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Proyecto_Tecnicas
{
    public class Trimestre : ISerializable
    {
        public string ID;
        public string Meses;
        public string añoInicio;
        public string añoFin;
        public double IndiceTrim;
        public List<Asignatura> Asignaturas = new List<Asignatura>();

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

        //private string meses;
        //public string Meses
        //{
        //    get
        //    {
        //        return this.meses;
        //    }
        //    set
        //    {
        //        this.meses = value;
        //    }
        //}

        //private string añoinicio;
        //public string añoInicio
        //{
        //    get
        //    {
        //        return this.añoinicio;
        //    }
        //    set
        //    {
        //        this.añoinicio = value;
        //    }
        //}

        //private string añofin;
        //public string añoFin
        //{
        //    get
        //    {
        //        return this.añofin;
        //    }
        //    set
        //    {
        //        this.añofin = value;
        //    }
        //}

        //private double indiceTrim;
        //public double IndiceTrim
        //{
        //    get
        //    {
        //        return this.indiceTrim;
        //    }
        //    set
        //    {
        //        this.indiceTrim = value;
        //    }
        //}

        //public List<Asignatura> Asignaturas = new List<Asignatura>();


        public Trimestre()
        {
            this.ID = Guid.NewGuid().ToString();
        }

        public Trimestre(string Meses, string añoInicio, string añoFin)
        {
            this.ID = Guid.NewGuid().ToString();
            this.Meses = Meses;
            this.añoInicio = añoInicio;
            this.añoFin = añoFin;
        }


        public void AgregarAsignatura(Asignatura asig)
        {
            this.Asignaturas.Add(asig);
        }

        public int BuscarAsignatura(string Clave)
        {
            int index = this.Asignaturas.FindIndex(r => r.Clave == Clave);
            return index;
        }
        public void CalcularIndiceTrimestral()
        {
            double indice = 0;
            double sumaCreditos = 0;
            double totalPuntosdeHonor = 0;
            foreach (var asig in this.Asignaturas)
            {
                int valor;
                int puntosdehonor = 0;
                if (asig.Nota >= 90 && asig.Nota <= 100)
                {
                    sumaCreditos += asig.Credito;
                    valor = 4;
                    puntosdehonor = valor * asig.Credito;
                }
                else if (asig.Nota >= 80 && asig.Nota <= 89)
                {
                    sumaCreditos += asig.Credito;
                    valor = 3;
                    puntosdehonor = valor * asig.Credito;
                }
                else if (asig.Nota >= 70 && asig.Nota <= 79)
                {
                    sumaCreditos += asig.Credito;
                    valor = 2;
                    puntosdehonor = valor * asig.Credito;
                }
                else if (asig.Nota >= 60 && asig.Nota <= 69)
                {
                    sumaCreditos += asig.Credito;
                    valor = 1;
                    puntosdehonor = valor * asig.Credito;
                }
                else if (asig.Nota >= 0 && asig.Nota <= 59)
                {
                    valor = 0;
                    sumaCreditos += asig.Credito;
                    puntosdehonor = valor * asig.Credito;
                }
                else if (asig.Nota == 311)
                {
                    valor = 0;
                    puntosdehonor = valor * asig.Credito;
                }
                totalPuntosdeHonor += puntosdehonor;
            }
            indice = totalPuntosdeHonor / sumaCreditos;

            indice = Math.Round(indice,1);
            this.IndiceTrim = indice;
            Estudiante.CheckearHonores();
        }

        public double CalcularPonderacion()
        {
            double indice = 0;
            double sumaCreditos = 0;
            double totalPuntosdeHonor = 0;
            foreach (var asig in this.Asignaturas)
            {
                int valor;
                int puntosdehonor = 0;
                if (asig.Nota >= 90 && asig.Nota <= 100)
                {
                    sumaCreditos += asig.Credito;
                    valor = 4;
                    puntosdehonor = valor * asig.Credito;
                }
                else if (asig.Nota >= 80 && asig.Nota <= 89)
                {
                    sumaCreditos += asig.Credito;
                    valor = 3;
                    puntosdehonor = valor * asig.Credito;
                }
                else if (asig.Nota >= 70 && asig.Nota <= 79)
                {
                    sumaCreditos += asig.Credito;
                    valor = 2;
                    puntosdehonor = valor * asig.Credito;
                }
                else if (asig.Nota >= 60 && asig.Nota <= 69)
                {
                    sumaCreditos += asig.Credito;
                    valor = 1;
                    puntosdehonor = valor * asig.Credito;
                }
                else if (asig.Nota >= 0 && asig.Nota <= 59)
                {
                    valor = 0;
                    sumaCreditos += asig.Credito;
                    puntosdehonor = valor * asig.Credito;
                }
                else if (asig.Nota == 311)
                {
                    valor = 0;
                    puntosdehonor = valor * asig.Credito;
                }
                totalPuntosdeHonor += puntosdehonor;
            }
            indice = totalPuntosdeHonor / sumaCreditos;

            indice = Math.Round(indice, 1);
            return totalPuntosdeHonor;
        }

        public double CalcularCreditos()
        {
            double indice = 0;
            double sumaCreditos = 0;
            double totalPuntosdeHonor = 0;
            foreach (var asig in this.Asignaturas)
            {
                int valor;
                int puntosdehonor = 0;
                if (asig.Nota >= 90 && asig.Nota <= 100)
                {
                    sumaCreditos += asig.Credito;
                    valor = 4;
                    puntosdehonor = valor * asig.Credito;
                }
                else if (asig.Nota >= 80 && asig.Nota <= 89)
                {
                    sumaCreditos += asig.Credito;
                    valor = 3;
                    puntosdehonor = valor * asig.Credito;
                }
                else if (asig.Nota >= 70 && asig.Nota <= 79)
                {
                    sumaCreditos += asig.Credito;
                    valor = 2;
                    puntosdehonor = valor * asig.Credito;
                }
                else if (asig.Nota >= 60 && asig.Nota <= 69)
                {
                    sumaCreditos += asig.Credito;
                    valor = 1;
                    puntosdehonor = valor * asig.Credito;
                }
                else if (asig.Nota >= 0 && asig.Nota <= 59)
                {
                    valor = 0;
                    sumaCreditos += asig.Credito;
                    puntosdehonor = valor * asig.Credito;
                }
                else if (asig.Nota == 311)
                {
                    valor = 0;
                    puntosdehonor = valor * asig.Credito;
                }
                totalPuntosdeHonor += puntosdehonor;
            }
            indice = totalPuntosdeHonor / sumaCreditos;

            indice = Math.Round(indice, 1);
            return sumaCreditos;

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", ID);
            info.AddValue("Meses", Meses);
            info.AddValue("AñoInicio", añoInicio);
            info.AddValue("AñoFin", añoFin);
            info.AddValue("IndiceTrim", IndiceTrim);
        }
        public Trimestre(SerializationInfo info, StreamingContext context)
        {
            ID = (string)info.GetValue("ID", typeof(string));
            Meses = (string)info.GetValue("Meses", typeof(string));
            añoInicio = (string)info.GetValue("AñoInicio", typeof(string));
            añoFin = (string)info.GetValue("AñoFin", typeof(string));
            IndiceTrim = (double)info.GetValue("IndiceTrim", typeof(double));
        }
    }
    


}

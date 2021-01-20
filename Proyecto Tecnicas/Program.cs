using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Proyecto_Tecnicas
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {

            ReadFromFiles();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormProvider.MainMenu);
            //Menu mainMenu = new Menu();
            //Application.Run(new Menu());
            //Application.Run(mainMenu);
            //Menu.mainMenu.Show();
            WriteToFiles();
        }

        public static void WriteToFiles()
        {
            using (Stream fs = new FileStream("Asignaturas.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Asignatura>));
                serializer.Serialize(fs, Asignatura.Asignaturas);
                fs.Close();
            }

            using (Stream fs2 = new FileStream("Estudiantes.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Estudiante>));
                serializer2.Serialize(fs2, Estudiante.Estudiantes);
                fs2.Close();
            }

            using (Stream fs3 = new FileStream("Profesores.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer3 = new XmlSerializer(typeof(List<Profesor>));
                serializer3.Serialize(fs3, Profesor.Profesores);
                fs3.Close();
            }

        }

        public static void ReadFromFiles()
        {
            if (File.Exists("Asignaturas.xml"))
            {
                XmlSerializer serializer4 = new XmlSerializer(typeof(List<Asignatura>));
                using (FileStream fs4 = File.OpenRead("Asignaturas.xml"))
                {
                    Asignatura.Asignaturas = (List<Asignatura>)serializer4.Deserialize(fs4);
                    fs4.Close();
                }

            }
            if (File.Exists("Estudiantes.xml"))
            {
                XmlSerializer serializer5 = new XmlSerializer(typeof(List<Estudiante>));
                using (FileStream fs5 = File.OpenRead("Estudiantes.xml"))
                {
                    Estudiante.Estudiantes = (List<Estudiante>)serializer5.Deserialize(fs5);
                    fs5.Close();
                }
            }
            if (File.Exists("Profesores.xml"))
            {
                XmlSerializer serializer6 = new XmlSerializer(typeof(List<Profesor>));
                using (FileStream fs6 = File.OpenRead("Profesores.xml"))
                {
                    Profesor.Profesores = (List<Profesor>)serializer6.Deserialize(fs6);
                    fs6.Close();
                }
            }
        }

        
    }


}

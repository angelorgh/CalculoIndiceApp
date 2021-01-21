using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Proyecto_Tecnicas
{
    public partial class InsertarEstudiante : Form
    {
        public InsertarEstudiante()
        {
            InitializeComponent();
        }

        //private void ButtonVolver_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Login.mdf;Integrated Security=True";
        static string path2 = Environment.CurrentDirectory;
        static string path = Path.GetFullPath(Path.Combine(path2, @"..\..\")) + "Login.mdf";
        //static string path = "\"C:\\Proyectos\\Proyecto-TecnicasGrupo#7Sec-01\\Proyecto Tecnicas\\Login.mdf\"";
        static string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ path +";Integrated Security=True";


        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(textBoxEstNombre.Text) || string.IsNullOrWhiteSpace(textBoxEstCarrera.Text)))
            {
                MessageBox.Show("Una o más celdas estan vacias.");
                return;
            }

            bool cont = true;
            do
            {
                Random ranID = new Random();
                string id = ranID.Next(0, 99999).ToString("D5");
                id = "10" + id;

                List<Estudiante> results = Estudiante.Estudiantes.FindAll(x => x.ID == id);

                if (results.Count == 0)
                {
                    SqlConnection con = new SqlConnection(cs);
                    string query = "INSERT INTO Login_Est (username, password) VALUES(@username, @password);";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", id);
                    cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    int i = cmd.ExecuteNonQuery();

                    con.Close();

                    if (i != 0)
                    {
                        MessageBox.Show(i + "Data Guardada");
                    }
                    con.Close();

                    Estudiante estudiante = new Estudiante(id, textBoxEstNombre.Text, textBoxEstCarrera.Text);
                    estudiante.AgregarEstudiante();
                    Program.WriteToFiles();
                    cont = false;
                }
            } while (cont);
            
            this.Close();

        }


    }
}

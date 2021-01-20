using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Proyecto_Tecnicas
{
    public partial class LoginEstudiante : Form
    {
        public LoginEstudiante()
        {
            InitializeComponent();
        }

        static string path2 = Environment.CurrentDirectory;
        static string path = Path.GetFullPath(Path.Combine(path2, @"..\..\")) + "Login.mdf";
        //static string path = "\"C:\\Proyectos\\Proyecto-TecnicasGrupo#7Sec-01\\Proyecto Tecnicas\\Login.mdf\"";
        static string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                MessageBox.Show("Por favor digite username y/o password");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from Login_Est where username=@username and password=@password", con);
                cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    this.Close();
                    MenuEstudiante menuEst = new MenuEstudiante(textBoxUsername.Text);
                    menuEst.Show();
                }
                else
                {
                    MessageBox.Show("Login Fallido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProvider.MainMenu.Show();
        }
    }
}

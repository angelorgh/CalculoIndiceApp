using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Tecnicas
{
    public partial class ChildModificarEstudiante : Form
    {
        private int estIndex;
        public ChildModificarEstudiante(int index)
        {
            estIndex = index;
            InitializeComponent();
            PopulateTextBoxes();
        }

        private void PopulateTextBoxes()
        {
            textBoxID.Text = Estudiante.Estudiantes[estIndex].ID;
            textBoxNombre.Text = Estudiante.Estudiantes[estIndex].Nombre;
            textBoxCarrera.Text = Estudiante.Estudiantes[estIndex].Carrera;

        }

        //private void Volver_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) || string.IsNullOrWhiteSpace(textBoxCarrera.Text))
            {
                MessageBox.Show("Uno de los campos esta vacio.");
            }
            else
            {
                Estudiante.Estudiantes[estIndex].Nombre = textBoxNombre.Text;
                Estudiante.Estudiantes[estIndex].Carrera = textBoxCarrera.Text;
                this.Close();
            }
        }
    }

}

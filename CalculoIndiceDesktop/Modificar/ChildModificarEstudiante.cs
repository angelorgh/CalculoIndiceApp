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
                return;
            }

            string carrera = textBoxCarrera.Text;

            foreach (char c in carrera)
            {
                if (c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' || c == '0')
                {
                    MessageBox.Show("La carrera está en formato incorrecto.");
                    return;
                }
            }

            Estudiante.Estudiantes[estIndex].Nombre = textBoxNombre.Text;
            Estudiante.Estudiantes[estIndex].Carrera = textBoxCarrera.Text;
            this.Close();
        }

        private void textBoxCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }

}

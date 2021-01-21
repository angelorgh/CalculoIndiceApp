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
    public partial class ChildModificarProfesor : Form
    {
        private int profIndex;
        public ChildModificarProfesor(int index)
        {
            profIndex = index;
            InitializeComponent();
            PopulateTextBoxes();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("Uno de los campos esta vacio.");
            }
            else
            {
                Profesor.Profesores[profIndex].Nombre = textBoxNombre.Text;
                this.Close();
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void PopulateTextBoxes()
        {
            textBoxID.Text = Profesor.Profesores[profIndex].ID;
            textBoxNombre.Text = Profesor.Profesores[profIndex].Nombre;
            

        }

        

     
    }
}

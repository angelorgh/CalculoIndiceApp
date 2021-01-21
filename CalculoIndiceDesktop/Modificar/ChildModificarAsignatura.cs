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
    public partial class ChildModificarAsignatura : Form
    {
        private int asigIndex;

        public ChildModificarAsignatura(int index)
        {
            asigIndex = index;
            InitializeComponent();
            PopulateTextBoxes();
        }

        //private void Volver_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
       
       

        private void PopulateTextBoxes()
        {
            textBoxClave.Text = Asignatura.Asignaturas[asigIndex].Clave;
            textBoxNombre.Text = Asignatura.Asignaturas[asigIndex].Nombre;
            textBoxCreditos.Text = Asignatura.Asignaturas[asigIndex].Credito.ToString();

        }

        

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) || string.IsNullOrWhiteSpace(textBoxCreditos.Text))
            {
                MessageBox.Show("Uno de los campos esta vacio.");
            }
            else
            {
                Asignatura.Asignaturas[asigIndex].Nombre = textBoxNombre.Text;
                Asignatura.Asignaturas[asigIndex].Credito = Int32.Parse(textBoxCreditos.Text);
                this.Close();
            }
        }

        
    }
}

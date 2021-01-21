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
    public partial class InsertarAsignatura : Form
    {
        public InsertarAsignatura()
        {
            InitializeComponent();
            textBoxClaveAsig1.CharacterCasing = CharacterCasing.Upper;
        }



        //private void Volver_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void Agregar_Click(object sender, EventArgs e)
        {
            string clave;
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxClaveAsig1.Text) || string.IsNullOrWhiteSpace(textBoxClaveAsig2.Text) || string.IsNullOrWhiteSpace(textBoxNombreAsig.Text) || string.IsNullOrWhiteSpace(textBoxCreditosAsig.Text))
                {
                    MessageBox.Show("Una o más lineas están vacias.");
                    return;
                }



                int claveNum = Convert.ToInt32(textBoxClaveAsig2.Text);
                string check = textBoxClaveAsig1.Text;

                foreach (char c in check)
                {
                    if (c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' || c == '0')
                    {
                        MessageBox.Show("La clave de la asignatura está en formato incorrecto.");
                        return;
                    }
                }

                clave = textBoxClaveAsig1.Text + '-' + textBoxClaveAsig2.Text;
                if (Estudiante.BuscarEstudiante(textBoxClaveAsig1.Text) != -1)
                {
                    MessageBox.Show("Ya existe una asignatura con esa clave.");
                    return;
                }


                
                int cred = Convert.ToInt32(textBoxCreditosAsig.Text);
                if (cred > 5)
                {
                    MessageBox.Show("El máximo de créditos es 5.");
                    return;
                }
                if (cred < 0)
                {
                    MessageBox.Show("El minimo de créditos es 0.");
                    return;
                }

                Asignatura asig = new Asignatura(clave, textBoxNombreAsig.Text, cred);
                asig.AgregarAsignatura();
                Program.WriteToFiles();
                this.Close();
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Los parametros estan en formato incorrecto");
            }
        }

        private void TextBoxClaveAsig2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxCreditosAsig_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxClaveAsig1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

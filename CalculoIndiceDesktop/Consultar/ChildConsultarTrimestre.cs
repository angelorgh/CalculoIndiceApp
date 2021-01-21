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
    public partial class ChildConsultarTrimestre : Form
    {
        private int EstIndex, TrimIndex;
        public ChildConsultarTrimestre(int indexEst, int indexTrim )
        {
            EstIndex = indexEst;
            TrimIndex = indexTrim;
            InitializeComponent();
            PopulateListViewAsignatura();
            PopulateTextBoxes();
        }

        private void PopulateListViewAsignatura()
        {
            listViewAsignaturas.Columns.Add("Clave");
            listViewAsignaturas.Columns.Add("Nombre");
            listViewAsignaturas.Columns.Add("Créditos");
            listViewAsignaturas.Columns.Add("Nota");

            foreach (var asig in Estudiante.Estudiantes[EstIndex].Trimestres[TrimIndex].Asignaturas)
            {
                string Nota = asig.Nota.ToString();
                if (Nota == "311")
                {
                    Nota = "R";
                }
                else if (asig.Nota >= 90 && asig.Nota <= 100)
                {
                    Nota = "A";
                }
                else if (asig.Nota >= 80 && asig.Nota <= 89)
                {
                    Nota = "B";
                }
                else if (asig.Nota >= 70 && asig.Nota <= 79)
                {
                    Nota = "C";
                }
                else if (asig.Nota >= 60 && asig.Nota <= 69)
                {
                    Nota = "D";
                }
                else if (asig.Nota >= 0 && asig.Nota <= 59)
                {
                    Nota = "F";
                }

                listViewAsignaturas.Items.Add(new ListViewItem(new string[] { asig.Clave, asig.Nombre, asig.Credito.ToString(), Nota }));
            }
            listViewAsignaturas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewAsignaturas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void PopulateTextBoxes()
        {
            int Creditos = 0;
            for (int i = 0; i < Estudiante.Estudiantes[EstIndex].Trimestres[TrimIndex].Asignaturas.Count; i++)
            {
                Creditos += Estudiante.Estudiantes[EstIndex].Trimestres[TrimIndex].Asignaturas[i].Credito;
            }
            textBoxCreditos.Text = Creditos.ToString();

            double indice = Estudiante.Estudiantes[EstIndex].Trimestres[TrimIndex].IndiceTrim;
            textBoxIndice.Text = indice.ToString();

        }

        /*private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        
    }
}

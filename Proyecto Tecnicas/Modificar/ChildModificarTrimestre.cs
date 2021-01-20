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
    public partial class ChildModificarTrimestre : Form
    {
        private int EstIndex, TrimIndex;
        public ChildModificarTrimestre(int indexEst, int indexTrim)
        {
            EstIndex = indexEst;
            TrimIndex = indexTrim;
            InitializeComponent();
            PopulateListViewAsignatura();
        }

        private void PopulateListViewAsignatura()
        {
            listViewAsignaturas.Columns.Add("Clave");
            listViewAsignaturas.Columns.Add("Nombre");
            listViewAsignaturas.Columns.Add("Créditos");

            foreach (var asig in Estudiante.Estudiantes[EstIndex].Trimestres[TrimIndex].Asignaturas)
            {
                listViewAsignaturas.Items.Add(new ListViewItem(new string[] { asig.Clave, asig.Nombre, asig.Credito.ToString() }));
            }
            listViewAsignaturas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewAsignaturas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            //string idAsig = listViewAsignaturas.CheckedItems[0].Text;
            for (int i = 0; i < listViewAsignaturas.CheckedItems.Count; i++)
            {
                string claveAsig = listViewAsignaturas.CheckedItems[i].Text;
                Estudiante.Estudiantes[EstIndex].Trimestres[TrimIndex].Asignaturas.RemoveAll(r => r.Clave == claveAsig);
                Estudiante.Estudiantes[EstIndex].Trimestres[TrimIndex].CalcularIndiceTrimestral();
            }
            Estudiante.Estudiantes[EstIndex].CalcularIndiceGeneral();
            Program.WriteToFiles();
            this.Close();
        }
    }
}

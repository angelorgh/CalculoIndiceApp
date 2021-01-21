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
    public partial class EliminarEstudiante : Form
    {
        public EliminarEstudiante()
        {
            InitializeComponent();
        }
        private void setUpEventHandlers()
        {
            textBoxBuscarEst.TextChanged += textBoxBuscarEst_TextChanged;

        }

        private void EliminarEstudiante_Load(object sender, EventArgs e)
        {
            PopulateListViewEstudiante();
            setUpEventHandlers();

        }
        private void PopulateListViewEstudiante()
        {
            listViewEstudiantes.Columns.Add("ID");
            listViewEstudiantes.Columns.Add("Nombre");
            listViewEstudiantes.Columns.Add("Carrera");


            foreach (var est in Estudiante.Estudiantes)
            {
                listViewEstudiantes.Items.Add(new ListViewItem(new string[] { est.ID, est.Nombre, est.Carrera }));
            }
            listViewEstudiantes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewEstudiantes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void searchDataEst(string searchTerm)
        {
            listViewEstudiantes.Items.Clear();
            foreach (var est in Estudiante.Estudiantes)
            {
                if (est.ID.ToLower().Contains(searchTerm.ToLower()) || est.Nombre.ToLower().Contains(searchTerm.ToLower()) || est.Carrera.ToLower().Contains(searchTerm.ToLower()))
                {
                    listViewEstudiantes.Items.Add(new ListViewItem(new string[] { est.ID, est.Nombre, est.Carrera }));
                }
            }
        }

        private void textBoxBuscarEst_TextChanged(object sender, EventArgs e)
        {
            searchDataEst(textBoxBuscarEst.Text);
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewEstudiantes.CheckedItems.Count; i++)
            {
                string id = listViewEstudiantes.CheckedItems[i].Text;
                Estudiante.BorrarEstudiante(id);
            }
            Program.WriteToFiles();
            this.Close();
        }
    }
}

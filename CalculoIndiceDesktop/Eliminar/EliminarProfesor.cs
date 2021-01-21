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
    public partial class EliminarProfesor : Form
    {
        public EliminarProfesor()
        {
            InitializeComponent();
        }

        private void setUpEventHandlers()
        {
            textBoxBuscarProf.TextChanged += textBoxBuscarProf_TextChanged;

        }
        private void EliminarProfesor_Load(object sender, EventArgs e)
        {
            PopulateListViewProfesores();
            setUpEventHandlers();
        }

        private void PopulateListViewProfesores()
        {
            listViewProfesores.Columns.Add("ID");
            listViewProfesores.Columns.Add("Nombre");


            foreach (var prof in Profesor.Profesores)
            {
                listViewProfesores.Items.Add(new ListViewItem(new string[] { prof.ID, prof.Nombre}));
            }
            listViewProfesores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewProfesores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void searchDataProf(string searchTerm)
        {
            listViewProfesores.Items.Clear();
            foreach (var prof in Profesor.Profesores)
            {
                if (prof.ID.ToLower().Contains(searchTerm.ToLower()) || prof.Nombre.ToLower().Contains(searchTerm.ToLower()))
                {
                    listViewProfesores.Items.Add(new ListViewItem(new string[] { prof.ID, prof.Nombre}));
                }
            }
        }

        private void textBoxBuscarProf_TextChanged(object sender, EventArgs e)
        {
            searchDataProf(textBoxBuscarProf.Text);
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewProfesores.CheckedItems.Count; i++)
            {
                string id = listViewProfesores.CheckedItems[i].Text;
                Profesor.BorrarProfesor(id);
            }
            Program.WriteToFiles();
            this.Close();
        }

        //private void Volver_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
    }
}

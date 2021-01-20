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
    public partial class ModificarProfesor : Form
    {
        public ModificarProfesor()
        {
            InitializeComponent();
            setUpEventHandlers();
        }

        private void ModificarProfesor_Load(object sender, EventArgs e)
        {
            PopulateListViewProfesor();
            setUpEventHandlers();
        }
        private void PopulateListViewProfesor()
        {
            listViewProfesores.Columns.Clear();
            listViewProfesores.Columns.Add("ID");
            listViewProfesores.Columns.Add("Nombre");
            listViewProfesores.Items.Clear();

            foreach (var prof in Profesor.Profesores)
            {
                listViewProfesores.Items.Add(new ListViewItem(new string[] { prof.ID, prof.Nombre }));
            }
            listViewProfesores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewProfesores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

      
        private void setUpEventHandlers()
        {
            textBoxBuscarProf.TextChanged += textBoxBuscarProf_TextChanged;
        }

        private void ListViewProfesores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string IDProf = listViewProfesores.SelectedItems[0].Text;
            int indexProf = Profesor.BuscarProfesor(IDProf);


            ChildModificarProfesor formChildModProf = new ChildModificarProfesor(indexProf);
            formChildModProf.ShowDialog();
            PopulateListViewProfesor();
            //    string IDEst = listViewEstudiantes.SelectedItems[0].Text;
            //    int indexEst = Estudiante.BuscarEstudiante(IDEst);


            //    ChildModificarEstudiante formChildModEst = new ChildModificarEstudiante(indexEst);
            //    formChildModEst.ShowDialog();
            //}
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

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

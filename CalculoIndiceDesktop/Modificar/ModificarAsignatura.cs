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
    public partial class ModificarAsignatura : Form
    {
        public ModificarAsignatura()
        {
            InitializeComponent();
        }

        private void ListViewAsignaturas_Load(object sender, EventArgs e)
        {
            PopulateListViewAsignatura();
            setUpEventHandlers();
        }
        private void PopulateListViewAsignatura()
        {
            listViewAsignaturas.Columns.Clear();
            listViewAsignaturas.Columns.Add("Claves");
            listViewAsignaturas.Columns.Add("Nombres");
            listViewAsignaturas.Columns.Add("Creditos");
            listViewAsignaturas.Items.Clear();
            foreach (var asig in Asignatura.Asignaturas)
            {
                listViewAsignaturas.Items.Add(new ListViewItem(new string[] { asig.Clave, asig.Nombre, asig.Credito.ToString() }));
            }
            listViewAsignaturas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewAsignaturas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

        private void setUpEventHandlers()
        {
            textBoxBuscarAsig.TextChanged += textBoxBuscarAsig_TextChanged;
        }

        private void ListViewAsignaturas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //string[] data = {listViewTrimestres.SelectedItems[0].SubItems[0].Text, listViewTrimestres.SelectedItems[0].SubItems[1].Text, listViewTrimestres.SelectedItems[0].SubItems[2].Text };
            string IDAsig = listViewAsignaturas.SelectedItems[0].Text;
            int indexAsig = Asignatura.BuscarAsignatura(IDAsig);
            ChildModificarAsignatura formChildModAsig = new ChildModificarAsignatura(indexAsig);
            formChildModAsig.ShowDialog();
            PopulateListViewAsignatura();
        }

        private void searchDataAsig(string searchTerm)
        {
            listViewAsignaturas.Items.Clear();
            foreach (var asig in Asignatura.Asignaturas)
            {
                if (asig.Clave.ToLower().Contains(searchTerm.ToLower()) || asig.Nombre.ToLower().Contains(searchTerm.ToLower()) || asig.Credito.ToString().Contains(searchTerm.ToLower()))
                    listViewAsignaturas.Items.Add(new ListViewItem(new string[] { asig.Clave, asig.Nombre, asig.Credito.ToString() }));
            }
        }
        private void textBoxBuscarAsig_TextChanged(object sender, EventArgs e)
        {
            searchDataAsig(textBoxBuscarAsig.Text);
        }

        //private void Volver_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
    }
}
        

    


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
    public partial class EliminarAsignatura : Form
    {
        public EliminarAsignatura()
        {
            InitializeComponent();
            PopulateListViewAsignatura();
            setUpEventHandlers();
        }
        private void setUpEventHandlers()
        {
            textBoxBuscarAsig.TextChanged += textBoxBuscarAsig_TextChanged;
        }

        private void EliminarAsignatura_Load(object sender, EventArgs e)
        {

        }

        private void PopulateListViewAsignatura()
        {
            listViewAsignaturas.Columns.Add("Clave");
            listViewAsignaturas.Columns.Add("Nombre");
            listViewAsignaturas.Columns.Add("Créditos");

            foreach (var asig in Asignatura.Asignaturas)
            {
                listViewAsignaturas.Items.Add(new ListViewItem(new string[] { asig.Clave, asig.Nombre, asig.Credito.ToString() }));
            }
            listViewAsignaturas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewAsignaturas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void searchDataAsig(string searchTerm)
        {
            listViewAsignaturas.Items.Clear();
            foreach (var asig in Asignatura.Asignaturas)
            {
                if (asig.Clave.ToLower().Contains(searchTerm.ToLower()) || asig.Nombre.ToLower().Contains(searchTerm.ToLower()) || asig.Credito.ToString().Contains(searchTerm.ToLower()))
                {
                    listViewAsignaturas.Items.Add(new ListViewItem(new string[] { asig.Clave, asig.Nombre, asig.Credito.ToString() }));
                }
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

        private void Borrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewAsignaturas.CheckedItems.Count; i++)
            {
                string clave = listViewAsignaturas.CheckedItems[i].Text;
                Asignatura.BorrarAsignatura(clave);
            }
            Program.WriteToFiles();
            this.Close();
        }
    }
}

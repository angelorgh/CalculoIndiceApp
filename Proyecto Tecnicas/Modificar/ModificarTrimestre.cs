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
    public partial class ModificarTrimestre : Form
    {
        public ModificarTrimestre()
        {
            InitializeComponent();
        }

        private void ModificarTrimestre_Load(object sender, EventArgs e)
        {
            listViewTrimestres.Items.Clear();
            listViewTrimestres.Columns.Add("Meses");
            listViewTrimestres.Columns.Add("Año Inicio");
            listViewTrimestres.Columns.Add("Año Fin");
            listViewTrimestres.Columns.Add("Cantidad de Asignaturas");
            listViewTrimestres.Columns.Add("Cantidad de Créditos");
            listViewEstudiantes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewEstudiantes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            PopulateListViewEstudiante();
            //PopulateListViewTrimestres();
            setUpEventHandlers();
        }

        private void setUpEventHandlers()
        {
            textBoxBuscarEst.TextChanged += textBoxBuscarEst_TextChanged;
            //listViewEstudiantes.ItemCheck += listViewEstudiantes_ItemCheck;
            listViewEstudiantes.ItemChecked += ListViewEstudiantes_ItemChecked;
        }



        #region Check Para Solo un Item


        //private void listViewEstudiantes_ItemCheck(object sender, ItemCheckEventArgs e)
        //{
        //    if (lastItemChecked != null && lastItemChecked.Checked && lastItemChecked != listViewEstudiantes.Items[e.Index])
        //    {
        //        lastItemChecked.Checked = false;
        //    }
        //    lastItemChecked = listViewEstudiantes.Items[e.Index];
        //}
        #endregion

        #region Search Methods
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

        #endregion

        #region Populate
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
            //listViewEstudiantes.Items[0].Checked = true;
            //lastItemChecked = listViewEstudiantes.Items[0];

        }
        private void PopulateListViewTrimestres()
        {
            if (listViewEstudiantes.CheckedItems.Count > 0)
            {
                listViewTrimestres.Items.Clear();
                int index = Estudiante.BuscarEstudiante(listViewEstudiantes.CheckedItems[0].Text); // CRASHES HERE

                foreach (var trim in Estudiante.Estudiantes[index].Trimestres)
                {
                    int suma = 0;
                    foreach (var asig in trim.Asignaturas)
                    {
                        suma += asig.Credito;
                    }
                    ListViewItem item = new ListViewItem(new string[] { trim.Meses, trim.añoInicio, trim.añoFin, trim.Asignaturas.Count.ToString(), suma.ToString() });
                    item.Tag = trim.ID;
                    listViewTrimestres.Items.Add(item);
                }
                listViewTrimestres.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewTrimestres.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                return;
            }

        }
        #endregion

        #region Events
        private ListViewItem lastItemChecked;
        private void ListViewEstudiantes_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lastItemChecked != null && lastItemChecked.Checked && lastItemChecked != e.Item)
            {
                lastItemChecked.Checked = false;
            }
            lastItemChecked = e.Item;
            PopulateListViewTrimestres();
        }
        #endregion



        private void ListViewTrimestres_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //string[] data = {listViewTrimestres.SelectedItems[0].SubItems[0].Text, listViewTrimestres.SelectedItems[0].SubItems[1].Text, listViewTrimestres.SelectedItems[0].SubItems[2].Text };
            string IDTrim = listViewTrimestres.SelectedItems[0].Tag.ToString();
            string IDEst = listViewEstudiantes.CheckedItems[0].Text;
            int indexEst = Estudiante.BuscarEstudiante(IDEst);
            int indexTrim = Estudiante.Estudiantes[indexEst].BuscarTrimestre(IDTrim);

            ChildModificarTrimestre formModTrim = new ChildModificarTrimestre(indexEst, indexTrim);
            formModTrim.ShowDialog();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

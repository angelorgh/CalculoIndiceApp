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
    public partial class ConsultarTrimestreEst : Form
    {
        string ID;
        public ConsultarTrimestreEst(string id)
        {
            ID = id;
            InitializeComponent();
        }

        //private void Volver_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void ConsultarTrimestre_Load(object sender, EventArgs e)
        {
            listViewTrimestres.Items.Clear();
            listViewTrimestres.Columns.Add("Meses");
            listViewTrimestres.Columns.Add("Año Inicio");
            listViewTrimestres.Columns.Add("Año Fin");
            listViewTrimestres.Columns.Add("Cantidad de Asignaturas");
            listViewTrimestres.Columns.Add("Cantidad de Créditos");
            

            PopulateListViewTrimestres();
            setUpEventHandlers();
        }

        private void setUpEventHandlers()
        {
            //listViewEstudiantes.ItemCheck += listViewEstudiantes_ItemCheck;
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
        

        

        #endregion

        #region Populate
        
        private void PopulateListViewTrimestres()
        {
            listViewTrimestres.Items.Clear();
            int index = Estudiante.BuscarEstudiante(ID); // CRASHES HERE

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
            int indexEst = Estudiante.BuscarEstudiante(ID);
            int indexTrim = Estudiante.Estudiantes[indexEst].BuscarTrimestre(IDTrim);
            ChildConsultarTrimestre formChildConsTrim = new ChildConsultarTrimestre(indexEst, indexTrim);
            formChildConsTrim.ShowDialog();
        }
    }
}

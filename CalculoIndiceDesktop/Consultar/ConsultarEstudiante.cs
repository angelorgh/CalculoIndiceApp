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
    public partial class ConsultarEstudiante : Form
    {
        public ConsultarEstudiante()
        {
            InitializeComponent();
        }

        private void InsertarEstudiante_Load(object sender, EventArgs e)
        {
            PopulateListViewEstudiante();
        }

        private void PopulateListViewEstudiante()
        {
            
            listViewEstudiantes.Columns.Add("ID");
            listViewEstudiantes.Columns.Add("Nombre");
            listViewEstudiantes.Columns.Add("Carrera");
            listViewEstudiantes.Columns.Add("Indice");
            listViewEstudiantes.Columns.Add("Honores");



            foreach (var est in Estudiante.Estudiantes)
            {
                listViewEstudiantes.Items.Add(new ListViewItem(new string[] { est.ID, est.Nombre, est.Carrera, est.IndiceGeneral.ToString(), est.Honores}));
            }
            listViewEstudiantes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewEstudiantes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //private void ButtonVolver_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
    }
}

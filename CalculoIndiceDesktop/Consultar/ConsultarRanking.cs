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
    public partial class ConsultarRanking : Form
    {
        public ConsultarRanking()
        {
            InitializeComponent();
        }

        //private void Volver_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void ConsultarRanking_Load(object sender, EventArgs e)
        {
            PopulateListViewEstudiante();
        }

        private void PopulateListViewEstudiante()
        {
            List<Estudiante> sorted = Estudiante.Estudiantes;
            sorted.Sort();
            sorted.Reverse();

            listViewEstudiantes.Columns.Add("ID");
            listViewEstudiantes.Columns.Add("Nombre");
            listViewEstudiantes.Columns.Add("Carrera");
            listViewEstudiantes.Columns.Add("Indice General");
            listViewEstudiantes.Columns.Add("Honores");

            

            foreach (var est in sorted)
            {
                double indice = (est.IndiceGeneral > 0) ? est.IndiceGeneral : 0;
                string honores = (!String.IsNullOrEmpty(est.Honores)) ? est.Honores : "N/H";
                listViewEstudiantes.Items.Add(new ListViewItem(new[] {est.ID, est.Nombre, est.Carrera, indice.ToString(), honores}));
            }
            listViewEstudiantes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewEstudiantes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}

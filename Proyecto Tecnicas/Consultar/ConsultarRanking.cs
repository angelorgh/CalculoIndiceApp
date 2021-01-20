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

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                listViewEstudiantes.Items.Add(new ListViewItem(new[] {est.ID, est.Nombre, est.Carrera, est.IndiceGeneral.ToString(), est.Honores }));
            }
            listViewEstudiantes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewEstudiantes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}

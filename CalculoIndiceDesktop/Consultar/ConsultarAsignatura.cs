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
    public partial class ConsultarAsignatura : Form
    {
        public ConsultarAsignatura()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        //private void ButtonVolver_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void ListViewAsignaturas_Load(object sender, EventArgs e)
        {
            PopulateListAsignatura();
        }
        private void PopulateListAsignatura()
        {
            
            listViewAsignaturas.Columns.Add("Clave");
            listViewAsignaturas.Columns.Add("Nombre");
            listViewAsignaturas.Columns.Add("Credito");

            foreach (var asig in Asignatura.Asignaturas)
            {
                //listViewEstudiantes.Items.Add(new ListViewItem(new string[] { est.ID, est.Nombre, est.Carrera }));
                listViewAsignaturas.Items.Add(new ListViewItem(new string[] { asig.Clave, asig.Nombre, asig.Credito.ToString()}));
            }
            listViewAsignaturas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewAsignaturas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
    }
}

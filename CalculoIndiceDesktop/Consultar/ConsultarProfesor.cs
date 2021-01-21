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
    public partial class ConsultarProfesor : Form
    {
        public ConsultarProfesor()
        {
            InitializeComponent();
        }

        //private void ButtonVolver_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void ListProfesores_Load(object sender, EventArgs e)
        {
            PopulateListViewProfesores();

        }
        private void PopulateListViewProfesores()
        {
           
            listViewProfesores.Columns.Add("ID");
            listViewProfesores.Columns.Add("Nombre");

            foreach (var prof in Profesor.Profesores)
            {
                
                listViewProfesores.Items.Add(new ListViewItem(new string[] { prof.ID, prof.Nombre }));
            }
            listViewProfesores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewProfesores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}

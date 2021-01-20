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
    public partial class InsertarTrimestre : Form
    {
        public InsertarTrimestre()
        {
            InitializeComponent();
        }

        private void InsertarTrimestre_Load(object sender, EventArgs e)
        {
            PopulateListViewEstudiante();
            PopulateListViewAsignatura();
            PopulateComboBoxes();
            setUpEventHandlers();
        }

        private void setUpEventHandlers()
        {
            Load += InsertarTrimestre_Load;
            textBoxBuscarEst.TextChanged += textBoxBuscarEst_TextChanged;
            textBoxBuscarAsig.TextChanged += textBoxBuscarAsig_TextChanged;
            listViewAsignaturas.ItemChecked += listViewAsignaturas_ItemChecked;
            listViewEstudiantes.ItemCheck += listViewEstudiantes_ItemCheck;

        }



        private void PopulateListViewEstudiante()
        {
            
            listViewEstudiantes.Columns.Add("ID");
            listViewEstudiantes.Columns.Add("Nombre");
            listViewEstudiantes.Columns.Add("Carrera");
            

            foreach (var est in Estudiante.Estudiantes)
            {
                listViewEstudiantes.Items.Add(new ListViewItem(new string[] {est.ID, est.Nombre, est.Carrera}));
            }
            listViewEstudiantes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewEstudiantes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void PopulateListViewAsignatura()
        {
            listViewAsignaturas.Columns.Add("Clave");
            listViewAsignaturas.Columns.Add("Nombre");
            listViewAsignaturas.Columns.Add("Créditos");

            foreach (var asig in Asignatura.Asignaturas)
            {
                listViewAsignaturas.Items.Add(new ListViewItem(new string[] {asig.Clave, asig.Nombre,asig.Credito.ToString() }));
            }
            listViewAsignaturas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewAsignaturas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void PopulateComboBoxes()
        {
            comboBoxMeses.Items.AddRange(new[] {"Enero-Marzo","Febrero-Abril","Mayo-Julio" ,"Agosto-Octubre", "Noviembre-Enero"});
            comboBoxAñoInicio.Items.AddRange(new[] {"2019","2020","2021", "2022","2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"});
            comboBoxAñoFin.Items.AddRange(new[] {"2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"});
        }

        private ListViewItem lastItemChecked;

        private void listViewEstudiantes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
 
            if (lastItemChecked != null && lastItemChecked.Checked
                && lastItemChecked != listViewEstudiantes.Items[e.Index])
            {
                lastItemChecked.Checked = false;
            }
            lastItemChecked = listViewEstudiantes.Items[e.Index];
        }

        private void searchDataEst(string searchTerm)
        {
            listViewEstudiantes.Items.Clear();
            foreach (var est in Estudiante.Estudiantes)
            {
                if (est.ID.ToLower().Contains(searchTerm.ToLower()) || est.Nombre.ToLower().Contains(searchTerm.ToLower()) || est.Carrera.ToLower().Contains(searchTerm.ToLower()))
                {
                    listViewEstudiantes.Items.Add(new ListViewItem(new string[] {est.ID, est.Nombre, est.Carrera}));
                }
            }
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

        private void textBoxBuscarEst_TextChanged(object sender, EventArgs e)
        {
            searchDataEst(textBoxBuscarEst.Text);
        }

        private void textBoxBuscarAsig_TextChanged(object sender, EventArgs e)
        {
            searchDataAsig(textBoxBuscarAsig.Text);
        }

        private void listViewAsignaturas_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int suma = 0;
            int value;
            foreach (ListViewItem item in listViewAsignaturas.CheckedItems)
            {
                value = Convert.ToInt32(item.SubItems[2].Text);
                if ((suma + value) > 21)
                {
                    MessageBox.Show("El máximo de créditos es 21.");
                    e.Item.Checked = false;
                }
                else
                {
                    suma += value;
                }
            }
            textBoxCreditos.Text = suma.ToString();

        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {

            if ((listViewEstudiantes.CheckedItems.Count < 0 || listViewAsignaturas.CheckedItems.Count < 0 || comboBoxAñoInicio.SelectedIndex == -1 || comboBoxAñoFin.SelectedIndex == -1 || comboBoxMeses.SelectedIndex == -1))
            {
                MessageBox.Show("Uno o más campos estan sin llenar.");
                return;
            }
            
            Trimestre trim = new Trimestre();

            string meses = comboBoxMeses.SelectedItem.ToString();
            string añoInicio = comboBoxAñoInicio.SelectedItem.ToString();
            string añoFin = comboBoxAñoFin.SelectedItem.ToString();

            trim.Meses = meses;
            trim.añoInicio = añoInicio;
            trim.añoFin = añoFin;

            int indexEst = Estudiante.BuscarEstudiante(listViewEstudiantes.CheckedItems[0].Text);

            for (int i = 0; i < listViewAsignaturas.CheckedItems.Count; i++)
            {
                int indexAsig = Asignatura.BuscarAsignatura(listViewAsignaturas.CheckedItems[i].Text);
                Asignatura md = Asignatura.Asignaturas[indexAsig];
                //trim.Asignaturas.Add(Asignatura.Asignaturas[indexAsig]);
                //trim.Asignaturas.Add(md);
                trim.Asignaturas.Add(Clone(md));
            }
            Estudiante.Estudiantes[indexEst].Trimestres.Add(trim);
            Program.WriteToFiles();
            this.Close();
        }

        private void ButtonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Asignatura Clone(Asignatura asig)
        {
            Asignatura clone = new Asignatura();
            clone.Clave = asig.Clave;
            clone.Nombre = asig.Nombre;
            clone.Credito = asig.Credito;
            return clone;
        }
    }
}

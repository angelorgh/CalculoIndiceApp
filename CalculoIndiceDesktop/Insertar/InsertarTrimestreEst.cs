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
    public partial class InsertarTrimestreEst : Form
    {
        string ID;
        public InsertarTrimestreEst(string Id)
        {
            ID = Id;
            InitializeComponent();
        }
        private void InsertarTrimestre_Load(object sender, EventArgs e)
        {
            PopulateListViewAsignatura();
            PopulateComboBoxes();
            setUpEventHandlers();
        }

        private void setUpEventHandlers()
        {
            Load += InsertarTrimestre_Load;
            textBoxBuscarAsig.TextChanged += textBoxBuscarAsig_TextChanged;
            listViewAsignaturas.ItemChecked += listViewAsignaturas_ItemChecked;

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
            comboBoxMeses.Items.AddRange(new[] {"Noviembre-Enero", "Febrero-Abril", "Mayo-Julio","Agosto-Octubre"});
            comboBoxAñoInicio.Items.AddRange(new[] {"2020","2021", "2022","2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"});
            comboBoxAñoFin.Items.AddRange(new[] {"2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"});
        }

        private ListViewItem lastItemChecked;


        
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
            
            if ((listViewAsignaturas.CheckedItems.Count < 0 || comboBoxAñoInicio.SelectedIndex == -1 || comboBoxAñoFin.SelectedIndex == -1 || comboBoxMeses.SelectedIndex == -1))
            {
                MessageBox.Show("Uno o más campos estan sin llenar.");
                return;
            }

            try
            {
                if (Convert.ToInt32(comboBoxAñoInicio.SelectedItem.ToString()) > Convert.ToInt32(comboBoxAñoFin.SelectedItem.ToString()))
                {
                    MessageBox.Show("No puede seleccionar un año Inicio mayor que el Final");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No puede seleccionar un año Inicio mayor que el Final");
                return;
            }

            /*if (Convert.ToInt32(comboBoxAñoFin.SelectedItem.ToString()) != Convert.ToInt32(comboBoxAñoFin.SelectedItem.ToString()) + 1)
            {
                if (Convert.ToInt32(comboBoxAñoFin.SelectedItem.ToString()) != Convert.ToInt32(comboBoxAñoFin.SelectedItem.ToString()))
                {
                    MessageBox.Show("El rango de tiempo entre años es muy grande");

                }
            }*/

            Trimestre trim = new Trimestre();

            string meses = comboBoxMeses.SelectedItem.ToString();
            string añoInicio = comboBoxAñoInicio.SelectedItem.ToString();
            string añoFin = comboBoxAñoFin.SelectedItem.ToString();

            trim.Meses = meses;
            trim.añoInicio = añoInicio;
            trim.añoFin = añoFin;

            int indexEst = Estudiante.BuscarEstudiante(ID);

            for (int i = 0; i < listViewAsignaturas.CheckedItems.Count; i++)
            {
                int indexAsig = Asignatura.BuscarAsignatura(listViewAsignaturas.CheckedItems[i].Text);
                Asignatura md = Asignatura.Asignaturas[indexAsig];
                //trim.Asignaturas.Add(Asignatura.Asignaturas[indexAsig]);
                trim.Asignaturas.Add(md);
            }
            Estudiante.Estudiantes[indexEst].Trimestres.Add(trim);
            Program.WriteToFiles();
            this.Close();
        }

        //private void ButtonVolver_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
    }
}

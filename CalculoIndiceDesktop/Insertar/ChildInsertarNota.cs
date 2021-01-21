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
    public partial class ChildInsertarNota : Form
    {
        private int estIndexing;
        private int trimIndexing;

        public ChildInsertarNota(int estIndex, int trimIndex)
        {
            estIndexing = estIndex;
            trimIndexing = trimIndex;
            InitializeComponent();
            
        }

        private void ChildInsertarNota_Load(object sender, EventArgs e)
        {
            PopulateListViewEstudiante(estIndexing);
            PopulateListViewTrimestre(estIndexing, trimIndexing);
            PopulateDataGridViewAsignaturas(estIndexing, trimIndexing);
        }

        private void PopulateListViewEstudiante(int estIndex)
        {
            listViewEstudiante.Columns.Add("ID");
            listViewEstudiante.Columns.Add("Nombre");
            listViewEstudiante.Columns.Add("Carrera");
            listViewEstudiante.Items.Add(new ListViewItem(new[] {Estudiante.Estudiantes[estIndex].ID, Estudiante.Estudiantes[estIndex].Nombre, Estudiante.Estudiantes[estIndex].Carrera}));
            listViewEstudiante.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewEstudiante.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void PopulateListViewTrimestre(int estIndex, int trimIndex)
        {
            listViewTrimestre.Columns.Add("Meses");
            listViewTrimestre.Columns.Add("Año Inicio");
            listViewTrimestre.Columns.Add("Año Fin");
            listViewTrimestre.Columns.Add("Cantidad de Asignaturas");
            listViewTrimestre.Columns.Add("Cantidad de Créditos");

            int suma = 0;

            foreach (var asig in Estudiante.Estudiantes[estIndex].Trimestres[trimIndex].Asignaturas)
            {
                suma += asig.Credito;
            }
            listViewTrimestre.Items.Add(new ListViewItem(new[] {Estudiante.Estudiantes[estIndex].Trimestres[trimIndex].Meses, Estudiante.Estudiantes[estIndex].Trimestres[trimIndex].añoInicio,
                Estudiante.Estudiantes[estIndex].Trimestres[trimIndex].añoFin, Estudiante.Estudiantes[estIndex].Trimestres[trimIndex].Asignaturas.Count.ToString(), suma.ToString() }));
            listViewTrimestre.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewTrimestre.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void PopulateDataGridViewAsignaturas(int estIndex, int trimIndex)
        {
            dataGridViewAsignaturas.ColumnCount = 4;
            dataGridViewAsignaturas.Columns[0].Name = "Clave";
            dataGridViewAsignaturas.Columns[1].Name = "Nombre";
            dataGridViewAsignaturas.Columns[2].Name = "Créditos";
            dataGridViewAsignaturas.Columns[3].Name = "Nota";

            dataGridViewAsignaturas.ReadOnly = false;
            dataGridViewAsignaturas.Columns[0].ReadOnly = true;
            dataGridViewAsignaturas.Columns[1].ReadOnly = true;
            dataGridViewAsignaturas.Columns[2].ReadOnly = true;

            


            foreach (var asig in Estudiante.Estudiantes[estIndex].Trimestres[trimIndex].Asignaturas)
            {
                if (asig.Nota == 0)
                {
                    dataGridViewAsignaturas.Rows.Add(new string[] { asig.Clave, asig.Nombre, asig.Credito.ToString(), "n/a" });

                }
                else if (asig.Nota == 311)
                {
                    dataGridViewAsignaturas.Rows.Add(new string[] { asig.Clave, asig.Nombre, asig.Credito.ToString(), "R" });
                }
                else
                {
                    dataGridViewAsignaturas.Rows.Add(new string[] { asig.Clave, asig.Nombre, asig.Credito.ToString(), asig.Nota.ToString() });
                }
                
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewAsignaturas.Rows.Count; i++)
            {
                try
                {
                    int Nota = Convert.ToInt32(dataGridViewAsignaturas.Rows[i].Cells[3].Value.ToString());
                    if (Nota < 0 || Nota > 100)
                    {
                        MessageBox.Show("Una de las notas introducidas es incorrecta.");
                        return;
                    }

                    string asigClave = dataGridViewAsignaturas.Rows[i].Cells[0].Value.ToString();
                    int asigIndexing = Estudiante.Estudiantes[estIndexing].Trimestres[trimIndexing].BuscarAsignatura(asigClave);
                    //Asignatura ffs = Estudiante.Estudiantes[estIndexing].Trimestres[trimIndexing].Asignaturas[asigIndexing];
                    //ffs.Nota = Nota;
                    Estudiante.Estudiantes[estIndexing].Trimestres[trimIndexing].Asignaturas[asigIndexing].Nota = Nota;

                }
                catch (FormatException)
                {
                    if (dataGridViewAsignaturas.Rows[i].Cells[3].Value.ToString() == "R")
                    {
                        string asigClave = dataGridViewAsignaturas.Rows[i].Cells[0].Value.ToString();
                        int asigIndexing = Estudiante.Estudiantes[estIndexing].Trimestres[trimIndexing].BuscarAsignatura(asigClave);
                        Estudiante.Estudiantes[estIndexing].Trimestres[trimIndexing].Asignaturas[asigIndexing].Nota = 311;
                    }
                    else
                    {
                        MessageBox.Show("Una de las notas introducidas es incorrecta.");
                        return;
                    }
                }
                catch (NullReferenceException)
                {
                    if (dataGridViewAsignaturas.Rows[i].Cells[3].Value.ToString() == "R")
                    {
                        string asigClave = dataGridViewAsignaturas.Rows[i].Cells[0].Value.ToString();
                        int asigIndexing = Estudiante.Estudiantes[estIndexing].Trimestres[trimIndexing].BuscarAsignatura(asigClave);
                        Estudiante.Estudiantes[estIndexing].Trimestres[trimIndexing].Asignaturas[asigIndexing].Nota = 311;
                    }
                    else
                    {
                        MessageBox.Show("Una de las notas introducidas es incorrecta.");
                        return;
                    }
                }

            }
            Estudiante.Estudiantes[estIndexing].Trimestres[trimIndexing].CalcularIndiceTrimestral();  // ESTO ES PARA PRUEBA
            Estudiante.Estudiantes[estIndexing].CalcularIndiceGeneral();

            Program.WriteToFiles();
            this.Close();
        }


    }
}

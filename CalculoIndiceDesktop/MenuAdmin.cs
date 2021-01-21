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
    public partial class MenuAdmin : Form
    {

        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void EstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarEstudiante formEst = new InsertarEstudiante();
            formEst.ShowDialog();
        }

        private void AsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarAsignatura formAsig = new InsertarAsignatura();
            formAsig.ShowDialog();
        }

        private void ProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarProfesor formProf = new InsertarProfesor();
            formProf.ShowDialog();
        }

        private void TrimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarTrimestre formTrim = new InsertarTrimestre();
            formTrim.ShowDialog();
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarEstudiante formCons = new ConsultarEstudiante();
            formCons.ShowDialog();
        }

        private void ProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProfesor formConsProf = new ConsultarProfesor();
            formConsProf.ShowDialog();
        }

        private void AsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarAsignatura formConsAsig = new ConsultarAsignatura();
            formConsAsig.ShowDialog();
        }

        private void CalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarCalificaciones formConsCalif = new InsertarCalificaciones();
            formConsCalif.ShowDialog();
        }

        private void CalificacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InsertarCalificaciones formConsCalif = new InsertarCalificaciones();
            formConsCalif.ShowDialog();
        }

        private void EstudianteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EliminarEstudiante formElimEst = new EliminarEstudiante();
            formElimEst.ShowDialog();
        }

        private void AsignaturaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EliminarAsignatura formElimAsig = new EliminarAsignatura();
            formElimAsig.ShowDialog();
        }

        private void ProfesorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EliminarProfesor formElimProf = new EliminarProfesor();
            formElimProf.ShowDialog();
        }

        private void TrimestreToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EliminarTrimestre formElimTrim = new EliminarTrimestre();
            formElimTrim.ShowDialog();
        }

        private void EstudianteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificarEstudiante formModEst = new ModificarEstudiante();
            formModEst.ShowDialog();
        }

        private void AsignaturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificarAsignatura formModAsig = new ModificarAsignatura();
            formModAsig.ShowDialog();
        }

        private void ProfesorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificarProfesor formModProf = new ModificarProfesor();
            formModProf.ShowDialog();
        }

        private void TrimestresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarTrimestre formConsCliente = new ConsultarTrimestre();
            formConsCliente.ShowDialog();
        }

        private void TrimestreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificarTrimestre formModTrim = new ModificarTrimestre();
            formModTrim.ShowDialog();
        }

        private void RankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarRanking formConsRank = new ConsultarRanking();
            formConsRank.ShowDialog();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
        }

        private void ButtonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProvider.MainMenu.Show();
        }
    }
}

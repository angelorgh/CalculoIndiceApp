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
    public partial class MenuProfesor : Form
    {
        string ID;
        public MenuProfesor(string id)
        {
            ID = id;
            InitializeComponent();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarCalificaciones insCal = new InsertarCalificaciones();
            insCal.ShowDialog();
        }

        private void MenuProfesor_Load(object sender, EventArgs e)
        {
            labelID.Text = ID;
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarEstudiante consEst = new ConsultarEstudiante();
            consEst.ShowDialog();
        }

        private void AsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarAsignatura consAsig = new ConsultarAsignatura();
            consAsig.ShowDialog();
        }

        private void RankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarRanking consRank = new ConsultarRanking();
            consRank.ShowDialog();
        }

        private void ButtonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProvider.MainMenu.Show();
        }
    }
}

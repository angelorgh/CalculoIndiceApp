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
    public partial class MenuEstudiante : Form
    {
        string ID;
        public MenuEstudiante(string id)
        {
            ID = id;
            InitializeComponent();
        }

        private void TrimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarTrimestreEst insTrimEst = new InsertarTrimestreEst(ID);
            insTrimEst.ShowDialog();
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

        private void TrimestresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarTrimestreEst consultarTrimestreEst = new ConsultarTrimestreEst(ID);
            consultarTrimestreEst.ShowDialog();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuEstudiante_Load(object sender, EventArgs e)
        {
            labelID.Text = ID;
        }

        private void ButtonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProvider.MainMenu.Show();
        }
    }
}

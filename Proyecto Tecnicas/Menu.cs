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
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
        }

        private void ButtonEstudiante_Click(object sender, EventArgs e)
        {
            FormProvider.MainMenu.Hide();
            LoginEstudiante logEst = new LoginEstudiante();
            logEst.ShowDialog();

        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            FormProvider.MainMenu.Hide();
            LoginAdmin logAdmin = new LoginAdmin();
            logAdmin.ShowDialog();

        }

        private void ButtonProfesor_Click(object sender, EventArgs e)
        {
            FormProvider.MainMenu.Hide();
            LoginProfesor logProf = new LoginProfesor();
            logProf.ShowDialog();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

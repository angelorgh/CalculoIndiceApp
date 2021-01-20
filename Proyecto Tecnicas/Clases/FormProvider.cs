using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tecnicas
{
    public class FormProvider
    {
        private static Menu mainMenu;
        public static Menu MainMenu
        {
            get
            {
                if (mainMenu == null)
                {
                    mainMenu = new Menu();
                }
                return mainMenu;

            }
        }

    }
}

using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.DL;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.UserForms;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.AdminForms;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.Universal_Forms;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.RegistrationForms;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoadingForm());
        }
    }
}

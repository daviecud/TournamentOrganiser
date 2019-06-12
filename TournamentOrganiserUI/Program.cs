using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentOrganiserUI
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

            //Initialize the database conections
            OrganiserLibrary.GlobalConfig.InitializeConnections(true, true);
            Application.Run(new PrizeCreationForm());

            //Application.Run(new TournamentDashboardForm());

            //

        }
    }
}

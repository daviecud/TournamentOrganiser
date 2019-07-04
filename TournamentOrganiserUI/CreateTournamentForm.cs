using OrganiserLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentOrganiserUI
{
    public partial class CreateTournamentForm : Form
    {

        private List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        private List<TeamModel> selectedTeams = new List<TeamModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
        }

        private void WireUpTeamList()
        {
            selectTeamDropDown.DataSource = null;

            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            teamListBox.DataSource = null;

            teamListBox.DataSource = selectedTeams; 
            teamListBox.DisplayMember = "TeamName";
        }



        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {

        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;

            if (t != null) 
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
            }
        }

        private void DeleteSelectedTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel team = (TeamModel)teamListBox.SelectedItem;

            if (team != null)
            {
                selectedTeams.Remove(team);
                availableTeams.Add(team);
            }
        }
    }
}

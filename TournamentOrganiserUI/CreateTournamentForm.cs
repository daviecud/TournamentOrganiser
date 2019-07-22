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
    public partial class CreateTournamentForm : Form, IPrizeRequest, ITeamRequest
    {

        private List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        private List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpTeamList();

        }

        private void WireUpTeamList()
        {
            selectTeamDropDown.DataSource = null;

            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            teamListBox.DataSource = null;

            teamListBox.DataSource = selectedTeams; 
            teamListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;

            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
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

                WireUpTeamList();
            }
        }

        private void DeleteSelectedTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel team = (TeamModel)teamListBox.SelectedItem;

            if (team != null)
            {
                selectedTeams.Remove(team);
                availableTeams.Add(team);

                WireUpTeamList();
            }
        }

        private void PrizeButton_Click(object sender, EventArgs e)
        {
            //Call the CreatePrizeForm
            PrizeCreationForm form = new PrizeCreationForm(this);
            form.Show();

            
        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get back from the form a PrizeModel
            //Take the PrizeModel and populate the prizeList
            selectedPrizes.Add(model);
            WireUpTeamList();
        }

        private void DeleteSelectedPrizesButton_Click(object sender, EventArgs e)
        {
            PrizeModel prize = (PrizeModel)prizesListBox.SelectedItem;

            if (prize != null)
            {
                selectedPrizes.Remove(prize);

                WireUpTeamList();
            }
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpTeamList();
        }

        private void CreateTeamLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm form = new CreateTeamForm(this);
            form.Show();
        }

        private void CreateTourneButton_Click(object sender, EventArgs e)
        {

            //Validate data
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(entryFeeBox.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee", "Invalid Fee",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            //Create Tournament model
            TournamentModel tourm = new TournamentModel();

            tourm.TournamentName = tournamentNameBox.Text;
            tourm.EntryFee = fee;

            foreach (PrizeModel prize in selectedPrizes)
            {
                tourm.Prizes.Add(prize);
            }

            tourm.EnteredTeams = selectedTeams;

            //Wire our matchups
           
            TournamentLlogic.CreateRounds(tourm);

            //Create Tournament entry
            //Create all of the prizes entries
            //Create all of the team entries

            GlobalConfig.Connection.CreateTournament(tourm);

            
        }
    }
}

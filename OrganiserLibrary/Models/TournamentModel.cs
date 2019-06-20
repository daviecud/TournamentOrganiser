using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiserLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// THis is to create Tournament name on Tournament Creator form
        /// </summary>
        public String TournamentName { get; set; }
        /// <summary>
        /// This will allow admin to enter entry fee for tournament on the Tournament Creator Form
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// This will populate the tournamentsPLayersListBox on the tournament creator form
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }
        /// <summary>
        /// This will populate the prizesListBox on the tournament creator form after the create button
        /// is clicked and the create prize form is completed.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; }
        /// <summary>
        /// This is not visible on any UI this is created to organise the round of the tournament in the background, 
        /// it is a List of a List of the MatchupModel class and the rounds of the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; }
    }
}

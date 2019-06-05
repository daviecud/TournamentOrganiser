using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiserLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// This is to create TeamName for create Team form
        /// </summary>
        public String TeamName { get; set; }

        /// <summary>
        /// This will populate the tournamentPlayersListBox with players from the dropdown on create team form
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; }
    }
}

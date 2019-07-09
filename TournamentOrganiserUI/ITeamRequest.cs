using OrganiserLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentOrganiserUI
{
    public interface ITeamRequest
    {
        void TeamComplete(TeamModel model);
    }
}

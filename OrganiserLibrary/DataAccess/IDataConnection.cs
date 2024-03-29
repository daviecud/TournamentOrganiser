﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiserLibrary
{
   public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);
        TeamModel CreateTeam(TeamModel model);

        TournamentModel CreateTournament(TournamentModel model);
        List<PersonModel> GetPerson_All();

        List<TeamModel> GetTeam_All();
    }
}

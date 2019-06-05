using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiserLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// This is used to get the entries to the tournament and create a List from the MatchupEntry class matchups
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }

}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{
    public class TournamentModel
    {
        public int Id { get; set; } 
        /// <summary> Name of the Tournament </summary>
        public string TournamentName { get; set; }
        /// <summary> The entry fee for joining tournament </summary>
        public decimal EntryFee { get; set; }
        /// <summary> List of all the teams that have joined the tournament </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary> The prizes in the tournament </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary> The rounds of the tournament </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }

}
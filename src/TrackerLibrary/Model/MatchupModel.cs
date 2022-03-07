using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{
    public class MatchupModel
    {
        public int Id { get; set; } 
        /// <summary> Represents a matchup of two teams </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        public int WinnerId { get; set; }   
        /// <summary> Represents the winner of two teams from a matchup</summary>
        public TeamModel Winner { get; set; }
        /// <summary> Represents the round of the matchup </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = "";
                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null) 
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName}";
                        }
                    }
                    else
                    {
                        output = "Matchup Not Yet Determined";
                        break;
                    }

                }
                return output;
            }
        }

    }
}

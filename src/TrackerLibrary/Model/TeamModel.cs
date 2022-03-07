using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{
    public class TeamModel
    {
        public int Id { get; set; }
        /// <summary> Represents a team by their name </summary>
        public string TeamName { get; set; }

        /// <summary> Represents a team consisting of persons </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    }
}

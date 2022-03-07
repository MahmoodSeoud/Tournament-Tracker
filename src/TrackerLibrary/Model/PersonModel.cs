using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{
    public class PersonModel
    {
        /// <summary>
        /// The unique Id for the Prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary> First name of a person </summary>
        public string firstName { get; set; }

        /// <summary> Last name of a person </summary>
        public string LastName { get; set; }
        /// <summary> Email of a person </summary>
        public string EmailAdress { get; set; }
        /// <summary> Phone number of a person </summary>
        public string CellPhoneNumber { get; set; }
        public string FullName
        {
            get
            {
                return $"{firstName} {LastName}";
            }
        }
    }
}
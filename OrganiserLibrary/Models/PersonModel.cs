using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiserLibrary
{
    public class PersonModel
    { 
        /// <summary>
        /// The unique identifier for the person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// To create firstname for player on the create team form
        /// </summary>
        public String Firstname { get; set; }
        /// <summary>
        /// TO create Lastname for player on the create team form
        /// </summary>
        public String Lastname { get; set; }
        /// <summary>
        /// To create email address for player on the create team form
        /// </summary>
        public String Email { get; set; }
        /// <summary>
        /// To create telNumber for player on Add new Member section on the create team form
        /// </summary>
        public String TelNumber { get; set; }

        public string FullName
        {
            get {
                return $"{Firstname} {Lastname}";
            }
        }
    }
}

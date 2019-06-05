using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiserLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// This will set the place number as a int ie. 1,2,3.....
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// THis will set the winners places by name ie. First, Champion, Runner-Up
        /// </summary>
        public String PlaceName { get; set; }
        /// <summary>
        /// This is used to set the Priaze amount for the competitors on the create prize form
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// This is used to set the prize amount by percentage of income from the touranament 
        /// and if PrizeAmount is not use. This is on the create prize form
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}

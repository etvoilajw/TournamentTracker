using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents the prize
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place of the prize
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of the prize place
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the amount the prize
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of the prize
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}

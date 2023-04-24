using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents the prize
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents the unique id for the prize
        /// </summary>
        public int Id { get; set; }
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

        public PrizeModel()
        {

        }
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeName, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }
    }
}

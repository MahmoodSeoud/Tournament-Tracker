using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TrackerLibrary.Model
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique Id for the Prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary> The place the team got on </summary>
        public int PlaceNumber { get; set; }
        /// <summary> The name of the place the team got </summary>
        /// <example> Champions </example>
        public string PlaceName { get; set; }
        /// <summary> The amount of money won on this place </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary> The amount of money won on this place in percentage </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string pricePercentage)
        {
            PlaceName = placeName;
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(pricePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
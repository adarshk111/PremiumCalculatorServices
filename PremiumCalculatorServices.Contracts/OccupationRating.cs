using System;
using System.Collections.Generic;
using System.Text;

namespace PremiumCalculatorServices.Contracts
{
    public class OccupationRating
    {
        public string Occupation { get; set; }

        public string Rating { get; set; }

        public double RatingFactor { get; set; }
    }
}

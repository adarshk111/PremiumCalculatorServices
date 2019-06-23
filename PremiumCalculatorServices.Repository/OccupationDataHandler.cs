using System;
using System.Collections.Generic;
using System.Linq;
using PremiumCalculatorServices.Contracts;
using PremiumCalculatorServicesDataStore;

namespace PremiumCalculatorServices.Repository
{
    public class OccupationDataHandler : IOccupationDataHandler
    {
        public double GetCalculatedPremium(UserDetails userDetails)
        {
            string rating = OccupationData.GetOccupationRating(userDetails.Occupation);
            double factor = OccupationData.GetRatingFactor(rating);
            int age = DateTime.Now.Year - userDetails.DoB.Year;

            return (userDetails.SumInsured * factor * age) / (1000 * 12);
        }

        public List<string> GetOccupationList()
        {
            return OccupationData.GetOccupationList().Select(x => x.Occupation).ToList();
        }
    }
}

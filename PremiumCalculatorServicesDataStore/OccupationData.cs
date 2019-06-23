using PremiumCalculatorServices.Contracts;
using System;
using System.Collections.Generic;

namespace PremiumCalculatorServicesDataStore
{
    public static class OccupationData
    {
        private static Dictionary<string, double> RatingFactorsDict = new Dictionary<string, double>();
        private static Dictionary<string, string> OccupationRatingDict = new Dictionary<string, string>();
        public static List<OccupationRating> GetOccupationList()
        {
          return
           new List<OccupationRating>(){
            new OccupationRating()
            {
                Occupation = "Cleaner",
                Rating = "Light Manual"
            },
            new OccupationRating()
            {
                Occupation = "Doctor",
                Rating = "Professional"
            },
            new OccupationRating()
            {
                Occupation = "Author",
                Rating = "White Collar"
            },
            new OccupationRating()
            {
                Occupation = "Farmer",
                Rating = "Heavy Manual"
            },
            new OccupationRating()
            {
                Occupation = "Mechanic",
                Rating = "Heavy Manual"
            },
            new OccupationRating()
            {
                Occupation = "FLorist",
                Rating = "Light Manual"
            }
            };
        }

        public static double GetRatingFactor(string rating)
        {
            if(RatingFactorsDict.Count == 0 )
            {
                RatingFactorsDict.Add("Professional", 1.0);
                RatingFactorsDict.Add("White Collar", 1.25);
                RatingFactorsDict.Add("Light Manual", 1.5);
                RatingFactorsDict.Add("Heavy Manual", 1.75);
            }

            return (RatingFactorsDict.ContainsKey(rating) ? RatingFactorsDict[rating] : 0);
           
        }

        public static string GetOccupationRating(string occupation)
        {
            if (OccupationRatingDict.Count == 0)
            {
                OccupationRatingDict.Add("Cleaner", "Light Manual");
                OccupationRatingDict.Add("Doctor", "Professional");
                OccupationRatingDict.Add("Author", "White Collar");
                OccupationRatingDict.Add("Farmer", "Heavy Manual");
                OccupationRatingDict.Add("Mechanic", "Heavy Manual");
                OccupationRatingDict.Add("FLorist", "Light Manual");
            }

            return (OccupationRatingDict.ContainsKey(occupation) ? OccupationRatingDict[occupation] : string.Empty);

        }
    }
}

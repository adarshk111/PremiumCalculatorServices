using System;

namespace PremiumCalculatorServices.Contracts
{
    public class UserDetails
    {
        public string Name { get; set; }

        public DateTime DoB { get; set; }

        public int CalculatedAge { get; set; }

        public string Occupation { get; set; }

        public double SumInsured { get; set; }
    }
}

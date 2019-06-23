using PremiumCalculatorServices.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremiumCalculatorServices.Repository
{
    public interface IOccupationDataHandler
    {
        List<string> GetOccupationList();

        double GetCalculatedPremium(UserDetails userDetails);
    }
}

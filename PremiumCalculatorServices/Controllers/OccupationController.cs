using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PremiumCalculatorServices.Contracts;
using PremiumCalculatorServices.Repository;

namespace PremiumCalculatorServices.Controllers
{
    [Route("api/Occupation")]
    [ApiController]
    public class OccupationController : ControllerBase
    {
        private IOccupationDataHandler _dataHandler;
        // GET api/values
        public OccupationController(IOccupationDataHandler dataHandler)
        {
            _dataHandler = dataHandler;
        }
        [HttpGet]
        [Route("GetOccupationList")]
        public IActionResult GetOccupationList()
        {
            List<string> occupationList = null;
            try
            {
                occupationList = _dataHandler.GetOccupationList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok(occupationList);
        }

        [HttpPost]
        [Route("GetPremium")]
        public IActionResult GetPremium([FromBody] UserDetails userDetails)
        {
            double premiumAmount;
            try
            {
                premiumAmount = _dataHandler.GetCalculatedPremium(userDetails);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok(premiumAmount);
        }



    }
}

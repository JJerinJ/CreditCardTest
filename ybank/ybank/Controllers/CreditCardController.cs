using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ybank.Services;

namespace ybank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        [HttpPost(Name = "checkValidCard")]
        public bool checkCreditCard(string number)
        {
            Common services = new Common();
            if (services.isNumber(number))
            {
                int[] digits = number.Select(c =>int.Parse(c.ToString())).ToArray();
               
                return services.IsCreditCardValid(digits);
            }
            return false;
        }
    }
}

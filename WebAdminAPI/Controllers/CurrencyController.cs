using Microsoft.AspNetCore.Mvc;

namespace WebAdminAPI.Controllers
{
    // [Authorize]
    [ApiController]
    [Route("[controller]")]
    // [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class CurrencyController : ControllerBase
    {

        private static readonly Random getrandom = new Random();

        private readonly ILogger<CurrencyController> _logger;




        public CurrencyController(ILogger<CurrencyController> logger)
        {
            _logger = logger;
        }



        [HttpGet(Name = "GetCurrenciesRate")]
        public IEnumerable<Currency> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Currency
            {
                Name = ,
                Rate = Math.Round(getrandom.NextDouble() + getrandom.Next(1, 5), 2)
            }).ToArray();
        }
    }
}
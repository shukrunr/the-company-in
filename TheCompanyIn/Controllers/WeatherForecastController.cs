using Microsoft.AspNetCore.Mvc;

namespace TheCompanyIn.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompaniesController : ControllerBase
    {
        private readonly ILogger<CompaniesController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private static Dictionary<string, Company> Companies = new();

        public CompaniesController(ILogger<CompaniesController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet("search/{name}")]
        public async Task<ActionResult<Company>> GetAsync(string name)
        {
            var httpClient = _httpClientFactory.CreateClient("client");
            var httpResponseMessage = await httpClient.GetAsync(
                      "https://company.clearbit.com/v2/companies/find?domain=" + name);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var company = await httpResponseMessage.Content.ReadFromJsonAsync<Company?>();
                Companies.Add(company.Id, company);
                return Ok(company);
            }

            return NotFound();
        }

        [HttpGet("company/{id}")]
        public ActionResult<Company> GetCompany(string id)
            => Companies.TryGetValue(id, out Company? comp) ? Ok(comp) : NotFound();

        [HttpGet("list")]
        public ActionResult<Company> GetCompanies() => Ok(Companies.Values);
    }


}
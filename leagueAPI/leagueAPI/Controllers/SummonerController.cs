using leagueAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace leagueAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummonerController : ControllerBase
    {
        private readonly ISummonerRepository summonerRepository;

        public SummonerController(ISummonerRepository summonerRepository)
        {
            this.summonerRepository = summonerRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetSummonerByName(string region, string name)
        {
            return Ok(summonerRepository.GetSummonerByNameAsync(region, name));
        }
    }
}

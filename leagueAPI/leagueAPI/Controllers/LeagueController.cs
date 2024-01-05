using leagueAPI.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace leagueAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeagueController : ControllerBase
    {
        private readonly ICommunicator communicator;

        public LeagueController(ICommunicator communicator)
        {
            this.communicator = communicator;
        }

        [HttpGet]
        public async Task<HttpContent> GetPlayerInfo() {
            return await communicator.GetPlayerInfo();
        }
    }
}

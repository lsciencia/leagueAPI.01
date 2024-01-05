using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace leagueAPI.Helper
{
    public class Communicator : ICommunicator
    {
        private readonly string apiKey;

        HttpClient client = new HttpClient();
        public Communicator()
        {
            apiKey = SecretKey.KEY;
        }
        public async Task<HttpContent> GetPlayerInfo()
        {
            Uri uri = new Uri("https://br1.api.riotgames.com/lol/summoner/v4/summoners/by-name/De%20Troppus?api_key=" + apiKey);
            HttpResponseMessage response = await client.GetAsync(uri);
            return response.Content;
        }
    }
}
